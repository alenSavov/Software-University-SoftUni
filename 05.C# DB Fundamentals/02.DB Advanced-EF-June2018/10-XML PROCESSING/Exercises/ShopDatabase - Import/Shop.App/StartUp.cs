using AutoMapper;
using Shop.App.Dto;
using Shop.Data;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Serialization;
using DataAnotations = System.ComponentModel.DataAnnotations;

namespace Shop.App
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //using (var db = new ShopContext())
            //{
            //    db.Database.EnsureDeleted();
            //    db.Database.EnsureCreated();
            //}

            var config = new MapperConfiguration(cfg => { cfg.AddProfile<ProductProfile>(); });
            var categoryProducts = new List<CategoryProduct>();

            var mapper = config.CreateMapper();

            for (int productId = 201; productId <= 400; productId++)
            {
                var categoryId = new Random().Next(1, 11);

                var categoryProduct = new CategoryProduct()
                {
                    ProductId = productId,
                    CategoryId = categoryId
                };
                categoryProducts.Add(categoryProduct);
            }

            var context = new ShopContext();
            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();

            var xmlString = File.ReadAllText("../../../Xml/categories.xml");
            var serializer = new XmlSerializer(typeof(CategoryDto[]), new XmlRootAttribute("categories"));

            var deserializerCategories = (CategoryDto[])serializer.Deserialize(new StringReader(xmlString));

            List<Category> categories = new List<Category>();

            foreach (var categoryDto in deserializerCategories)
            {
                if (!IsValid(categoryDto))
                {
                    continue;
                } 

                var category = mapper.Map<Category>(categoryDto);
                categories.Add(category);
            }

            context.Categories.AddRange(categories);
            context.SaveChanges();
        }
        public static bool IsValid(object obj)
        {
            var validationContext = new DataAnotations.ValidationContext(obj);
            var validationResults = new List<DataAnotations.ValidationResult>();

            return Validator.TryValidateObject(obj, validationContext, validationResults, true);
        }
    }
}
