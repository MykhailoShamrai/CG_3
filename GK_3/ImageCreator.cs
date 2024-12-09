using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_3
{
    public class ImageCreator
    {
        private readonly int Width = 800;
        private readonly int Height = 800;
        private readonly int BlockDim = 40;
        public Bitmap CreateImage()
        {
            Bitmap bitmap = new Bitmap(Width, Height);
            bool mode = true;
            for (int i = 0; i < Width; i++)
            {
                bool mode2 = !mode;
                for (int j = 0; j < Height; j++)
                {
                    if (i >= Width / 4 && i < 3 * Width / 4 && j >= Height / 4 && j < 3 * Height / 4)
                    {
                        int offseted_i = j - Height / 4;
                        int offseted_j = i - Width / 4;
                        float H = 360 * (float)offseted_j / (Height / 2); 
                        float S = 1 - (float)offseted_i / (Width / 2); 
                        float V = 1;

                        float Hp = H / 60;
                        float C = V * S;
                        float X = C * (1 - MathF.Abs(Hp % 2 - 1));
                        Color color;
                        float m = V - C;
                        if (Hp < 1)
                        {
                            color = Color.FromArgb((int)((C + m) * 255), (int)((X + m) * 255), (int)(m * 255));
                        }
                        else if (Hp < 2)
                        {
                            color = Color.FromArgb((int)((X + m) * 255), (int)((C + m) * 255), (int)(m * 255));
                        }
                        else if (Hp < 3)
                        {
                            color = Color.FromArgb((int)(m * 255), (int)((C + m) * 255), (int)((X + m) * 255));
                        }
                        else if (Hp < 4)
                        {
                            color = Color.FromArgb((int)(m * 255), (int)((X + m) * 255), (int)((C + m) * 255));
                        }
                        else if (Hp < 5)
                        {
                            color = Color.FromArgb((int)((X + m) * 255), (int)(m * 255), (int)((C + m) * 255));
                        }
                        else 
                        {
                            color = Color.FromArgb((int)((C + m) * 255), (int)(m * 255), (int)((X + m) * 255));
                        }
                        bitmap.SetPixel(i, j, color);
                    }
                    else
                    {
                        int col = mode2 ? 255 : 0;
                        bitmap.SetPixel(i, j, Color.FromArgb(col, col, col));
                    }
                    if ((j + 1) % BlockDim == 0)
                    {
                        mode2 = !mode2;
                    }
                }
                if ((i + 1) % BlockDim == 0)
                {
                    mode = !mode;
                }
            }
            return bitmap;
        }
    }
}
