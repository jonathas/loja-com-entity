using lojaComEntity.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class ManipuladorUsuario
    {

        private EntidadesContext contexto;

        public ManipuladorUsuario()
        {
            contexto = new EntidadesContext();
        }

        public void Salva(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }
    }
}
