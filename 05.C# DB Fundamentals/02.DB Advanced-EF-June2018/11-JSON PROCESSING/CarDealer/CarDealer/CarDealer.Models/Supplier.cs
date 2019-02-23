﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarDealer.Models
{
   public class Supplier
    {
        public Supplier()
        {
            this.Parts = new List<Part>();
        }

        public int SupplierId { get; set; }

        public string Name { get; set; }

        public bool IsImporter { get; set; }

        public ICollection<Part> Parts { get; set; }
    }
}
