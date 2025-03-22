using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efco___Carga_de_pedidos.Negocio
{
    public class GVA21 : Delta3.GVA21
    {
        public List<GVA03> Renglones = new List<GVA03>();

        public List<string> error = new List<string>();

        public int renglones = 0;
    }
}
