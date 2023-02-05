using OHCE.Langues;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Console.Adapters
{
    internal class SystemLangueAdapter
    {
        public static ILangue LangueActuelle
            => CultureInfo.InstalledUICulture.TwoLetterISOLanguageName switch
            {
                "fr" => new LangueFrançaise(),
                "en" => new LangueAnglaise(),
            };
    }
}
