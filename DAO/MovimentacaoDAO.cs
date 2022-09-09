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
        public IList<Movimentacao> BuscarUsuarios(int? usuarioId)
        {
            return _context.Movimentacoes.Where(m => m.UsuarioId == usuarioId).ToList();
        }

        internal IList<Movimentacao> Busca(decimal? valorMinimo, decimal? valorMaximo, DateTime? dataMinima, DateTime? dataMaxima, Tipo? tipo, int? usuarioId)
        {
            IQueryable<Movimentacao> resultado = _context.Movimentacoes;
            if (valorMinimo.HasValue)
            {
                resultado = resultado.Where(m => m.Valor >= valorMinimo);
            }
            if (valorMaximo.HasValue)
            {
                resultado = resultado.Where(m => m.Valor <= valorMaximo);
            }
            if (dataMinima.HasValue)
            {
                resultado = resultado.Where(m => m.Data >= dataMinima);
            }
            if (dataMaxima.HasValue)
            {
                resultado = resultado.Where(m => m.Data <= dataMaxima);
            }
            if (tipo.HasValue)
            {
                resultado = resultado.Where(m => m.Tipo == tipo);
            }
            if (usuarioId.HasValue)
            {
                resultado = resultado.Where(m => m.UsuarioId == usuarioId);
            }
            return resultado.ToList();
        }
    }
}