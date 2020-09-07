using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorTest
    {
        internal static void TestNumbertoPair(int pairNumber, Color expectedMajor, Color expectedminor)
        {
            ColorPair testPair = ColorMap.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair);
            Debug.Assert(testPair.MajorColor == expectedMajor);
            Debug.Assert(testPair.MinorColor == expectedminor);
        }

        internal static void TestPairtoNumber(Color major, Color minor, int expectedPairNumber)
        {
            ColorPair testPair2 = new ColorPair(major, minor);
            int pairNumber = ColorMap.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == expectedPairNumber);
        }
    }
}
