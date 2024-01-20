using Api.Application.Security;
using Api.Domain.Dtos;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Repository;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _userRepository;
        public SigningConfigurations _signingConfigurations;

        public LoginService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<object> GetByLogin(LoginDto user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                return await _userRepository.GetByLogin(user.Email);
            }
            return null;
        }
    }
}
