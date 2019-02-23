using CarDealer.Data;
using CarDealer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace CarDealer.App
{
    public class ImportJsons
    {
        public static void SeedSuppliersJson()
        {
            using (var context = new CarDealerContext())
            {
                var jsonString = File.ReadAllText(@"C:\Users\alenSavov\Desktop\Softuni\DB Advanced-EF-June2018\11-JSON PROCESSING\CarDealer\CarDealer\CarDealer.App\Files\suppliers.json");
                var suppliersJson = JsonConvert.DeserializeObject<Supplier[]>(jsonString);

                List<Supplier> suppliersList = new List<Supplier>();

                foreach (var supplier in suppliersJson)
                {
                    if (!IsValid(supplier))
                    {
                        continue;
                    }

                    suppliersList.Add(supplier);
                }

                context.AddRange(suppliersList);
                context.SaveChanges();
            }
        }

        public static void SeedPartsJson()
        {
            using (var context = new CarDealerContext())
            {
                var jsonString = File.ReadAllText(@"C:\Users\alenSavov\Desktop\Softuni\DB Advanced-EF-June2018\11-JSON PROCESSING\CarDealer\CarDealer\CarDealer.App\Files\parts.json");
                var partsJson = JsonConvert.DeserializeObject<Part[]>(jsonString);

                List<Part> partsList = new List<Part>();

                foreach (var part in partsJson)
                {
                    if (!IsValid(part))
                    {
                        continue;
                    }

                    var supplierId = new Random().Next(1, 32);

                    var newPart = new Part
                    {
                        Id = part.Id,
                        Name = part.Name,
                        Price = part.Price,
                        Quantity = part.Quantity,
                        SupplierId = supplierId
                    };

                    partsList.Add(newPart);
                }

                context.AddRange(partsList);
                context.SaveChanges();
            }
        }

        public static void SeedCarsJson()
        {
            using (var context = new CarDealerContext())
            {
                var jsonString = File.ReadAllText(@"C:\Users\alenSavov\Desktop\Softuni\DB Advanced-EF-June2018\11-JSON PROCESSING\CarDealer\CarDealer\CarDealer.App\Files\cars.json");
                var carsJson = JsonConvert.DeserializeObject<Car[]>(jsonString);

                List<Car> carsList = new List<Car>();

                foreach (var car in carsJson)
                {
                    if (!IsValid(car))
                    {
                        continue;
                    }

                    carsList.Add(car);
                }

                context.AddRange(carsList);
                context.SaveChanges();
            }
        }

        public static void SeedPartCar()
        {
            using (var context = new CarDealerContext())
            {
                var partsCars = new List<PartCar>();


                List<Car> cars = new List<Car>();
                cars.AddRange(context.Cars);

                for (int carId = 1; carId <= cars.Count; carId++)
                {
                    var randomPartId = new Random().Next(1, 132);

                    var newPartCar = new PartCar
                    {
                        CarId = carId,
                        PartId = randomPartId
                    };

                    partsCars.Add(newPartCar);
                }

                context.PartCars.AddRange(partsCars);
                context.SaveChanges();
            }
        }

        public static void SeedCustomers()
        {
            using (var context = new CarDealerContext())
            {
                var jsonString = File.ReadAllText(@"C:\Users\alenSavov\Desktop\Softuni\DB Advanced-EF-June2018\11-JSON PROCESSING\CarDealer\CarDealer\CarDealer.App\Files\customers.json");
                var customersJson = JsonConvert.DeserializeObject<Customer[]>(jsonString);

                List<Customer> customersList = new List<Customer>();

                foreach (var customer in customersJson)
                {
                    if (!IsValid(customer))
                    {
                        continue;
                    }

                    customersList.Add(customer);
                }

                context.AddRange(customersList);
                context.SaveChanges();
            }
        }

        public static void SeedSaled()
        {
            using (var context = new CarDealerContext())
            {
                List<Sale> sales = new List<Sale>();

                var discounts = new List<int>
                {
                    0,
                    5,
                    10,
                    15,
                    20,
                    30,
                    40,
                    50
                };

                for (int carCount = 1; carCount <= 359; carCount++)
                {
                    var carId = new Random().Next(1, 359);
                    var customerId = new Random().Next(1, 60);

                    int discountRandom = new Random().Next(1, discounts.Count);

                    var sale = new Sale
                    {
                        CarId = carId,
                        CustomerId = customerId,
                        Discount = discounts[discountRandom]
                    };
                    
                    sales.Add(sale);

                }

                context.Sales.AddRange(sales);
                context.SaveChanges();

            }
        }

        public static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var result = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, result, true);
        }
    }
}
