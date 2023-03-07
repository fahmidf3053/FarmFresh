using Microsoft.AspNetCore.Mvc;
using FarmFreshApiService.Interfaces;
using FarmFreshApiService.Managers;
using FarmFreshApiService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FarmFreshApiService.Authentication.Models;
using Microsoft.AspNetCore.Authorization;
using FarmFreshApiService.Authentication.Repository;

namespace FarmFreshApiService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GatewayController : ControllerBase
    {
        private readonly ProductManager _productManager;
        private readonly IJWTManagerRepository _jWTManager;

        public GatewayController(IDataAccessService dataAccessService, IJWTManagerRepository jWTManager)
        {
            _productManager = new ProductManager(dataAccessService);
            _jWTManager = jWTManager;
        }


        [AllowAnonymous]
        [HttpPost("/Authenticate", Name = "Authenticate")]
        public IActionResult Authenticate([Required] Users user)
        {
            var token = _jWTManager.Authenticate(user);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }

        [Authorize]
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

        [Authorize]
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
