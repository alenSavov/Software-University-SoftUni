﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Models
{
   public class Customer
    {
        public Customer()
        {
            this.Sales = new List<Sale>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? BirtDate { get; set; }

        public bool IsYoungDriver { get; set; }


        public ICollection<Sale> Sales { get; set; }
    }
}
