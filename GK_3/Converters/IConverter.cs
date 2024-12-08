using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK_3.Converters
{
    public interface IConverter
    {
        public Vector3[,] Convert(Bitmap bitmap, ColorProfile profile, Iluminant iluminant);


        public static Vector3 xyYForIluminant(Iluminant iluminant)
        {
            return new Vector3(iluminant.XWhite, iluminant.YWhite, 1);
        }

        public static Vector3 xyYToXYZ(Vector3 xyY)
        {
            float X = xyY.X * xyY.Z / xyY.Y;
            float Y = xyY.Z;
            float Z = (1 - xyY.X - xyY.Y) * xyY.Z / xyY.Y;
            return new Vector3(X, Y, Z);
        }

        public static Matrix4x4 xyzMatrixForColorProfile(ColorProfile profile)
        {
            return new Matrix4x4(profile.XRed, profile.XGreen, profile.XBlue, 0,
                                profile.YRed, profile.YGreen, profile.YBlue, 0,
                                1 - profile.XRed - profile.YRed, 1 - profile.XGreen - profile.YGreen, 1 - profile.XBlue - profile.YBlue, 0,
                                0, 0, 0, 1);
        }
    }
}
