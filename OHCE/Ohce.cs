using System;
using System.Numerics;
using System.Text;

namespace OHCE;

public class Ohce
{
    private readonly ILangue _langue;
    private readonly PériodeJournée _périodeJournée;

    public Ohce(ILangue langue)
    {
        _langue = langue;
    }

    public string Palindrome(string input)
    {
        var stringBuilder =
            new StringBuilder(Bonjour() + "\n"); ;

        var reversed = new string(
            input.Reverse().ToArray()
        );

        stringBuilder.Append(VotreMot() +"\n " + reversed);

        if (reversed.Equals(input))
            stringBuilder.Append("\n" + Biendit());

        stringBuilder.Append("\n" + Aurevoir());

        return stringBuilder.ToString();
    }

    public string Bonjour()
    {
        return _langue.Bonjour;
    }

    public string Biendit()
    {
        return _langue.BienDit;
    }

    public string VotreMot()
    {
        return _langue.VotreMot;
    }

    public string Aurevoir()
    {
        return _langue.AuRevoir;
    }

}