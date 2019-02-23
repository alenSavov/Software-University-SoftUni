using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class User
    {
        public User()
        {
            this.ProductSold = new HashSet<Product>();
            this.ProductBought = new HashSet<Product>();
        }

        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public int Age { get; set; }

        public ICollection<Product> ProductSold { get; set; }

        public ICollection<Product> ProductBought { get; set; }
    }
}
