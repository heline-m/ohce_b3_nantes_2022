using System;
using System.Numerics;
using System.Text;

namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;
    private readonly PériodeJournée _périodeJournée;

    public Ohce()
    {
    }

    public string Palindrome(string input)
    {
        var stringBuilder = 
            new StringBuilder("Bonjour \n");

        var reversed = new string(
            input.Reverse().ToArray()
        );

        stringBuilder.Append("votre mot : \n " + reversed);

        if (reversed.Equals(input))
            stringBuilder.Append("\n Bien dit \n");

        stringBuilder.Append("\n Aurevoir");

        return stringBuilder.ToString();
    }

}