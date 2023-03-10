using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product : BaseEntity
    {
        //public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set;}
        public decimal Price { get; set; }
        public string? PictureUrl { get; set; }
        public string? Ingredients { get; set; }
        public ProductCategorie ProductCategorie { get; set; }
        public int ProductCategorieId { get; set; }

        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }



    }
}