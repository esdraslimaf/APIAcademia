using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class UfEntity:BaseEntity
    {
        [Required]
        [MaxLength(3)]
        public string Sigla { get; set; }
        [Required]
        public string Nome { get; set; }
        public ICollection<MunicipioEntity> Municipios { get; set; }
    }
}
