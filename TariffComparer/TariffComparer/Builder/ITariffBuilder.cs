using TariffComparer.Models;

namespace TariffComparer.Builder
{
    public interface ITariffBuilder        
    {
        BuilderModel ConstructRule();
    }
}
