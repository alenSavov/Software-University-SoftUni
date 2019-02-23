using AutoMapper;
using Shop.App.Dto;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.App
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<UserDto, User>();
            CreateMap<ProductDto, Product>();
            CreateMap<CategoryDto, Category>();
        }
    }
}
