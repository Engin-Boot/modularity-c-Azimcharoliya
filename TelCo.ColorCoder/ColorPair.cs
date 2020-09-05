using System;
using System.Drawing;

namespace TelCo.ColorCoder
{
    internal class ColorPair
    {
        private Color majorColor;
        private Color minorColor;
        internal Color MajorColor
        {
            get { return this.majorColor; }
        }

        internal Color MinorColor
        {
            get { return this.minorColor;  }
        }

        internal ColorPair(Color majorColor,Color minorColor)
        {
            this.majorColor = majorColor;
            this.minorColor = minorColor;
        }

        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }

    }
}
