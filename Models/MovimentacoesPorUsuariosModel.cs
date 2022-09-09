using Financas01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas01.Models
{
    public class MovimentacoesPorUsuariosModel
    {
        public int? UsuarioId { get; set; }

        public IList<Movimentacao> Movimentacoes { get; set; }

        public IList<Usuario> Usuarios { get; set; }
    }
}