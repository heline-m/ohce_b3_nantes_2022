using System.Text;

namespace OHCE;

public class Ohce
{

    private readonly ILangue _langue;
    private readonly PériodeJournée _périodeJournée;

    public Ohce(ILangue langue, PériodeJournée périodeJournée)
    {
        _langue = langue;
        _périodeJournée = périodeJournée;
    }

    public string Palindrome(string input)
    {
        var reversed = new string(
            input.Reverse().ToArray()
        );

        var stringBuilder =
            new StringBuilder(reversed + "\n");

        if (reversed.Equals(input))
            stringBuilder.Append(_langue.BienDit);

        return stringBuilder.ToString();
    }

    public string Saluer()
    {
        var stringBuilder =
            new StringBuilder(_langue.DireBonjour(_périodeJournée));

        return stringBuilder.ToString();
    }

    public string DireAurevoir()
    {
        var stringBuilder =
            new StringBuilder(_langue.AuRevoir);

        return stringBuilder.ToString();
    }
}