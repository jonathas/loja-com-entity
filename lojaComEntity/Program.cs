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
            EntidadesContext contexto = new EntidadesContext();
            Usuario jon = new Usuario()
            {
                Nome = "Jon",
                Senha = "123"
            };

            contexto.Usuarios.Add(jon);
            contexto.SaveChanges();
            contexto.Dispose();
        }
    }
}
