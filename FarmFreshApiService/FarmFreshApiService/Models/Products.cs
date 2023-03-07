using FarmFreshApiService.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static FarmFreshApiService.Utils.Constants;

namespace FarmFreshApiService.Models
{
    [Table("Products")]
    public class Products : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public string Origin { get; set; }

        [JsonIgnore]
        public EntityState EntityState { get; set; }
    }
}
