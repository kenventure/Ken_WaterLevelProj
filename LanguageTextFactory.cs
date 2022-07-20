using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterLevelData
{
    class LanguageTextFactory
    {

        public static LanguageText GetLanguageText (string lang)
        {
            switch (lang)
            {
                case "English":
                    return new EnglishLanguageText();

                case "French":
                    return new FrenchLanguageText();
                    
            }
            return null;
        }
    }
}
