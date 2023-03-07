using FarmFreshApiService.Interfaces;
using FarmFreshApiService.Models;
using System;


namespace FarmFreshApiService.Services
{
    public class ProductRepository : GenericDataRepository<Products>, IProductRepository
    {
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (!disposedValue)
            {
                if (disposing)
                {
                }

                disposedValue = true;
            }
        }

        ~ProductRepository()
        {
            Dispose(false);
        }

        public new void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
