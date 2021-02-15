using AutoMapper;
using Mockbuster.Dtos;
using Mockbuster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mockbuster.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}