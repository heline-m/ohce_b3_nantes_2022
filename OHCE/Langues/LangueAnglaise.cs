namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.English.BienDit;

        /// <inheritdoc />
        public string VotreMot => Expressions.English.VotreMot;

        /// <inheritdoc />
        public string Bonjour => Expressions.English.Bonjour;

        /// <inheritdoc />
        public string AuRevoir => Expressions.English.AuRevoir;
    }
}
