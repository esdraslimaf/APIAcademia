using Api.Data.Mapping;
using Api.Domain.Dtos.Cep;
using Api.Domain.Dtos.Municipio;
using Api.Domain.Dtos.Uf;
using Api.Domain.Dtos.User;
using Api.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile:Profile
    {
        public EntityToDtoProfile()
        {
            //User
            CreateMap<UserDto, UserEntity>().ReverseMap();
            CreateMap<UserDtoCreateResult, UserEntity>().ReverseMap();
            CreateMap<UserDtoUpdateResult, UserEntity>().ReverseMap();

            //Uf
            CreateMap<UfDto,UfEntity>().ReverseMap();

            //Municipio
            CreateMap<MunicipioDto, MunicipioEntity>().ReverseMap();
            CreateMap<MunicipioDtoFull, MunicipioEntity>().ReverseMap();
            CreateMap<MunicipioDtoCreateResult, MunicipioEntity>().ReverseMap();
            CreateMap<MunicipioDtoUpdateResult, MunicipioEntity>().ReverseMap();

            //Cep
            CreateMap<CepDto, CepEntity>().ReverseMap();
            CreateMap<CepDtoCreateResult, CepEntity>().ReverseMap();
            CreateMap<CepDtoUpdateResult, CepEntity>().ReverseMap();
        }
    }
}
