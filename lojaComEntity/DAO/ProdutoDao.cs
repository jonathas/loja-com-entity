using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.DAO
{
    class ProdutoDAO
    {

        private EntidadesContext contexto;

        public ProdutoDAO()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Produto produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public Produto BuscaPorId(int id)
        {
            return contexto.Produtos.FirstOrDefault(p => p.ID == id);
        }

        public void Remove(Produto produto)
        {
            contexto.Produtos.Remove(produto);
            contexto.SaveChanges();
        }

    }
}
