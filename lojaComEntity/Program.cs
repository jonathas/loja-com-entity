using lojaComEntity.DAO;
using lojaComEntity.Entidades;
using Microsoft.Data.Entity;
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
            //UsuarioDAO dao = new UsuarioDAO();
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

            //Categoria c = new Categoria()
            //{
            //    Nome = "Informatica"
            //};

            //contexto.Categorias.Add(c);
            //contexto.SaveChanges();

            //Produto p = new Produto()
            //{
            //    Nome = "Mouse",
            //    Preco = 20,
            //    Categoria = c
            //};

            //Produto p = new Produto()
            //{
            //    Nome = "Teclado",
            //    Preco = 30,
            //    CategoriaID = 1
            //};

            //contexto.Produtos.Add(p);
            //contexto.SaveChanges();

            //Produto p = contexto.Produtos.FirstOrDefault(produto => produto.ID == 1);

            // Com o metodo Include, o Entity traz o relacionamento
            //Produto p = contexto.Produtos.Include(produto => produto.Categoria).FirstOrDefault(produto => produto.ID == 1);

            //Console.WriteLine(p.Nome);

            //Console.WriteLine(p.Categoria.Nome);

            Categoria categoria = contexto.Categorias.Include(c => c.Produtos).FirstOrDefault(c => c.ID == 1);

            foreach(var p in categoria.Produtos)
            {
                Console.WriteLine(p.Nome);
            }

            Console.ReadLine();
        }
    }
}
