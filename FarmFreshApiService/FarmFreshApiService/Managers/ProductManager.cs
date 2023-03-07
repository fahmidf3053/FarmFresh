using FarmFreshApiService.DTOs;
using FarmFreshApiService.Interfaces;
using FarmFreshApiService.Models;
using FarmFreshApiService.Services;
using FarmFreshApiService.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;


namespace FarmFreshApiService.Managers
{
    public class ProductManager
    {
        private readonly IDataAccessService _dataAccessService;

        public ProductManager(IDataAccessService dataAccessService)
        {
            _dataAccessService = dataAccessService;
        }

        #region Public Methods

        public List<Products> GetAllProducts(int pageSize, int pageNumber)
        {
            try
            {
                List<Products> products = new();

                if (pageSize == 0 && pageNumber == 0)
                {
                    products = _dataAccessService.GetAllProducts().ToList();
                }
                else
                {
                    products = _dataAccessService.GetAllProducts(pageSize, pageNumber).ToList();
                } 
                
                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Products> GetProductByName(string name, int pageSize, int pageNumber)
        {
            try
            {
                List<Products> products = _dataAccessService.GetAllProducts().ToList();

                products = products.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();

                if (!(pageSize == 0 && pageNumber == 0))
                {
                    products = products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
                }

                return products;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
     

        #endregion Public Methods

    }
}
