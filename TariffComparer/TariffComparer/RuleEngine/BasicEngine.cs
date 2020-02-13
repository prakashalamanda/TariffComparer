using TariffComparer.Models;

namespace TariffComparer
{
    public class BasicEngine : ITariffEngine
    {
        public TariffModel RunTariff(int consumption, BuilderModel data)
        {
            var tariffModel = new TariffModel();
            var basicCost = data.BaseCost * data.frequency.GetValueOrDefault(); // To calculate the basic cost yearly.
            tariffModel.AnnualCost = basicCost + (consumption * data.ConsumptionCost); // Calculation logic for Basic engine.
            tariffModel.TariffName = "Basic electricity tariff";

            return tariffModel;
        }
    }
}
