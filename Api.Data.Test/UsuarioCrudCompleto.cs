using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Data.Test
{
    public class UsuarioCrudCompleto:BaseTest, IClassFixture<DbTest>
    {
        private IServiceProvider _serviceProvider;
    }
}
