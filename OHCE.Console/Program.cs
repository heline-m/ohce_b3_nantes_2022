using OHCE;
using OHCE.Console.Adapters;

var ohce = new Ohce(SystemLangueAdapter.LangueActuelle, SystemTimePériodeJournéeAdapter.PériodeActuelle);

Console.WriteLine("Veuillez entrer un mot : \n" +
    "Please enter a word :");
String mot = Console.ReadLine();
Console.WriteLine(ohce.Palindrome(mot));
