namespace OHCE.Langues
{
    public class LangueFrançaise : ILangue
    {
        /// <inheritdoc />
        public string BienDit => Expressions.Français.BienDit;

        /// <inheritdoc />
        public string VotreMot => Expressions.Français.VotreMot;


        /// <inheritdoc />
        public string Bonjour => Expressions.Français.Bonjour;
      

        /// <inheritdoc />
        public string AuRevoir => Expressions.Français.AuRevoir;
    }
}
