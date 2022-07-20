using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterLevelData
{
    class EnglishLanguageText:LanguageText
    {
        public string SelectFile() { return "Select file to load"; }

        public string ReplaceFile() { return "Replace 'a' with '@' in selected cell"; }

        public string LabelId() { return "Selected Id"; }

        public string ShowId() { return "Show Selected Id"; }
    }
}
