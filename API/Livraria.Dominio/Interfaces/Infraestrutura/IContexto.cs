using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.Dominio.Interfaces.Infraestrutura
{
    public interface IContexto
    {
        int SaveChanges();
    }
}
