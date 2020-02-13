namespace TariffComparer.Models
{
    public class BuilderModel
    {
        public double BaseCost { get; set; }
        public double ConsumptionCost { get; set; }
        public int? frequency { get; set; }

        public BuilderModel(int baseCost, double consumptionCost, int? frequency)
        {
            this.BaseCost = baseCost;
            this.ConsumptionCost = consumptionCost;
            this.frequency = frequency;
        }
    }
}
