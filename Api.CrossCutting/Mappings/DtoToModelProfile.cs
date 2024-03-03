using Api.Domain.Dtos.Cep;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Dtos.Uf;
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
            //User
            CreateMap<UserModel, UserDto>().ReverseMap(); //Mapeia indo e voltando
            CreateMap<UserModel, UserDtoCreate>().ReverseMap();
            CreateMap<UserModel, UserDtoUpdate>().ReverseMap();

            //Uf
            CreateMap<UfModel, UfDto>().ReverseMap();

            //Municipio
            CreateMap<MunicipioModel, MunicipioDto>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoCreate>().ReverseMap();
            CreateMap<MunicipioModel, MunicipioDtoUpdate>().ReverseMap();

            //Cep
            CreateMap<CepModel, CepDto>().ReverseMap();
            CreateMap<CepModel, CepDtoCreate>().ReverseMap();
            CreateMap<CepModel, CepDtoUpdate>().ReverseMap();
        }
    }
}
