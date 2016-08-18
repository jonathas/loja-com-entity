using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entidades
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public virtual Categoria Categoria { get; set; } // Navigation property
        public int CategoriaID { get; set; }
    }
}
