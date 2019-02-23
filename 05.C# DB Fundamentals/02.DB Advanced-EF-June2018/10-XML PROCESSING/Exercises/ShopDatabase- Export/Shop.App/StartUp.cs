using AutoMapper;
using Shop.App.Dto;
using Shop.Data;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using DataAnotations = System.ComponentModel.DataAnnotations;

namespace Shop.App
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var context = new ShopContext();

            var users = new UsersDto
            {
                Count = context.Users.Count(),
                User = context.Users
                .Where(x => x.ProductSold.Count >= 1)
                .Select(x => new UserDto
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Age = x.Age.ToString(),
                    SoldProducts =  new SoldProduct
                    {
                        Count = x.ProductSold.Count(),
                        ProductDto = x.ProductSold.Select(k => new ProductDto
                        {
                             Name = k.Name,
                             Price = k.Price
                        }).ToArray()
                    }
                }).ToArray()
            };
            
            var sb = new StringBuilder();
            var xmlNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });

            var serializer = new XmlSerializer(typeof(UsersDto), new XmlRootAttribute("users"));
            serializer.Serialize(new StringWriter(sb), users, xmlNamespaces);

            File.WriteAllText("../../../Xml/users-and-products.xml", sb.ToString());
        }
    }
}
