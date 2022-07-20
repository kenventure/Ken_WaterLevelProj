using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterLevelData
{
    class FrenchLanguageText:LanguageText
    {
        public string SelectFile() { return "Sélectionnez le fichier à charger"; }

        public string ReplaceFile() { return "Remplacer 'a' par '@' dans la cellule sélectionnée"; }

        public string LabelId() { return "Identifiant sélectionné"; }

        public string ShowId() { return "Afficher l'identifiant sélectionné"; }
    }
}
