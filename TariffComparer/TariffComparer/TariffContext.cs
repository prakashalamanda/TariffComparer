using TariffComparer.Builder;

namespace TariffComparer
{
    public class TariffContext
    {
        private ITariffEngine _engine;
        private ITariffBuilder _builder;

        public void SetTariff(ITariffEngine engine, ITariffBuilder _builder)
        {
            this._engine = engine;
            this._builder = _builder;
        }

        public TariffModel RunEngine(int consumption)
        {
            var data = this._builder.ConstructRule();
            return this._engine.RunTariff(consumption, data);
        }
    }
}
