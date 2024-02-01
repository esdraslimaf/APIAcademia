using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.User
{
    public class UserDtoUpdate
    {
        [Required(ErrorMessage = "Id é obrigatório!")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Campo nome é obrigatório!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo email é obrigatório!")]
        [EmailAddress(ErrorMessage = "O email está em um formato inválido!")]
        public string Email { get; set; }
    }
}
