using FarmFreshApiService.Models;
using System.Collections.Generic;
using System.Linq;

namespace FarmFreshApiService.Interfaces
{
    public interface IDataAccessService
    {
        IQueryable<Products> GetAllProducts();
        IQueryable<Products> GetAllProducts(int pageSize = int.MaxValue, int pageNumber = int.MaxValue);
        Products GetProductById(int userId);
        void UpdateProducts(params Products[] products);
        void AddProducts(params Products[] products);
        void DeleteProducts(params Products[] products);

    }
}