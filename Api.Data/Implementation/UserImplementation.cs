using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Implementation
{
    public class UserImplementation : BaseRepository<UserEntity>, IUserRepository
    {
        private readonly DbSet<UserEntity> _dbset;
        public UserImplementation(MyContext context) : base(context)
        {
            _dbset = context.Set<UserEntity>();
        }

        public async Task<UserEntity> GetByLogin(string login)
        {
            return await _dbset.FirstOrDefaultAsync(u => u.Email == login);
        }
    }
}
