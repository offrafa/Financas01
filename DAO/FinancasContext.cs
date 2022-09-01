using Financas01.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Financas01.DAO
{
    public class FinancasContext : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Movimentacao> movimentacoes { get; set; }

        
    }
}