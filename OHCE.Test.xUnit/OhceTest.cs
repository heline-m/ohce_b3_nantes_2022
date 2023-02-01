using OHCE.Langues;
using OHCE.Test.xUnit.Utilities;
using OHCE.Test.xUnit.Utilities.Builders;

namespace OHCE.Test.xUnit;

public class OhceTest
{
    [Fact(DisplayName = 
        "QUAND on entre une chaîne de caractères " +
        "ALORS elle est renvoyée en miroir")]
    public void MiroirTest()
    {
        var ohce = OhceBuilder.Default;

        // QUAND on entre une chaîne de caractère
        var sortie = ohce.Palindrome("toto");

        // ALORS elle est renvoyée en miroir
        Assert.Contains("otot", sortie);
    }

    [Fact(DisplayName =
        "QUAND on saisit un palindrome " +
        "ALORS celui-ci est renvoyé " +
        "ET « Bien dit » est envoyé ensuite")]
    public void Biendit()
    {
        var ohce = OhceBuilder.Default;

        //QUAND on saisit un palindrome 
        var sortie = ohce.Palindrome("erdre");

        //ALORS celui-ci est renvoyé 
        Assert.Contains("erdre", sortie);

        //ET « Bien dit » est envoyé ensuite
        Assert.Contains("Bien dit", sortie);
    }

    [Fact(DisplayName =
        "QUAND on saisit une chaîne " +
        "ALORS « Bonjour » est envoyé avant toute réponse")]
    public void Bonjour()
    {
        var ohce = OhceBuilder.Default;

        //QUAND on saisit une chaîne
        var sortie = ohce.Palindrome("erdre");

        //ALORS « Bonjour » est envoyé avant toute réponse
        Assert.Contains("Bonjour", sortie);
    }

    [Fact(DisplayName =
        "QUAND on saisit une chaîne " +
        "ALORS « Au revoir » est envoyé en dernier")]
    public void Aurevoir()
    {
        var ohce = OhceBuilder.Default;

        //QUAND on saisit une chaîne
        var sortie = ohce.Palindrome("erdre");

        //ALORS « Bonjour » est envoyé avant toute réponse
        Assert.Contains("Aurevoir", sortie);
    }





}