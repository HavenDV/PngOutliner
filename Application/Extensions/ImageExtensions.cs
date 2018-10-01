using System;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace PngOutlinerApplication.Extensions
{
    public static class ImageExtensions
    {
        public static Image<Bgr, byte> To(this Image<Bgr, byte> src, Func<byte, double> func, int channel = -1)
        {
            var dst = src.Clone();

            for (var x = 0; x < src.Width; x++)
            {
                for (var y = 0; y < src.Height; y++)
                {
                    if (channel > -1)
                    {
                        var k = channel;
                        dst.Data[y, x, k] = SaturateCast(func(src.Data[y, x, k]));
                    }
                    else
                    {
                        for (var k = 0; k < src.NumberOfChannels; k++)
                        {
                            dst.Data[y, x, k] = SaturateCast(func(src.Data[y, x, k]));
                        }
                    }
                }
            }

            return dst;
        }

        public static Image<TColor, byte> FuncImage<TColor>(Image<TColor, byte> src1, Image<TColor, byte> src2, Func<byte, byte, int, int, double> func)
            where TColor : struct, IColor
        {
            var dst = src1.Clone();

            for (var x = 0; x < src1.Width; x++)
            {
                for (var y = 0; y < src1.Height; y++)
                {
                    var channels = src1.NumberOfChannels;
                    var isRgba = channels > 3;
                    for (var k = 0; k < (isRgba ? 3 : channels); k++)
                    {
                        var value1 = src1.Data[y, x, k];
                        var value2 = src2.Data[y, x, k];

                        dst.Data[y, x, k] = func(value1, value2, x, y).SaturateCast();
                    }

                    if (isRgba)
                    {
                        var value1 = src1.Data[y, x, 3];
                        var value2 = src2.Data[y, x, 3];

                        dst.Data[y, x, 3] = Math.Max(value1, value2);
                    }
                }
            }

            return dst;
        }

        public static Mat FuncImage<TColor>(Mat src1, Mat src2, Func<byte, byte, int, int, double> func)
            where TColor : struct, IColor
        {
            /*
            using (var srcImage1 = src1.ToImage<TColor, byte>())
            using (var srcImage2 = src2.ToImage<TColor, byte>())
            {
                return FuncImage(srcImage1, srcImage2, func).Mat;
            }
            */
            return ImagesFunc<TColor>(src1, src2, (i1, i2) => FuncImage(i1, i2, func));
        }

        public static Mat ImagesFunc<TColor>(Mat src1, Mat src2,
            Func<Image<TColor, byte>, Image<TColor, byte>, Image<TColor, byte>> func)
            where TColor : struct, IColor
        {
            using (var srcImage1 = src1.ToImage<TColor, byte>())
            using (var srcImage2 = src2.ToImage<TColor, byte>())
            {
                return func(srcImage1, srcImage2).Mat;
            }
        }

        public static byte SaturateCast(this double value)
        {
            var rounded = Math.Round(value, 0);

            if (rounded < byte.MinValue)
            {
                return byte.MinValue;
            }

            if (rounded > byte.MaxValue)
            {
                return byte.MaxValue;
            }

            return (byte)rounded;
        }

        public static void Set(this Image<Bgr, byte> to, Image<Bgr, byte> from, Point offset)
        {
            for (var x = 0; x < from.Width; x++)
            {
                for (var y = 0; y < from.Height; y++)
                {
                    for (var k = 0; k < from.NumberOfChannels; k++)
                    {
                        to.Data[y + offset.Y, x + offset.X, k] = from.Data[y, x, k];
                    }
                }
            }
        }

        public static void SetIfAlpha(this Image<Bgra, byte> to, Image<Bgra, byte> from)
        {
            for (var x = 0; x < from.Width; x++)
            {
                for (var y = 0; y < from.Height; y++)
                {
                    var alpha = from.Data[y, x, 3];
                    if (alpha == 0)
                    {
                        continue;
                    }

                    for (var k = 0; k < 3; k++)
                    {
                        var a = alpha / 255.0;
                        var value1 = to.Data[y, x, k];
                        var value2 = from.Data[y, x, k];
                        to.Data[y, x, k] = SaturateCast((1.0 - a) * value1 + a * value2);
                    }

                    to.Data[y, x, 3] = SaturateCast(to.Data[y, x, 3] + alpha);
                }
            }
        }
    }
}
