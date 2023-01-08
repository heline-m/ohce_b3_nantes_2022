using OHCE.Langues;
using System.Globalization;

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
