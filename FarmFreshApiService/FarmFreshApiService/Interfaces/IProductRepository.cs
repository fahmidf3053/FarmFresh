using FarmFreshApiService.Models;
using System;

namespace FarmFreshApiService.Interfaces
{
    public interface IProductRepository : IGenericDataRepository<Products>, IDisposable
    {

    }
}
