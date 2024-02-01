using Api.Domain.Dtos.User;
using Api.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDto>().ReverseMap(); //Mapeia indo e voltando
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();

        }
    }
}
