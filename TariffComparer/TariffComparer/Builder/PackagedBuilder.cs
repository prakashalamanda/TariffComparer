using TariffComparer.Models;

namespace TariffComparer.Builder
{
    public class PackagedBuilder : ITariffBuilder
    {
        public BuilderModel ConstructRule()
        {
            return new BuilderModel(800, .30, null); // Base cost, Consumption cost and Frequency is not required here
        }
    }
}
