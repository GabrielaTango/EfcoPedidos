using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efco___Carga_de_pedidos.Negocio
{
    public class Pedido
    {
        public int fila { get; set; }
        public string cliente { get; set; }
        public string articulo { get; set; }
        public decimal precio { get; set; }
        public DateTime fecha { get; set; }
        public string leyenda { get; set; }
        public string leyenda2 { get; set; }
        public decimal cotiz { get; set; }
        public string log { get; set; }

    }
}
