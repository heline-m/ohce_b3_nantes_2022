using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHCE.Console.Adapters
{
    internal class SystemTimePériodeJournéeAdapter
    {
        public static PériodeJournée PériodeActuelle
           => DateTime.Now.Hour switch
           {
               < 12 => PériodeJournée.Matin,
               < 18 => PériodeJournée.Soir
           };
    }
}
