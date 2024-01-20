using Api.Application.Security;
using Api.Domain.Dtos;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Api.Domain.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _userRepository;
        private SigningConfigurations _signingConfigurations;
        private TokenConfigurations _tokenConfigurations;
        private IConfiguration _configuration { get; }

        public LoginService(IUserRepository userRepository, TokenConfigurations tokenConfigurations, SigningConfigurations signingConfigurations, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _tokenConfigurations = tokenConfigurations;
            _signingConfigurations = signingConfigurations;
            _configuration = configuration;
        }

        public async Task<object> GetByLogin(LoginDto user)
        {
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                var result = await _userRepository.GetByLogin(user.Email);
                if (result == null) return new { authenticated = false, message="Falha na autenticação!"};
                else
                {
                    ClaimsIdentity identity = new ClaimsIdentity(
                        
                        new GenericIdentity(user.Email),
                        new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), //Jti é como se fosse o Id to token
                            new Claim(JwtRegisteredClaimNames.UniqueName, user.Email),
                        }                         
                     );
                    DateTime createDate = DateTime.Now;
                    DateTime expirationDate = createDate + TimeSpan.FromSeconds(_tokenConfigurations.Seconds);

                    var handler = new JwtSecurityTokenHandler();

                    string token = CreateToken(identity, createDate, expirationDate, handler);

                    return SuccessObject(createDate, expirationDate, token, user);


                }
            }

            else return new { authenticated = false, message = "Falha na autenticação!" };
        }

        private string CreateToken(ClaimsIdentity identity, DateTime createDate, DateTime expirationDate, JwtSecurityTokenHandler handler)
        {
            var securityToken = handler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _tokenConfigurations.Issuer,
                Audience = _tokenConfigurations.Audience,
                SigningCredentials = _signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = createDate,
                Expires = expirationDate,
            });

            var token = handler.WriteToken(securityToken);
            return token;
        }

        private object SuccessObject(DateTime createDate, DateTime expirationDate, string token, LoginDto user)
        {
            return new
            {
                authenticated = true,
                create = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                accessToken = token,
                userName = user.Email,
                message = "Usuário Logado com sucesso"
            };
        }

    }

}
