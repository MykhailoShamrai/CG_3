using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK_3.Converters
{
    internal class YCbCrConverter : IConverter
    {
        public Vector3[,] Convert(Bitmap bitmap, ColorProfile profile, Iluminant iluminant)
        {
            Vector3[,] ret = new Vector3[bitmap.Width, bitmap.Height];

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var col = bitmap.GetPixel(i, j);
                    Vector3 normalisedColors = new Vector3((float)col.R / 255, (float)col.G / 255, (float)col.B / 255);
                    float Y = normalisedColors.X * 0.299f + normalisedColors.Y * 0.587f + normalisedColors.Z * 0.114f;
                    float Cb = (normalisedColors.Y - Y) / 1.772f + 0.5f;
                    float Cr = (normalisedColors.X - Y) / 1.402f + 0.5f;
                    ret[i, j].X = Y;
                    ret[i, j].Y = Cb;
                    ret[i, j].Z = Cr;
                }
            }
            return ret;
        }

        public void DrawToBitmap(Bitmap bitmapFirst, Bitmap bitmapSecond, Bitmap bitmapThird, Vector3[,] values)
        {
            for (int i = 0; i < bitmapFirst.Width; i++)
            {
                for (int j = 0; j < bitmapFirst.Height; j++)
                {
                    Vector3 v = values[i, j];
                    int Y = (int)(v.X * 255);
                    int Cb = (int)(v.Y * 255);
                    int Cr = (int)(v.Z * 255);
                    bitmapFirst.SetPixel(i, j, Color.FromArgb(Y, Y, Y));
                    bitmapSecond.SetPixel(i, j, Color.FromArgb(127, 255 - Cb, Cb));
                    bitmapThird.SetPixel(i, j, Color.FromArgb(Cr, 255 - Cr, 127));
                }
            }
        }
    }
}
