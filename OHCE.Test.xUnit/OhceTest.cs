using OHCE.Langues;
using OHCE.Test.xUnit.Utilities;
using OHCE.Test.xUnit.Utilities.Builders;
using System;

namespace OHCE.Test.xUnit;

public class OhceTest
{

    private static readonly IEnumerable<ILangue> Langues = new ILangue[]
   {
        new LangueAnglaise(),
        new LangueFrançaise()
   };

    public static IEnumerable<object[]> LanguesSeules => new CartesianData(Langues);

    [Theory(DisplayName =
        "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND on saisit un palindrome " +
        "ALORS celui-ci est renvoyé " +
        "ET le « Bien dit » de cette langue est envoyé ensuite")]
    [MemberData(nameof(LanguesSeules))]
    public void PalindromeTest(ILangue langue)
    {
        //ETANT DONNE un utilisateur parlant une langue
        var ohce = new OhceBuilder().AyantPourLangue(langue).Build();

        //QUAND on saisit un palindrome 
        var sortie = ohce.Palindrome("erdre");

        //ALORS celui-ci est renvoyé 
        // ET le « Bien dit » de cette langue est envoyé ensuite
        Assert.Contains(langue.VotreMot + "\n erdre\n" + langue.BienDit, sortie);
    }

    [Theory(DisplayName =
        "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND on saisit une chaîne " +
        "ALORS le « Bonjour » de cette langue est envoyé avant toute réponse")]
    [MemberData(nameof(LanguesSeules))]
    public void Bonjour(ILangue langue)
    {
        //ETANT DONNE un utilisateur parlant une langue
        var ohce = new OhceBuilder().AyantPourLangue(langue).Build();

        //QUAND on saisit une chaîne
        var sortie = ohce.Palindrome("erdre");

        //ALORS le « Bonjour » de cette langue est envoyé avant toute réponse
        Assert.StartsWith(langue.Bonjour, sortie);
    }

    [Theory(DisplayName =
        "ETANT DONNE un utilisateur parlant une langue" +
        "QUAND on saisit une chaîne " +
        "ALORS le « Au revoir » de cette langue est envoyé en dernier")]
    [MemberData(nameof(LanguesSeules))]
    public void Aurevoir(ILangue langue)
    {
        //ETANT DONNE un utilisateur parlant une langue
        var ohce = new OhceBuilder().AyantPourLangue(langue).Build();

        //QUAND on saisit une chaîne
        var sortie = ohce.Palindrome("erdre");

        //"ALORS le « Au revoir » de cette langue est envoyé en dernier
        Assert.EndsWith(langue.AuRevoir, sortie);
    }





}