using CarDealer.Data;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace CarDealer.App
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //using (var db = new CarDealerContext())
            //{
            //    db.Database.EnsureDeleted();
            //    db.Database.EnsureCreated();
            //}


            //Jsons.SeedSuppliersJson();
            //Jsons.SeedPartsJson();
            //Jsons.SeedCarsJson();
            //Jsons.AddPartInCars();
            //Jsons.SeedCustomers();
            //ImportJsons.SeedSaled();

            using (var context = new CarDealerContext())
            {
               var cars = context.Cars
                       .Where(x => x.Make == "Toyota")
                       .OrderBy(x => x.Model)
                       .ThenByDescending(x => x.TravelledDistance)
                       .Select(x => new
                       {
                           Id = x.CarId,
                           Make = x.Make,
                           Model = x.Model,
                           TravelledDistance = x.TravelledDistance
                       }).ToArray();

                var jsonCars = JsonConvert.SerializeObject(cars, Formatting.Indented);

                File.WriteAllText("../../../Jsons/toyota-cars.json", jsonCars);
            }

            using (var context = new CarDealerContext())
            {
                var suppliers = context.Suppliers
                                       .Where(x => x.IsImporter == false)
                                       .Select(x => new
                                       {
                                           Id = x.SupplierId,
                                           Name = x.Name,
                                           PartsCount = x.Parts.Count()
                                       });

                var jsonSuppliers = JsonConvert.SerializeObject(suppliers, Formatting.Indented);

                File.WriteAllText("../../../Jsons/local-suppliers.json", jsonSuppliers);
            }

            using (var context = new CarDealerContext())
            {
                var cars = context.Cars
                                  .Select(x => new
                                  {
                                      Car = x.CarId,
                                      Make = x.Make,
                                      Model = x.Model,
                                      TravelledDistance = x.TravelledDistance,
                                      parts = x.Parts
                                               .Select(c => new
                                               {
                                                   Name = c.Part.Name,
                                                   Price = c.Part.Price
                                               }).ToArray()
                                  }).ToArray();

                var jsonCars = JsonConvert.SerializeObject(cars, Formatting.Indented);

                File.WriteAllText("../../../Jsons/cars-and-parts.json", jsonCars);
            }

            using (var context = new CarDealerContext())
            {
                var customers = context.Customers
                                       .Where(x => x.Sales.Count > 1)
                                       .Select(x => new
                                       {
                                           fullName = x.Name,
                                           boughtCars = x.Sales.Count,
                                           spendMoney = x.Sales.Select(t => t.Car).Sum(p => p.Price)
                                       });

                var jsonCustomer = JsonConvert.SerializeObject(customers, Formatting.Indented);

                File.WriteAllText("../../../Jsons/customers-total-sales.json", jsonCustomer);
            }
        }
    }
}
