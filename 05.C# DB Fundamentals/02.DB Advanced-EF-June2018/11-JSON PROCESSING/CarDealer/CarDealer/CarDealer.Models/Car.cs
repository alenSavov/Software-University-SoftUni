using System;
using System.Collections.Generic;
using System.Linq;

namespace CarDealer.Models
{
    public class Car
    {
        public Car()
        {
            this.Parts = new List<PartCar>();
            this.Sales = new List<Sale>();
        }

        public int CarId { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public long TravelledDistance { get; set; }


        public decimal Price => this.Parts.Sum(x => x.Part.Price * x.Part.Quantity);


        public ICollection<PartCar> Parts { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}
