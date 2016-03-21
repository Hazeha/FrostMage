using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassTemplate.Data
{
    internal static class Statics
    {
        internal static volatile float CombatDistance = 30f;
        internal static volatile string SettingsName = "BokutoxMageSettings";
        
        // Healing Potions
        public static string[] HealingPotions =
        {
            "Weak Troll's Blood Potion", "Strong Troll's Blood Potion",
            "Mighty Troll's Blood Potion"
        };
        
        // Wizzard Oils
        public static string[] WizardOil =
            {
            "Minor Wizard Oil", "Lesser Wizard Oil", "Wizard Oil", "Brilliant Wizard Oil",
            "Blessed Wizard Oil", "Superior Wizard Oil"
        };
    }
}

