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

            //Categoria categoria = contexto.Categorias.Include(c => c.Produtos).FirstOrDefault(c => c.ID == 1);

            //foreach(var p in categoria.Produtos)
            //{
            //    Console.WriteLine(p.Nome);
            //}

            // LINQ
            //decimal precoMinimo = 40;

            //// Nao preciso fazer join nenhum. So usar uma navigation property
            //var busca = from p in contexto.Produtos
            //            where p.Categoria.Nome == "roupas" && p.Preco > precoMinimo
            //            orderby p.Nome
            //            select p;
            //IList<Produto> resultado = busca.ToList();

            //foreach(var produto in resultado)
            //{
            //    Console.WriteLine(produto.Nome + " - " + produto.Preco);
            //}

            //ProdutoDAO dao = new ProdutoDAO();

            //var resultado = dao.BuscaPorNomePrecoNomeCategoria(null,0,"informatica");

            //foreach(var p in resultado)
            //{
            //    Console.WriteLine(p.Nome);
            //}

            // Many to many
            UsuarioDAO dao = new UsuarioDAO();
            Usuario jon = dao.BuscaPorId(1);

            Venda v = new Venda()
            {
                Cliente = jon
            };

            Produto p = contexto.Produtos.FirstOrDefault(prod => prod.ID == 1);
            Produto p2 = contexto.Produtos.FirstOrDefault(prod => prod.ID == 2);

            ProdutoVenda pv = new ProdutoVenda()
            {
                Venda = v,
                Produto = p
            };

            ProdutoVenda pv2 = new ProdutoVenda()
            {
                Venda = v,
                Produto = p2
            };

            contexto.Vendas.Add(v);
            contexto.ProdutoVenda.Add(pv);
            contexto.ProdutoVenda.Add(pv2);

            contexto.SaveChanges();

            Console.ReadLine();
        }
    }
}
