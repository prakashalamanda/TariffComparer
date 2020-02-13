using TariffComparer.Models;

namespace TariffComparer.Builder
{
    public class BasicBuilder : ITariffBuilder
    {
        public BuilderModel ConstructRule()
        {
            return new BuilderModel(5, .22, 12); // Base cost, Consumption cost and Frequency
        }
    }
}
