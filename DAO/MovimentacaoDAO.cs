using Financas01.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas01.DAO
{
    public class MovimentacaoDAO
    {
        private FinancasContext _context;
        public MovimentacaoDAO(FinancasContext context)
        {
            this._context = context;
        }

        public void Adiciona(Movimentacao movimentacao)
        {
            _context.Movimentacoes.Add(movimentacao);
            _context.SaveChanges();
        }
        public IList<Movimentacao> Lista()
        {
            return _context.Movimentacoes.ToList();
        }
    }
}