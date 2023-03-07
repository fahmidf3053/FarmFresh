using Microsoft.AspNetCore.Mvc;
using FarmFreshApiService.Interfaces;
using FarmFreshApiService.Managers;
using FarmFreshApiService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FarmFreshApiService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GatewayController : ControllerBase
    {
        private readonly ProductManager _productManager;

        public GatewayController(IDataAccessService dataAccessService)
        {
            _productManager = new ProductManager(dataAccessService);
        }

        [HttpGet("/GetAllProducts", Name = "GetAllProducts")]
        public IActionResult GetAllProducts(int pageSize, int pageNumber)
        {
            try
            {
                List<Products> products = new();

                products = _productManager.GetAllProducts(pageSize, pageNumber);

                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("/GetProductByName", Name = "GetProductByName")]
        public IActionResult GetProductByName([Required] string name, int pageSize, int pageNumber)
        {
            try
            {
                List<Products> products = _productManager.GetProductByName(name, pageSize, pageNumber);

                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
