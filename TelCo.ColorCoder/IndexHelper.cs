using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class IndexHelper
    {
        internal static int getMajorIndex(ColorPair pair,Color[] colorMapMajor)
        {
            int majorIndex = -1;
            for (int i = 0; i < colorMapMajor.Length; i++)
            {
                if (colorMapMajor[i] == pair.MajorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            return majorIndex;
        }

        internal static int getMinorIndex(ColorPair pair, Color[] colorMapMinor)
        {
            int minorIndex = -1;
            for (int i = 0; i < colorMapMinor.Length; i++)
            {
                if (colorMapMinor[i] == pair.MinorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            return minorIndex;
        }

    }
}
