using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_3
{
    public class ColorProfile
    {
        public ColorProfileType Type { get; set; }
        public float XRed { get; set; }
        public float YRed { get; set; }
        public float XGreen { get; set; }
        public float YGreen { get; set; }
        public float XBlue { get; set; }
        public float YBlue { get; set; }
        public float Gamma { get; set; }

        public ColorProfile(float xRed, float yRed, float xGreen, float yGreen,
            float xBlue, float yBlue, float gamma, ColorProfileType type)
        {
            XRed = xRed;
            YRed = yRed;
            XGreen = xGreen;
            YGreen = yGreen;
            XBlue = xBlue;
            YBlue = yBlue;
            Gamma = gamma;
            Type = type;
        }

        public enum ColorProfileType
        {
            sRGB, AdobeRGB, WideGamut, Custom
        }

        public static ColorProfile GenerateColorProfile(ColorProfileType type)
        {
            // for sRGB and for Custom, parameters will be the same
            ColorProfile ret = new ColorProfile(0.64f, 0.33f, 0.3f, 0.6f, 0.15f, 0.06f, 2.2f, ColorProfileType.Custom); 
            switch (type)
            {
                case ColorProfileType.sRGB:
                    ret = new ColorProfile(0.64f, 0.33f, 0.3f, 0.6f, 0.15f, 0.06f, 2.2f, ColorProfileType.sRGB);
                    break;
                case ColorProfileType.AdobeRGB:
                    ret = new ColorProfile(0.64f, 0.33f, 0.21f, 0.71f, 0.15f, 0.06f, 2.2f, ColorProfileType.AdobeRGB);
                    break;
                case ColorProfileType.WideGamut:
                    ret = new ColorProfile(0.7347f, 0.2653f, 0.1152f, 0.8264f, 0.1566f, 0.0177f, 1.2f, ColorProfileType.WideGamut);
                    break;
            }
            return ret;
        }
    }
}
