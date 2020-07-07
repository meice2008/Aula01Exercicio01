using Aula01Exercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01Exercicio01.DAO
{
    public class PedidoDAO
    {
        private readonly Context _context;
        public PedidoDAO(Context context)
        {
            _context = context;
        }

        public void Cadastrar(Pedido p)
        {
            _context.Pedidos.Add(p);
            _context.SaveChanges();
        }
        public List<Pedido> Listar()
        {
            return _context.Pedidos.ToList();
        }
    }
}
