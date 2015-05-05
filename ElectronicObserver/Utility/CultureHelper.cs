using System.Globalization;

namespace ElectronicObserver.Utility
{
    public static class CultureHelper
    {
        public static CultureInfo GetCultureInfo(int index)
        {
            switch(index)
            {
                default:
                case 0:
                    return CultureInfo.InstalledUICulture;
                case 1:
                    return new CultureInfo("ja");
                case 2:
                    return new CultureInfo("zh-Hans");

            }
        }
    }
}
