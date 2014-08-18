using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Rentacar.Models
{
    public class VeiculoContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
    }
}