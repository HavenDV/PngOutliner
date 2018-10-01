using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using PngOutlinerApplication.Extensions;

namespace PngOutlinerApplication
{
    public partial class MainForm : Form
    {
        #region Properties

        private string Path1 { get => Image1TextBox.Text; set => Image1TextBox.Text = value; }
        private string Path2 { get => Image2TextBox.Text; set => Image2TextBox.Text = value; }
        private Color Color1 { get; set; }
        private Color Color2 { get; set; }
        private int Thickness1 => int.TryParse(Thickness1TextBox.Text, out var result) ? result : 0;
        private int Thickness2 => int.TryParse(Thickness2TextBox.Text, out var result) ? result : 0;
        private Mat OutputMat { get; set; }

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event Handlers

        private void Browse1Button_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog
            {
                DefaultExt = "png",
                Filter = @".png images|*.png",
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                Path1 = dialog.FileName;
            }
        }

        private void Browse2Button_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog
            {
                DefaultExt = "png",
                Filter = @".png images|*.png",
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                Path2 = dialog.FileName;
            }
        }

        private void Color1Button_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Color1 = ColorDialog.Color;
            Color1Button.BackColor = Color1;
        }

        private void Color2Button_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            Color2 = ColorDialog.Color;
            Color2Button.BackColor = Color2;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (OutputMat.IsEmpty)
            {
                return;
            }

            using (var dialog = new SaveFileDialog
            {
                DefaultExt = "png",
                Filter = @"Images|*.png;*.bmp;*.jpg",
                FileName = Path.GetFileNameWithoutExtension(Path1) + "_stroked"
            })
            {
                if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    return;
                }

                OutputMat.Save(dialog.FileName);
            }
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Path1) || !File.Exists(Path1) ||
                string.IsNullOrWhiteSpace(Path2) || !File.Exists(Path2))
            {
                return;
            }

            Process(Path1, Path2);

            SaveButton.Enabled = true;
        }

        #endregion

        #region Private Methods

        private void Process(string path1, string path2)
        {
            using (var mat1 = new Mat(path1, ImreadModes.Unchanged))
            using (var mat2 = new Mat(path2, ImreadModes.Unchanged))
            using (var dst1 = new Mat(mat1.Size, mat1.Depth, mat1.NumberOfChannels))
            using (var dst2 = new Mat(mat1.Size, mat1.Depth, mat1.NumberOfChannels))
            using (var binary = new Mat())
            {
                var splitted1 = mat1.Split();
                using (splitted1[0])
                using (splitted1[1])
                using (splitted1[2])
                using (var mask1 = splitted1[3])
                {
                    CvInvoke.Add(dst1, mat1, dst1, mask1);
                }

                var splitted2 = mat2.Split();
                using (splitted2[0])
                using (splitted2[1])
                using (splitted2[2])
                using (var mask2 = splitted2[3])
                {
                    CvInvoke.Add(dst1, mat2, dst1, mask2);
                }

                CvInvoke.Canny(dst1, binary, 100, 200);

                var contours = new VectorOfVectorOfPoint();
                CvInvoke.FindContours(binary, contours, null, RetrType.Tree, ChainApproxMethod.ChainApproxTc89Kcos);

                for (var i = 0; i < contours.Size; ++i)
                {
                    CvInvoke.DrawContours(dst2, contours, i, ToScalar(Color1), Thickness1 + Thickness2, LineType.AntiAlias);
                }
                for (var i = 0; i < contours.Size; ++i)
                {
                    CvInvoke.DrawContours(dst2, contours, i, ToScalar(Color2), Thickness2, LineType.AntiAlias);
                }

                var dstImage = dst2.ToImage<Bgra, byte>();
                using (var srcImage1 = mat1.ToImage<Bgra, byte>())
                using (var srcImage2 = mat2.ToImage<Bgra, byte>())
                using (var dstImage1 = dst1.ToImage<Bgra, byte>())
                {
                    dstImage.SetIfAlpha(dstImage1);
                    dstImage.SetIfAlpha(srcImage2);
                    dstImage.SetIfAlpha(srcImage1);
                }

                OutputMat = dstImage.Mat;
                ImageBox.DisplayedImage = dstImage.Mat;
            }
        }

        private static MCvScalar ToScalar(Color color)
        {
            return new MCvScalar(color.B, color.G, color.R, color.A);
        }

        #endregion
    }
}
