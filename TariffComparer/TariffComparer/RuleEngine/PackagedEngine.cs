using TariffComparer.Models;

namespace TariffComparer
{
    public class PackagedEngine : ITariffEngine
    {
        public TariffModel RunTariff(int consumption, BuilderModel data)
        {
            var tariffModel = new TariffModel();
            tariffModel.TariffName = "Packaged electricity tariff";

            if (consumption <= 4000)
            {
                tariffModel.AnnualCost = 800; // Return 800 if the consumption is less than or equal to 4000
            } else
            {
                var differenceFromBaseCost = consumption - 4000;
                tariffModel.AnnualCost = data.BaseCost + (differenceFromBaseCost * data.ConsumptionCost); // Calculation logic for Packaged engine.
            }

            return tariffModel;
        }
    }
}
