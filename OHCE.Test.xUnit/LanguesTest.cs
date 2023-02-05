using OHCE.Langues;

namespace OHCE.Test.xUnit
{
    public class LanguesTest
    {
        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
        "ET que la période de la journée est <période>" +
        "QUAND l'app démarre " +
        "ALORS <bonjour> de cette langue à cette période est envoyé")]
        [InlineData(PériodeJournée.Matin, Expressions.Français.Bonjour)]
        [InlineData(PériodeJournée.Soir, Expressions.Français.Bonsoir)]
        public void DireBonjourTest(PériodeJournée période, string salutationAttendue)
        {
            //ETANT DONNE un utilisateur parlant une langue
            var langue = new LangueFrançaise();

            //ET que la période de la journée est <période>
            //QUAND l'app démarre
            var salutation = langue.Bonjour(période);

            //ALORS <bonjour> de cette langue à cette période est envoyé
            Assert.Equal(salutationAttendue, salutation);
        }

        [Theory(DisplayName = "ETANT DONNE un utilisateur parlant une langue" +
        "ET que la période de la journée est <période>" +
        "QUAND l'app s'arrête " +
        "ALORS <bonjour> de cette langue à cette période est envoyé")]
        [InlineData(PériodeJournée.Matin, Expressions.Français.AuRevoir)]
        [InlineData(PériodeJournée.Soir, Expressions.Français.BonneSoiree)]
        public void AuRevoirTest(PériodeJournée periode, string salutationAttendue)
        {
            //ETANT DONNE un utilisateur parlant une langue
            var langue = new LangueFrançaise();

            //ET que la période de la journée est <période>
            //QUAND l'app s'arrête
            var auRevoir = langue.AuRevoir(periode);

            //ALORS <bonjour> de cette langue à cette période est envoyé
            Assert.Equal(salutationAttendue, auRevoir);
        }
    }
}
