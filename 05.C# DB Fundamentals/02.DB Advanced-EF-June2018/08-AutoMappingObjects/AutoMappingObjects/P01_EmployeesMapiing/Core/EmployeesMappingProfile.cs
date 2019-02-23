using AutoMapper;
using EmployeesMapiing.App.Core;
using EmployeesMapiing.App.Core.Dtos;
using EmployeesMappin.Models;
using EmployeesMapping.App.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesMapping.App.Core
{
    public class EmployeesMappingProfile : Profile
    {
        public EmployeesMappingProfile()
        {
            CreateMap<Employees, EmployeeDto>().ReverseMap();
            CreateMap<Employees, ManagerDto>().ForMember(dest => dest.EmployeeDtos,
                from => from.MapFrom(x => x.ManagerEmployees)).ReverseMap();
            CreateMap<Employees, EmployeePersonalInfoDto>().ReverseMap();

        }
    }
}
