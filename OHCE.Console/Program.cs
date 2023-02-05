using OHCE;
using OHCE.Langues;

int choix = 0;
ILangue langue;
var choixPériode = 0;
PériodeJournée période;


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


while (choixPériode != 1 && choixPériode != 2)
{
    Console.WriteLine("1/ Matin - Morning \n" +
        "2/ Après-midi - Afternoon");
    choixPériode = Int32.Parse(Console.ReadLine());
}

if (choixPériode == 1)
{
    période = PériodeJournée.Matin;
}
else
{
    période = PériodeJournée.Soir;
}

var ohce = new Ohce(langue, période);

Console.WriteLine("Veuillez entrer un mot : \n" +
    "Please enter a word :");
String mot = Console.ReadLine();
Console.WriteLine(ohce.Palindrome(mot));
