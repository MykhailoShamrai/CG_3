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
            transformMatrix = Matrix4x4.Multiply(Bradford, transformMatrix);
            float gamma = profile.Gamma;
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    var col = bitmap.GetPixel(i, j);
                    Vector3 RGBForPixel = new Vector3((float)col.R / 255, (float)col.G / 255, (float)col.B / 255);
                    // Here I must also use gamma correction
                    RGBForPixel.X = MathF.Pow(RGBForPixel.X, 1.0f / gamma);
                    RGBForPixel.Y = MathF.Pow(RGBForPixel.Y, 1.0f / gamma);
                    RGBForPixel.Z = MathF.Pow(RGBForPixel.Z, 1.0f / gamma);
                    Vector3 XYZForPixel = Vector3.Transform(RGBForPixel, transformMatrix);
                    float t = XYZForPixel.Y / XYZWhiteTargetIluminant.Y;
                    float rootY = MathF.Pow(t, 1.0f / 3);
                    if (float.IsNaN(rootY))
                        rootY = 0;
                    float L = t > 0.008856 ? 116 * rootY : 903.3f * t;
                    float rootX = MathF.Pow(XYZForPixel.X / XYZWhiteTargetIluminant.X, 1.0f / 3);
                    if (float.IsNaN(rootX))
                    {
                        rootX = 0;
                    }
                    float a = 500 * (rootX - rootY);
                    float rootZ = MathF.Pow(XYZForPixel.Z / XYZWhiteTargetIluminant.Z, 1.0f / 3);
                    if (float.IsNaN (rootZ))
                    {
                        rootZ = 0;
                    }
                    float b = 200 * (rootY - rootZ);
                    ret[i, j].X = Math.Clamp(L, 0, 100);
                    ret[i, j].Y = Math.Clamp(a, -127, 127);
                    ret[i, j].Z = Math.Clamp(b, -127, 127);
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
