using OHCE;

var ohce = new Ohce();

Console.WriteLine("Veuillez entrer un mot :");
String mot = Console.ReadLine();
Console.WriteLine(ohce.Palindrome(mot));
