using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class CepEntity
    {
        [Required]
        public string Cep { get; set; }
        [Required]
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        [Required]
        public Guid MunicipioId { get; set; }
        public MunicipioEntity Municipio { get; set; }
    }
}
