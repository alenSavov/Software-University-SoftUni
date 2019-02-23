using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.Models
{
    public class Product
    {
        public Product()
        {
            this.Categories = new HashSet<CategoryProduct>();
        }

        public int Id { get; set; }
        
        public string Name { get; set; }        
        
        public decimal Price { get; set; }
        
        public int? BuyerId { get; set; }
        public User Buyer { get; set; }
        
        public int SellerId { get; set; }
        public User Seller { get; set; }

        public ICollection<CategoryProduct> Categories { get; set; }
    }
}
