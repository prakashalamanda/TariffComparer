using TariffComparer.Models;

namespace TariffComparer
{
    public interface ITariffEngine
    {
        TariffModel RunTariff(int consumption, BuilderModel data);
    }
}
