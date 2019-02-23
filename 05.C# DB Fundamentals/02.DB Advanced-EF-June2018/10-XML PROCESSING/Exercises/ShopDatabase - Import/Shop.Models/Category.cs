using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<CategoryProduct>();
        }

        public int Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<CategoryProduct> Products { get; set; }
    }
}
