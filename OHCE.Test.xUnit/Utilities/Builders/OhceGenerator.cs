namespace OHCE.Test.xUnit.Utilities.Builders
{
    internal class OhceGenerator
    {
        private OhceBuilder _builder = new OhceBuilder();

        public IEnumerable<Ohce> Generate(int limit)
        {
            for (var i = 0; i < limit; i++)
            {
                yield return _builder.Build();
            }
        }

        public OhceGenerator AyantPourPrototype(Func<OhceBuilder, OhceBuilder> configuration)
        {
            _builder = configuration(_builder);
            return this;
        }
    }
}
