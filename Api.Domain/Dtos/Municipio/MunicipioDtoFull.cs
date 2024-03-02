using Api.Domain.Dtos.Uf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain.Dtos.Municipio
{
    public class MunicipioDtoFull 
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CodIBGE { get; set; }
        public Guid UfId { get; set; }
        public UfDto Uf { get; set; }
    }
}

/* Essa aqui vai servir para quando for puxada um município por id, vir no objeto também o outro objeto que está dentro dele(Objeto Uf)
 * na MunicipioDto não foi colocado a propriedade de navegação para não ficar tão pesado, já que quando for puxado uma lista vai vir apenas o id e não o objeto uf junto de cada registro */