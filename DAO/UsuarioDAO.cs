using Financas01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas01.DAO
{
    public class UsuarioDAO
    {
        private FinancasContext Context;
        public UsuarioDAO(FinancasContext context)
        {
            this.Context = context;
        }

        public void Adiciona(Usuario usuario)
        {

        }

        public IList<Usuario> Lista()
        {

        }
    }
}