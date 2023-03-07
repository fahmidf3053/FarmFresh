using System;
using System.Data;
using System.Linq;
using FarmFreshApiService.Interfaces;
using FarmFreshApiService.Models;

namespace FarmFreshApiService.Services
{
    public class DataAccessService : IDataAccessService, IDisposable
    {
        private readonly IProductRepository _productRepository;
        

        public DataAccessService()
        {
            _productRepository = new ProductRepository();
        }


        public IQueryable<Products> GetAllProducts() {
            return _productRepository.GetAll();
        }
        
        public IQueryable<Products> GetAllProducts(int pageSize, int pageNumber) {
            return _productRepository.GetAll().Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        public Products GetProductById(int id) {
            return _productRepository.GetAll().Where(x => x.Id == id).FirstOrDefault();
        }

        public void UpdateProducts(params Products[] products) {
            _productRepository.Update(products);
        }

        public void AddProducts(params Products[] products)
        {
            _productRepository.Add(products);
        }

        public void DeleteProducts(params Products[] products)
        {
            _productRepository.Remove(products);
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _productRepository.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
