namespace OHCE
{
    public interface ILangue
    {
        string BienDit { get; }
        string VotreMot { get; }
        string Bonjour(PériodeJournée période);
        string AuRevoir(PériodeJournée période);
    }
}
