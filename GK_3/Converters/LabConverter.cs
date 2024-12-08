using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK_3.Converters
{

    public class LabConverter: IConverter
    {
        public Vector3[,] Convert(Bitmap bitmap, ColorProfile profile, Iluminant iluminant)
        {
            Vector3[,] ret = new Vector3[bitmap.Width, bitmap.Height];

            Iluminant D65 = Iluminant.GenerateIlluminant(Iluminant.IlluminantPredefinedType.D65);

            Vector3 xyYWhiteSourceIlumniant = IConverter.xyYForIluminant(D65);
            Vector3 XYZWhiteSourceIluminant = IConverter.xyYToXYZ(xyYWhiteSourceIlumniant);

            Vector3 xyYWhiteTargetIluminant = IConverter.xyYForIluminant(iluminant);
            Vector3 XYZWhiteTargetIluminant = IConverter.xyYToXYZ(xyYWhiteTargetIluminant);

            Matrix4x4 xyzForColorProfile = IConverter.xyzMatrixForColorProfile(profile);
            // Good to check value here!!! Now I don't now what should I do if smth is wrong
            Matrix4x4 invertxyz;
            Matrix4x4.Invert(xyzForColorProfile, out invertxyz);

            Vector3 SRGB = Vector3.Transform(XYZWhiteSourceIluminant, invertxyz);

            Matrix4x4 transformMatrix = xyzForColorProfile * new Matrix4x4(SRGB.X, 0, 0, 0,
                                                                            0, SRGB.Y, 0, 0,
                                                                            0, 0, SRGB.Z, 0,
                                                                            0, 0, 0, 1);
            Matrix4x4 Bradford = BradfordMatrixFinder.CalculateBradfordMatrix(XYZWhiteSourceIluminant, XYZWhiteTargetIluminant);
            transformMatrix = Bradford * transformMatrix;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var col = bitmap.GetPixel(i, j);
                    Vector3 RGBForPixel = new Vector3((float)col.R / 255, (float)col.G / 255, (float)col.B / 255);
                    Vector3 XYZForPixel = Vector3.Transform(RGBForPixel, transformMatrix);
                    float t = XYZForPixel.Y / XYZWhiteTargetIluminant.Y;
                    float rootT = MathF.Pow(t, 1.0f / 3);
                    float L = t > 0.008856 ? 116 * rootT : 903.3f * t;
                    float a = 500 * (MathF.Pow(XYZForPixel.X / XYZWhiteTargetIluminant.X, 1.0f / 3) - rootT);
                    float b = 200 * (rootT - MathF.Pow(XYZForPixel.Z /  XYZWhiteTargetIluminant.Z, 1.0f / 3));
                    ret[i, j].X = L;
                    ret[i, j].Y = a;
                    ret[i, j].Z = b;
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
                    bitmapFirst.SetPixel(i, j, Color.FromArgb((int)v.X, (int)v.X, (int)v.X));
                    bitmapSecond.SetPixel(i, j, Color.FromArgb((int)v.Y + 127, - ((int)v.Y - 127), 127));
                    bitmapThird.SetPixel(i, j, Color.FromArgb((int)v.Z + 127, 127, - ((int)v.Z - 127)));
                }
            }
        }
    }
}
