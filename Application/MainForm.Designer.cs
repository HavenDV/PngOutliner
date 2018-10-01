namespace PngOutlinerApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.GroupBox SettingsGroupBox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Thickness2TextBox = new System.Windows.Forms.TextBox();
            this.Thickness1TextBox = new System.Windows.Forms.TextBox();
            this.Thickness2Label = new System.Windows.Forms.Label();
            this.Thickness1Label = new System.Windows.Forms.Label();
            this.Color2Button = new System.Windows.Forms.Button();
            this.Color1Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Image2TextBox = new System.Windows.Forms.TextBox();
            this.Image1TextBox = new System.Windows.Forms.TextBox();
            this.Browse2Button = new System.Windows.Forms.Button();
            this.Browse1Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.ImageBox = new Emgu.CV.UI.ImageBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.FirstAboveCheckBox = new System.Windows.Forms.CheckBox();
            SettingsGroupBox = new System.Windows.Forms.GroupBox();
            SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsGroupBox
            // 
            SettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            SettingsGroupBox.Controls.Add(this.FirstAboveCheckBox);
            SettingsGroupBox.Controls.Add(this.Thickness2TextBox);
            SettingsGroupBox.Controls.Add(this.Thickness1TextBox);
            SettingsGroupBox.Controls.Add(this.Thickness2Label);
            SettingsGroupBox.Controls.Add(this.Thickness1Label);
            SettingsGroupBox.Controls.Add(this.Color2Button);
            SettingsGroupBox.Controls.Add(this.Color1Button);
            SettingsGroupBox.Controls.Add(this.label2);
            SettingsGroupBox.Controls.Add(this.Image2TextBox);
            SettingsGroupBox.Controls.Add(this.Image1TextBox);
            SettingsGroupBox.Controls.Add(this.Browse2Button);
            SettingsGroupBox.Controls.Add(this.Browse1Button);
            SettingsGroupBox.Controls.Add(this.label1);
            SettingsGroupBox.Controls.Add(this.SaveButton);
            SettingsGroupBox.Controls.Add(this.ProcessButton);
            SettingsGroupBox.Location = new System.Drawing.Point(12, 12);
            SettingsGroupBox.Name = "SettingsGroupBox";
            SettingsGroupBox.Size = new System.Drawing.Size(647, 137);
            SettingsGroupBox.TabIndex = 3;
            SettingsGroupBox.TabStop = false;
            SettingsGroupBox.Text = "Settings";
            // 
            // Thickness2TextBox
            // 
            this.Thickness2TextBox.Location = new System.Drawing.Point(191, 107);
            this.Thickness2TextBox.Name = "Thickness2TextBox";
            this.Thickness2TextBox.Size = new System.Drawing.Size(65, 20);
            this.Thickness2TextBox.TabIndex = 13;
            this.Thickness2TextBox.Text = "4";
            // 
            // Thickness1TextBox
            // 
            this.Thickness1TextBox.Location = new System.Drawing.Point(191, 78);
            this.Thickness1TextBox.Name = "Thickness1TextBox";
            this.Thickness1TextBox.Size = new System.Drawing.Size(65, 20);
            this.Thickness1TextBox.TabIndex = 12;
            this.Thickness1TextBox.Text = "4";
            // 
            // Thickness2Label
            // 
            this.Thickness2Label.AutoSize = true;
            this.Thickness2Label.Location = new System.Drawing.Point(117, 110);
            this.Thickness2Label.Name = "Thickness2Label";
            this.Thickness2Label.Size = new System.Drawing.Size(68, 13);
            this.Thickness2Label.TabIndex = 11;
            this.Thickness2Label.Text = "Thickness 2:";
            // 
            // Thickness1Label
            // 
            this.Thickness1Label.AutoSize = true;
            this.Thickness1Label.Location = new System.Drawing.Point(117, 81);
            this.Thickness1Label.Name = "Thickness1Label";
            this.Thickness1Label.Size = new System.Drawing.Size(68, 13);
            this.Thickness1Label.TabIndex = 10;
            this.Thickness1Label.Text = "Thickness 1:";
            // 
            // Color2Button
            // 
            this.Color2Button.Location = new System.Drawing.Point(19, 105);
            this.Color2Button.Name = "Color2Button";
            this.Color2Button.Size = new System.Drawing.Size(92, 23);
            this.Color2Button.TabIndex = 9;
            this.Color2Button.Text = "Color 2";
            this.Color2Button.UseVisualStyleBackColor = true;
            this.Color2Button.Click += new System.EventHandler(this.Color2Button_Click);
            // 
            // Color1Button
            // 
            this.Color1Button.Location = new System.Drawing.Point(19, 76);
            this.Color1Button.Name = "Color1Button";
            this.Color1Button.Size = new System.Drawing.Size(92, 23);
            this.Color1Button.TabIndex = 8;
            this.Color1Button.Text = "Color 1";
            this.Color1Button.UseVisualStyleBackColor = true;
            this.Color1Button.Click += new System.EventHandler(this.Color1Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Second Image";
            // 
            // Image2TextBox
            // 
            this.Image2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Image2TextBox.Location = new System.Drawing.Point(98, 48);
            this.Image2TextBox.Name = "Image2TextBox";
            this.Image2TextBox.Size = new System.Drawing.Size(497, 20);
            this.Image2TextBox.TabIndex = 6;
            // 
            // Image1TextBox
            // 
            this.Image1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Image1TextBox.Location = new System.Drawing.Point(98, 19);
            this.Image1TextBox.Name = "Image1TextBox";
            this.Image1TextBox.Size = new System.Drawing.Size(497, 20);
            this.Image1TextBox.TabIndex = 5;
            // 
            // Browse2Button
            // 
            this.Browse2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse2Button.Location = new System.Drawing.Point(601, 46);
            this.Browse2Button.Name = "Browse2Button";
            this.Browse2Button.Size = new System.Drawing.Size(38, 23);
            this.Browse2Button.TabIndex = 4;
            this.Browse2Button.Text = "...";
            this.Browse2Button.UseVisualStyleBackColor = true;
            this.Browse2Button.Click += new System.EventHandler(this.Browse2Button_Click);
            // 
            // Browse1Button
            // 
            this.Browse1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse1Button.Location = new System.Drawing.Point(601, 17);
            this.Browse1Button.Name = "Browse1Button";
            this.Browse1Button.Size = new System.Drawing.Size(38, 23);
            this.Browse1Button.TabIndex = 3;
            this.Browse1Button.Text = "...";
            this.Browse1Button.UseVisualStyleBackColor = true;
            this.Browse1Button.Click += new System.EventHandler(this.Browse1Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Image";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Enabled = false;
            this.SaveButton.Location = new System.Drawing.Point(530, 75);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(109, 53);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessButton.Location = new System.Drawing.Point(426, 76);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(98, 52);
            this.ProcessButton.TabIndex = 0;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.ImageBox.Location = new System.Drawing.Point(12, 155);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(647, 358);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 2;
            this.ImageBox.TabStop = false;
            // 
            // FirstAboveCheckBox
            // 
            this.FirstAboveCheckBox.AutoSize = true;
            this.FirstAboveCheckBox.Checked = true;
            this.FirstAboveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FirstAboveCheckBox.Location = new System.Drawing.Point(296, 94);
            this.FirstAboveCheckBox.Name = "FirstAboveCheckBox";
            this.FirstAboveCheckBox.Size = new System.Drawing.Size(79, 17);
            this.FirstAboveCheckBox.TabIndex = 14;
            this.FirstAboveCheckBox.Text = "First Above";
            this.FirstAboveCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 525);
            this.Controls.Add(SettingsGroupBox);
            this.Controls.Add(this.ImageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Png Outliner";
            SettingsGroupBox.ResumeLayout(false);
            SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox ImageBox;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Image1TextBox;
        private System.Windows.Forms.Button Browse2Button;
        private System.Windows.Forms.Button Browse1Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Image2TextBox;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button Color1Button;
        private System.Windows.Forms.Button Color2Button;
        private System.Windows.Forms.Label Thickness1Label;
        private System.Windows.Forms.Label Thickness2Label;
        private System.Windows.Forms.TextBox Thickness1TextBox;
        private System.Windows.Forms.TextBox Thickness2TextBox;
        private System.Windows.Forms.CheckBox FirstAboveCheckBox;
    }
}

