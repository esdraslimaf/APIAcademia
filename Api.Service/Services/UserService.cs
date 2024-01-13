using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class UserService : IUserService
    {
        private readonly IBaseRepository<UserEntity> _repo;

        public UserService(IBaseRepository<UserEntity> repo)
        {
            _repo = repo;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repo.DeleteAsync(id);
        }

        public async Task<UserEntity> Get(Guid id)
        {
            return await _repo.SelectAsync(id);
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            return await _repo.SelectAllAsync();
        }

        public async Task<UserEntity> Post(UserEntity user)
        {
            return await _repo.InsertAsync(user);
        }

        public async Task<UserEntity> Put(UserEntity user)
        {
            return await _repo.UpdateAsync(user);
        }
    }
}
