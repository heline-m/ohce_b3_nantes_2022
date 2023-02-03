using OHCE;
using OHCE.Langues;

int choix = 0;
ILangue langue;

while (choix!=1 && choix != 2)
{
    Console.WriteLine("Veuillez choisir votre langue : \n" +
        "Please choose your language : \n" +
        "1/ Français \n" +
        "2/ English");
    choix = Int32.Parse(Console.ReadLine());
}

if (choix == 1)
{
    langue = new LangueFrançaise();
} else
{
    langue = new LangueAnglaise();
}

var ohce = new Ohce(langue);

Console.WriteLine("Veuillez entrer un mot :");
String mot = Console.ReadLine();
Console.WriteLine(ohce.Palindrome(mot));
