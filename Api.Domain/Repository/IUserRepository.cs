using Api.Domain.Entities;
using Api.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Repository
{
    public interface IUserRepository : IBaseRepository<UserEntity>
    {
        Task<UserEntity> GetByLogin(string login);
    }
}
