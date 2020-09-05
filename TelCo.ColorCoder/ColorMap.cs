using System;
using System.Drawing;
namespace TelCo.ColorCoder
{
    class ColorMap
    {
        private static Color[] colorMapMajor;
        private static Color[] colorMapMinor;
        static ColorMap()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
        internal static int NumberofMajorColors
        {
            get { return colorMapMajor.Length; }
        }
        internal static int NumberofMinorColors
        {
            get { return colorMapMinor.Length; }
        }

        internal static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = colorMapMinor.Length;
            int majorSize = colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
            ColorPair pair = new ColorPair(colorMapMajor[majorIndex], colorMapMinor[minorIndex]);
            return pair;
        }
        internal static int GetPairNumberFromColor(ColorPair pair)
        {
            int majorIndex = IndexHelper.getMajorIndex(pair, colorMapMajor);
            int minorIndex = IndexHelper.getMinorIndex(pair, colorMapMinor);
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
