﻿using AutoMapper;
using IMS.Core.Entities;
using IMS.ViewModels;

namespace IMS.App_Start
{
    public class AutomapperConfig : Profile
    {

        public static void CreateMaps()
        {
            Mapper.Initialize(m =>
            {
                m.AddProfile<AutomapperConfig>();
            });
        }
        public AutomapperConfig()
        {
           CreateMap<Category, CategoryViewModel>().ReverseMap();
           CreateMap<Product, ProductViewModel>().ReverseMap();
            CreateMap<Country, CountryViewModel>().ReverseMap();
            CreateMap<StateProvince, StateProvinceViewModel>().ReverseMap();
            CreateMap<SalesOrder, SalesOrderViewModel>().ReverseMap();
        }
    }
}