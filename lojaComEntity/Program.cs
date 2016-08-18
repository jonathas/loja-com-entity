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
            ManipuladorUsuario manipulador = new ManipuladorUsuario();
            //usuario jon = new usuario()
            //{
            //    nome = "jon",
            //    senha = "123"
            //};

            //manipulador.salva(jon);

            Usuario jon = manipulador.BuscaPorId(2);

            Console.WriteLine(jon.Nome);
            Console.ReadLine();
        }
    }
}
