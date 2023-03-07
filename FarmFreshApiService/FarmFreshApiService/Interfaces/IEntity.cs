using static FarmFreshApiService.Utils.Constants;

namespace FarmFreshApiService.Interfaces
{

    public interface IEntity
    {
        EntityState EntityState { get; set; }
    }
}
