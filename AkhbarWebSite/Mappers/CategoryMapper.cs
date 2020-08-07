using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkhbarWebSite.DTOs.Category;
using AkhbarWebSite.Models;
using AutoMapper;

namespace AkhbarWebSite.Mappers
{
    public class CategoryMapper : Profile
    {
        public CategoryMapper()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
