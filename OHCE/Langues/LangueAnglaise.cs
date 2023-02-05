namespace OHCE.Langues
{
    public class LangueAnglaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.English.BienDit;

        /// <inheritdoc />
        public string VotreMot => Expressions.English.VotreMot;

        /// <inheritdoc />
        public string Bonjour(PériodeJournée période)
        {
            if (période == PériodeJournée.Matin)
            {
                return Expressions.English.Bonjour;
            }
            else
            {
                return Expressions.English.Bonsoir;
            }

        }

        /// <inheritdoc />
        public string AuRevoir(PériodeJournée période)
        {
            if (période == PériodeJournée.Matin)
            {
                return Expressions.English.AuRevoir;
            }
            else
            {
                return Expressions.English.BonneSoiree;
            }
        }
    }
}
