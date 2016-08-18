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
            Usuario jon = new Usuario()
            {
                Nome = "Jon",
                Senha = "123"
            };

            manipulador.Salva(jon);

            Console.WriteLine("Salvou o usuario");
            Console.ReadLine();
        }
    }
}
