using System;
using System.Collections.Generic;
using System.Linq;
using TariffComparer.Builder;

namespace TariffComparer
{
    public class Program
    {
        static void Main(string[] args)
        {
            int consumptionInput;
            Console.Write("Enter the consumption in (kWh/year): ");
            string readLine = Console.ReadLine();

            while (!int.TryParse(readLine, out consumptionInput))
            {
                Console.WriteLine("Not a valid consumption value, try again.");
                Console.Write("Enter the consumption in (kWh/year): ");
                readLine = Console.ReadLine();
            }

            // Creates builder class for getting the static values for calculation
            // Calls Rule engine for both Basic and Packaged to perform the calculation
            var results = new List<TariffModel>();
            results.Add(RunEngine(consumptionInput, new BasicEngine(), new BasicBuilder()));
            results.Add(RunEngine(consumptionInput, new PackagedEngine(), new PackagedBuilder()));

            // To sort and iterate each result.
            results.OrderBy(result => result.AnnualCost).ToList().ForEach(result =>
            {
                Console.WriteLine("Tariff Name: " + result.TariffName);
                Console.WriteLine("Annual cost: " + result.AnnualCost);
            });

            Console.ReadLine();
        }

        public static TariffModel RunEngine(int input, ITariffEngine engine, ITariffBuilder builder)
        {
            var context = new TariffContext();
            context.SetTariff(engine, builder);
            return context.RunEngine(input);
        }
    }
}
