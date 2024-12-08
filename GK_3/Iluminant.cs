using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_3
{
    public class Iluminant
    {
        public IlluminantPredefinedType Type { get; set; }
        public float XWhite { get; set; }
        public float YWhite { get; set; }
        public Iluminant(float xWhite, float yWhite, IlluminantPredefinedType type)
        {
            XWhite = xWhite;
            YWhite = yWhite;
            Type = type;
        }


        public enum IlluminantPredefinedType
        {
            D65, Custom
        }

        public static Iluminant GenerateIlluminant(IlluminantPredefinedType type)
        {
            Iluminant ret = new Iluminant(0.31273f, 0.329020f, IlluminantPredefinedType.Custom);
            switch (type)
            {
                case IlluminantPredefinedType.D65:
                    ret = new Iluminant(0.31273f, 0.329020f, IlluminantPredefinedType.D65);
                    break;
            }
            return ret;
        }
    }
}
