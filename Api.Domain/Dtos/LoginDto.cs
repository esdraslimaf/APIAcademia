using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Campo email é obrigatório para login!")]
        [EmailAddress(ErrorMessage = "O email está em um formato inválido!")]
        public string Email { get; set; }

    }
}
