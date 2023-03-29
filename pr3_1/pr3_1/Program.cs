using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr3_1
{
    class Color
    {
        private int red;
        private int green;
        private int blue;

        public int Red
        {
            get { return red; }
            set { Red = NormalizeColorValue(value); }
        }

        public int Green
        {
            get { return green; }
            set { Green = NormalizeColorValue(value); }
        }
        public int Blue
        {
            get { return blue; }
            set { Blue = NormalizeColorValue(value); }
        }
        public void DisplayColor()
        {
            Console.WriteLine($"{red}, {green}, {blue}");
        }

        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;

        }

        public Color() { }

        private int NormalizeColorValue( int colorValue )
        {
            if ( colorValue > 255 ) {
                return 255;
            }
            if (colorValue < 0)
            {
                return 0;
            }
            return colorValue;
        }

        static void Main()
        {
            Color yellow = new Color( 300, 300, 0);
            yellow.DisplayColor();

            Color pink = new Color();

            pink.Red = 255;
            pink.Green = -20;
            pink.Blue =147;
            pink.DisplayColor();

            Console.ReadKey(true);
        }

    }
}
