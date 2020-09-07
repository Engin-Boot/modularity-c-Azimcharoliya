using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class IndexHelper
    {
        internal static int getColorIndex(Color color,Color[] colorMap)
        {
            int index = -1;
            for (int i = 0; i < colorMap.Length; i++)
            {
                if (colorMap[i] == color)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
