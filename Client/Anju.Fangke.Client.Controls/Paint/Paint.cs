using MetroFramework.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public class Paint : MetroPaint
    {
        public static Color ChangeColor(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            if (red < 0) red = 0;

            if (red > 255) red = 255;

            if (green < 0) green = 0;

            if (green > 255) green = 255;

            if (blue < 0) blue = 0;

            if (blue > 255) blue = 255;

            return Color.FromArgb(color.A, (int)red, (int)green, (int)blue);
        }

        public static Color Fade(Color color)
        {
            return ChangeColor(color, 0.5f);
        }

        public static Color Darker(Color color)
        {
            return ChangeColor(color, -0.5f);
        }
    }
}
