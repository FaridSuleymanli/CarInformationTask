using AutoMapper;
using CarInformationTask.Entities.DTO;
using CarInformationTask.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInformationTask.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CarDTO, Car>().ReverseMap();
        }
    }
}
