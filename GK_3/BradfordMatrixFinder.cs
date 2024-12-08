using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GK_3
{
    public static class BradfordMatrixFinder
    {
        private static Matrix4x4 BaseMatrix = new Matrix4x4(0.8951f, 0.2664f, -0.1614f, 0,
                                                   -0.7502f, 1.7135f, 0.0367f, 0,
                                                    0.0389f, -0.0685f, 1.0296f,  0,
                                                    0, 0, 0, 1);
        private static Matrix4x4 InversionOfBaseMatrix = new Matrix4x4(0.9870f, -0.1471f, 0.1600f, 0,
                                                               0.4823f, 0.5184f, 0.0493f, 0,
                                                               -0.0085f, 0.0400f, 0.9685f, 0,
                                                               0, 0, 0, 1);

        public static Matrix4x4 CalculateBradfordMatrix(Vector3 XYZsourceWhite, Vector3 XYZtargetWhite)
        {
            Vector3 sourceRGB = Vector3.Transform(XYZsourceWhite, BaseMatrix);
            Vector3 targetRGB = Vector3.Transform(XYZtargetWhite, BaseMatrix);

            Matrix4x4 D = new Matrix4x4(targetRGB.X / sourceRGB.X, 0, 0, 0,
                                        0, targetRGB.Y / sourceRGB.Y, 0, 0,
                                        0, 0, targetRGB.Z / sourceRGB.Z, 0,
                                        0, 0, 0, 1);
            Matrix4x4 ret = Matrix4x4.Multiply(InversionOfBaseMatrix, D);
            ret = Matrix4x4.Multiply(ret, BaseMatrix);
            return ret;
        }

    }
}
