namespace OHCE.Test.xUnit.Utilities.TestDoubles
{
    internal record LangueMock : ILangue
    {
        public string BienDit { get; init; } = string.Empty;

        public string VotreMot { get; init; } = string.Empty;

        public string Bonjour(PériodeJournée période) => string.Empty; 

        public string AuRevoir(PériodeJournée période) => string.Empty;
    }
}
