namespace OHCE.Langues
{
    public class LangueFrançaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string VotreMot => Expressions.Français.VotreMot;


        /// <inheritdoc />
        public string Bonjour(PériodeJournée période)
        {
            if (période == PériodeJournée.Matin)
            {
                return Expressions.Français.Bonjour;
            }
            else
            {
                return Expressions.Français.Bonsoir;
            }

        }

        /// <inheritdoc />
        public string AuRevoir(PériodeJournée période)
        {
            if (période == PériodeJournée.Matin)
            {
                return Expressions.Français.AuRevoir;
            }
            else
            {
                return Expressions.Français.BonneSoiree;
            }
        }
    }
}
