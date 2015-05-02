using System.Collections;
using System.Globalization;

namespace ElectronicObserver.Utility
{
    public static class CultureHelper
    {
        public static CultureInfo GetCultureInfo(string index)
        {
            switch (index)
            {
                default:
                    return CultureInfo.InstalledUICulture;
                case "ja":
                    return new CultureInfo("ja");
                case "zh-Hans":
                    return new CultureInfo("zh-Hans");

            }
        }

        public static ArrayList LanguageItem
        {
            get {
                ArrayList Language = new ArrayList(3);
                Language.Add(new DictionaryEntry(LoadResources.getter("Language_auto"), "auto"));
                Language.Add(new DictionaryEntry(LoadResources.getter("Language_ja"), "ja"));
                Language.Add(new DictionaryEntry(LoadResources.getter("Language_zh-Hans"), "zh-Hans"));
                return Language;
            }
        } 


    }
}
