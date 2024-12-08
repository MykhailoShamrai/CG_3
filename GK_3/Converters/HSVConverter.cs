using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK_3.Converters
{
    public class HSVConverter: IConverter
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
                    float cMax = MathF.Max(normalisedColors.X, MathF.Max(normalisedColors.Y, normalisedColors.Z));
                    float cMin = MathF.Min(normalisedColors.X, MathF.Min(normalisedColors.Y, normalisedColors.Z));
                    float delta = cMax - cMin;
                    float H;
                    float S = MathF.Abs(cMax) < 10e-7 ? 0 : delta / cMax;
                    // https://math.stackexchange.com/questions/556341/rgb-to-hsv-color-conversion-algorithm
                    float V = cMax;
                    if (V < 10e-7)
                    {
                        H = 0;
                        S = 0;
                    }
                    else if (MathF.Abs(delta) < 10e-7)
                    {
                        H = 0;
                    }
                    else if (MathF.Abs(cMax - normalisedColors.X) < 10e-7)
                    {
                        H = 60 * (normalisedColors.Y - normalisedColors.Z) / delta;
                    }
                    else if (MathF.Abs(cMax - normalisedColors.Y) < 10e-7)
                    {
                        H = 60 * (normalisedColors.Z - normalisedColors.X) / delta + 2;
                    }
                    else 
                    {
                        H = 60 * (normalisedColors.X - normalisedColors.Y) / delta + 4;
                    }

                    H = H < 0 ? (360 - (MathF.Abs(H) % 360)) : H % 360;
                    ret[i, j].X = H;
                    ret[i, j].Y = S;
                    ret[i, j].Z = V;
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
                    int H = (int)(v.X / 360 * 255);
                    int S = (int)(v.Y * 255);
                    int V = (int)(v.Z * 255);
                    bitmapFirst.SetPixel(i, j, Color.FromArgb(H, H, H));
                    bitmapSecond.SetPixel(i, j, Color.FromArgb(S, S, S));
                    bitmapThird.SetPixel(i, j, Color.FromArgb(V, V, V));
                }
            }
        }
    }
}
