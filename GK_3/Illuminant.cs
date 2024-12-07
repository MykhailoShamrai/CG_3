using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_3
{
    public class Illuminant
    {
        public double XWhite { get; set; }
        public double YWhite { get; set; }
        public Illuminant(double xWhite, double yWhite)
        {
            XWhite = xWhite;
            YWhite = yWhite;
        }

        public enum IlluminantPredefinedType
        {
            D65, Custom
        }

        public static Illuminant GenerateIlluminant(IlluminantPredefinedType type)
        {
            Illuminant ret = new Illuminant(0.31273, 0.329020);
            return ret;
        }
    }
}
