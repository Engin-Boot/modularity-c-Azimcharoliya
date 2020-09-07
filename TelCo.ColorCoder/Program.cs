using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class Program
    {
        private static void Main(string[] args)
        {
            ColorTest.TestNumbertoPair(4,Color.White,Color.Brown);
            ColorTest.TestNumbertoPair(5, Color.White, Color.SlateGray);
            ColorTest.TestNumbertoPair(23, Color.Violet, Color.Green);

            ColorTest.TestPairtoNumber(Color.Yellow, Color.Green, 18);
            ColorTest.TestPairtoNumber(Color.Red, Color.Blue, 6);

            string colorCodingManual = ColorManual.GetColorCoding();
            Console.WriteLine("Color Coding Manual: ");
            Console.WriteLine(colorCodingManual);
        }
    }
}
