using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_3
{
    public class ColorProfile
    {
        public double XRed { get; set; }
        public double YRed { get; set; }
        public double XGreen { get; set; }
        public double YGreen { get; set; }
        public double XBlue { get; set; }
        public double YBlue { get; set; }
        public double Gamma { get; set; }

        public ColorProfile(double xRed, double yRed, double xGreen, double yGreen,
            double xBlue, double yBlue, double gamma)
        {
            XRed = xRed;
            YRed = yRed;
            XGreen = xGreen;
            YGreen = yGreen;
            XBlue = xBlue;
            YBlue = yBlue;
            Gamma = gamma;
        }

        public enum ColorProfileType
        {
            sRGB, AdobeRGB, WideGamut, Custom
        }

        public static ColorProfile GenerateColorProfile(ColorProfileType type)
        {
            // for sRGB and for Custom, parameters will be the same
            ColorProfile ret = new ColorProfile(0.64, 0.33, 0.3, 0.6, 0.15, 0.06, 2.2); 
            switch (type)
            {
                case ColorProfileType.AdobeRGB:
                    ret = new ColorProfile(0.64, 0.33, 0.21, 0.71, 0.15, 0.06, 2.2);
                    break;
                case ColorProfileType.WideGamut:
                    ret = new ColorProfile(0.7347, 0.2653, 0.1152, 0.8264, 0.1566, 0.0177, 1.2);
                    break;
            }
            return ret;
        }
    }
}
