using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsuarioDao dao = new UsuarioDao();
            //usuario jon = new usuario()
            //{
            //    nome = "jon",
            //    senha = "123"
            //};

            //manipulador.salva(jon);

            // estado da entidade: unchanged
            //Usuario jon = dao.BuscaPorId(1);
            //Console.WriteLine(jon.Nome);

            // estado da entidade: deleted
            //dao.Remove(jon);

            // estado da entidade: modified
            //jon.Nome = "Jon Ribeiro";

            // estado da entidade: added
            //dao.Salva(new Usuario());

            // Que lindo, cara
            //dao.SaveChanges();


            EntidadesContext contexto = new EntidadesContext();

            Categoria c = new Categoria()
            {
                Nome = "Informatica"
            };

            contexto.Categorias.Add(c);
            contexto.SaveChanges();

            Produto p = new Produto()
            {
                Nome = "Mouse",
                Preco = 20,
                Categoria = c
            };

            contexto.Produtos.Add(p);
            contexto.SaveChanges();

            Console.ReadLine();
        }
    }
}
