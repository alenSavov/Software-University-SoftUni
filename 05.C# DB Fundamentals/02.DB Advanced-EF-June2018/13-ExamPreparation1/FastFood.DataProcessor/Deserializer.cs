using FastFood.Data;
using FastFood.DataProcessor.Dto.Import;
using FastFood.Models;
using FastFood.Models.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FastFood.DataProcessor
{
    public static class Deserializer
    {
        private const string FailureMessage = "Invalid data format.";
        private const string SuccessMessage = "Record {0} successfully imported.";

        public static string ImportEmployees(FastFoodDbContext context, string jsonString)
        {
            var deserializedEmployees = JsonConvert.DeserializeObject<EmployeeDto[]>(jsonString);

            var validEmployees = new List<Employee>();

            var sb = new StringBuilder();

            foreach (var employeeDto in deserializedEmployees)
            {
                if (!IsValid(employeeDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var position = FindOrCreatePosition(context, employeeDto.Position);

                var employee = new Employee
                {
                    Name = employeeDto.Name,
                    Age = employeeDto.Age,
                    Position = position
                };

                validEmployees.Add(employee);
                sb.AppendLine(string.Format(SuccessMessage, employee.Name));
            }

            context.Employees.AddRange(validEmployees);
            context.SaveChanges();

            var result = sb.ToString();
            return result;
        }


        public static string ImportItems(FastFoodDbContext context, string jsonString)
        {
            var deserializedItems = JsonConvert.DeserializeObject<ItemsDto[]>(jsonString);

            var validItems = new List<Item>();

            var sb = new StringBuilder();

            foreach (var itemDto in deserializedItems)
            {
                if (!IsValid(itemDto) || validItems.Any(x => x.Name == itemDto.Name))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var category = FindOrCreateCategory(context, itemDto.Category);

                var item = new Item
                {
                    Name = itemDto.Name,
                    Price = itemDto.Price,
                    Category = category
                };

                validItems.Add(item);
                sb.AppendLine(String.Format(SuccessMessage, item.Name));
            }

            context.AddRange(validItems);
            context.SaveChanges();

            var result = sb.ToString().TrimEnd();
            return result;
        }

        private static Category FindOrCreateCategory(FastFoodDbContext context, string categoryName)
        {
            var category = FindCategory(context, categoryName) ?? CreateCategory(context, categoryName);
            return category;
        }

        private static Category FindCategory(FastFoodDbContext context, string categoryName)
        {
            var category = context.Categories.SingleOrDefault(c => c.Name == categoryName);
            return category;
        }

        private static Category CreateCategory(FastFoodDbContext context, string categoryName)
        {
            var category = new Category { Name = categoryName };

            context.Categories.Add(category);
            context.SaveChanges();

            return category;
        }

        public static string ImportOrders(FastFoodDbContext context, string xmlString)
        {
            var serializer = new XmlSerializer(typeof(OrderDto[]), new XmlRootAttribute("Orders"));
            var deserializedOrders = (OrderDto[])serializer.Deserialize(new StringReader(xmlString));

            var orderItems = new List<OrderItem>(); 

            StringBuilder sb = new StringBuilder();

            foreach (var orderDto in deserializedOrders)
            {
                bool isValidItem = true;

                if (!IsValid(orderDto))
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                foreach (var itemDto in orderDto.OrderItems)
                {
                    if (!IsValid(itemDto))
                    {
                        sb.AppendLine(FailureMessage);
                        isValidItem = false;
                        break;
                    }
                }

                if (!isValidItem)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var employee = context.Employees.FirstOrDefault(x => x.Name == orderDto.Employee);

                if (employee == null)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var areValidItems = AreValidItems(context, orderDto.OrderItems);

                if (!areValidItems)
                {
                    sb.AppendLine(FailureMessage);
                    continue;
                }

                var date = DateTime.ParseExact(orderDto.DateTime, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                var orderType = Enum.Parse<OrderType>(orderDto.Type);

                var order = new Order
                {
                    Customer = orderDto.Customer,
                    Employee = employee,
                    DateTime = date,
                    Type = orderType
                };

                foreach (var itemDto in orderDto.OrderItems)
                {
                    var item = context.Items.FirstOrDefault(x => x.Name == itemDto.Name);

                    var orderItem = new OrderItem
                    {
                        Order = order,
                        Item = item,
                        Quantity = itemDto.Quantity
                    };

                    orderItems.Add(orderItem);
                }

                sb.AppendLine($"Order for {orderDto.Customer} on {date.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)} added");
            }

            context.OrderItems.AddRange(orderItems);
            context.SaveChanges();

           return sb.ToString().TrimEnd();
        }

        private static bool AreValidItems(FastFoodDbContext context, OrderItemDto[] orderItems)
        {
            foreach (var item in orderItems)
            {
                var itemExists = context.Items.Any(x => x.Name == item.Name);

                if (!itemExists)
                {
                    return false;
                }
            }

            return true;
        }

        private static Position FindOrCreatePosition(FastFoodDbContext context, string positionName)
        {
            var position = FindPosition(context, positionName) ?? CreatePosition(context, positionName);
            return position;
        }

        private static Position CreatePosition(FastFoodDbContext context, string positionName)
        {
            var position = new Position { Name = positionName };

            context.Positions.Add(position);
            context.SaveChanges();

            return position;
        }

        private static Position FindPosition(FastFoodDbContext context, string positionName)
        {
            var position = context.Positions.SingleOrDefault(p => p.Name == positionName);

            return position;
        }

        public static bool IsValid(object obj)
        {
            var validationContext = new System.ComponentModel.DataAnnotations.ValidationContext(obj);
            var result = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, result, true);
        }
    }
}