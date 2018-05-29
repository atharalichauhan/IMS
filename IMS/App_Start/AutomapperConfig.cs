using AutoMapper;
using IMS.Core.Entities;
using IMS.Web.ViewModels;

namespace IMS.App_Start
{
    public class AutomapperConfig
    {
        public static void CreateMaps()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Category, CategoryViewModel>().ReverseMap());
        }
    }
    

}