using FarmFreshApiService.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static FarmFreshApiService.Utils.Constants;
namespace FarmFreshApiService.DTOs
{
    public class ProductsDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string Origin { get; set; }

    }
}
