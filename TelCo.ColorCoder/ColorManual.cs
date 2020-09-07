namespace TelCo.ColorCoder
{
    class ColorManual
    {
        internal static string GetColorCoding()
        {
            string color_mapping = "";
            for (int i = 0; i < ColorMap.NumberofMajorColors * ColorMap.NumberofMinorColors; i++)
            {
                ColorPair colorPair = ColorMap.GetColorFromPairNumber(i + 1);
                color_mapping = color_mapping + "\n" + (i+1) + " : " + colorPair.ToString();
            }
            return color_mapping;
        }
    }
}
