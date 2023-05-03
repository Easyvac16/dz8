using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8
{
    struct RGBColor
    {
        public int Red;
        public int Green;
        public int Blue;

        
        public RGBColor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        // Метод для перетворення кольору в HEX формат
        public string ToHex()
        {
            return $"#{Red:X2}{Green:X2}{Blue:X2}";
        }

        // Метод для перетворення кольору в HSL формат
        public (double Hue, double Saturation, double Lightness) ToHSL()
        {
            double r = Red / 255.0;
            double g = Green / 255.0;
            double b = Blue / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            double hue = 0.0;
            double saturation = 0.0;
            double lightness = (max + min) / 2.0;

            if (max != min)
            {
                double delta = max - min;

                saturation = lightness > 0.5 ? delta / (2.0 - max - min) : delta / (max + min);

                if (max == r)
                {
                    hue = (g - b) / delta + (g < b ? 6.0 : 0.0);
                }
                else if (max == g)
                {
                    hue = (b - r) / delta + 2.0;
                }
                else if (max == b)
                {
                    hue = (r - g) / delta + 4.0;
                }
            }

            hue = hue / 6.0 * 360.0;

            return (hue, saturation, lightness);
        }

        // Метод для перетворення кольору в CMYK формат
        public (double Cyan, double Magenta, double Yellow, double Key) ToCMYK()
        {
            double r = Red / 255.0;
            double g = Green / 255.0;
            double b = Blue / 255.0;

            double k = 1.0 - Math.Max(r, Math.Max(g, b));
            double c = (1.0 - r - k) / (1.0 - k);
            double m = (1.0 - g - k) / (1.0 - k);
            double y = (1.0 - b - k) / (1.0 - k);

            return (c, m, y, k);
        }
    }
    internal class cs3
    {
        public static void task_3()
        {
            RGBColor rgb = new RGBColor(255, 165, 0);

            // Виводимо HEX формат кольору
            Console.WriteLine("RGB to HEX: " + rgb.ToHex());

            // Виводимо HSL формат кольору
            var hsl = rgb.ToHSL();
            Console.WriteLine($"RGB to HSL: H={hsl.Hue:F2} S={hsl.Saturation:F2} L={hsl.Lightness:F2}");

            // Виводимо CMYK формат кольору
            var cmyk = rgb.ToCMYK();
            Console.WriteLine($"RGB to CMYK: C={cmyk.Cyan:F2} M={cmyk.Magenta:F2} Y={cmyk.Yellow:F2} K={cmyk.Key:F2}");

            
        }
    }
}
