using OHCE;
using OHCE.Console.Adapters;

var ohce = new Ohce(SystemLangueAdapter.LangueActuelle, SystemTimePériodeJournéeAdapter.PériodeActuelle);

Console.WriteLine(ohce.Saluer());

Console.WriteLine(ohce.Palindrome("laval"));

Console.WriteLine(ohce.DireAurevoir());