using BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efco___Carga_de_pedidos.Negocio
{
    public class Procesos
    {
        int talon_a = 0;
        int talon_b = 0;
        int talon_ped = 0;

        public string Configurar()
        {
            string ret = "";
            try
            {
                DataSet ds = new DataSet();

                ds.ReadXml("CONFIG\\CONFIG.XML");
                db.cadenaConexion = ds.Tables[0].Rows[0]["SQLSTRING"].ToString();
                int.TryParse(ds.Tables[0].Rows[0]["TALON_A"].ToString(),out talon_a);
                int.TryParse(ds.Tables[0].Rows[0]["TALON_B"].ToString(), out talon_b);
                int.TryParse(ds.Tables[0].Rows[0]["TALON_PED"].ToString(), out talon_ped);
                db.Configurar();
                db.Conectar();
            }
            catch (Exception ex)
            {
                ret = "Error de Conexion" + Environment.NewLine;
                ret += ex.Message.ToString();
            }
            return ret;
        }

        public bool ExisteCliente(string cod_client)
        {
            bool ret = false;
            db.CrearComando("SELECT COD_CLIENT FROM GVA14 WHERE COD_CLIENT = '" + cod_client + @"' ");
            DbDataReader dr = db.EjecutarConsulta();

            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count == 1)
            {
                ret = true;
            }

            dr.Close();
            dr = null;

            return ret;

        }

        internal void ComenzarTransac()
        {
            db.ComenzarTransaccion();
        }

        internal void ConfirmarTransac()
        {
            db.ConfirmarTransaccion();
        }


        public GVA21 TraerInfoCliente(string cod_client)
        {
            string sSql = "SELECT COD_TRANSP,COD_CLIENT,COD_VENDED,MON_CTE,COND_VTA,IVA_D,IVA_L " +
                           "FROM GVA14 WHERE TELEFONO_MOVIL='" + cod_client + "'";


            db.CrearComando(sSql);
            DbDataReader dr = db.EjecutarConsulta();

            DataTable dt = new DataTable();
            dt.Load(dr);
            GVA21 oGva21 = new GVA21();
            
            
            if (dt.Rows.Count == 1)
            {
                oGva21.COD_CLIENT = dt.Rows[0]["COD_CLIENT"].ToString();
                //oGva21.COD_TRANSP = "01";
                oGva21.COD_VENDED = dt.Rows[0]["COD_VENDED"].ToString();
                oGva21.MON_CTE = false;
                if ((bool)dt.Rows[0]["MON_CTE"])
                {
                    oGva21.MON_CTE = true;
                }
                //oGva21.MON_CTE = dt.Rows[0]["MON_CTE"].ToString();
                oGva21.COND_VTA = int.Parse(dt.Rows[0]["COND_VTA"].ToString());

                switch(oGva21.COD_CLIENT.Substring(2,1))
                {
                    case "A":
                        oGva21.TALONARIO = 20;                        
                        break;
                    case "B":
                        oGva21.TALONARIO = 20;
                        break;
                    case "C":
                        oGva21.TALONARIO = 21;
                        break;
                    case "M":
                        oGva21.TALONARIO = 22;
                        break;
                    case "N":
                        oGva21.TALONARIO = 22;
                        break;
                    case "U":
                        oGva21.TALONARIO = 21;
                        break;
                    case "R":
                        oGva21.TALONARIO = 20;
                        break;
                }

                oGva21.LEYENDA_1 = ConvertirLetra(oGva21.COD_CLIENT);

            }

            dr.Close();
            dr = null;

            return oGva21;
        }

        private string ConvertirLetra(string cOD_CLIENT)
        {
            string ret = cOD_CLIENT;

            //Que reemplace la letra B por 46
            ret = ret.Replace("B", "46");
            //Que reemplace la letra R por 49
            ret = ret.Replace("R", "49");
            //Que reemplace la letra A por 14
            ret = ret.Replace("A", "14");
            //Que reemplace la letra C seguida de 0(es un cero), por 66
            if (ret.IndexOf("C0") > 0)
            {
                ret = ret.Replace("C", "66");
            }
            //Que reemplace la letra C seguida de un numero distinto de cero, por 14
            ret = ret.Replace("C", "14");
            //Que reemplace la letra M seguida de 0(es un cero), por 47
            if (ret.IndexOf("M0") > 0)
            { 
                ret = ret.Replace("M", "47");
            }
            //Que reemplace la letra M seguida de un numero distinto de cero, por 14
            ret = ret.Replace("M", "14");
            //Que reemplace la letra U por 14
            ret = ret.Replace("U", "14");
            //Que reemplace la letra N por 14
            ret = ret.Replace("N", "14");

            return ret;
        }

        public int TraerDireccionEntrega(string cod_client)
        {
            int ret = -1;
            db.CrearComando(@"SELECT ID_DIRECCION_ENTREGA FROM DIRECCION_ENTREGA
                            WHERE 1 = 1
                            AND HABILITADO = 'S'
                            AND HABITUAL = 'S'
                            AND COD_CLIENTE = '" + cod_client + @"'");
            DbDataReader dr = db.EjecutarConsulta();
            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count == 1)
            {
                ret = int.Parse(dt.Rows[0]["ID_DIRECCION_ENTREGA"].ToString());
            }

            dr.Close();
            dr = null;

            return ret;

        }

        internal string CargarPedido(Pedido ped)
        {
            string ret = "";

            try
            {

                TG oTg = new TG();
                GVA21 oGva21 = new GVA21();
                GVA03 oGva03 = new GVA03();

                //#Agregado ultimo

                string cliTemp = ped.cliente;

                int sub = ped.cliente.IndexOf("-");

                if (sub > 0 )
                {
                    cliTemp = ped.cliente.Substring(0, sub);
                }

                //##Agregado ultimo 

                oGva21 = TraerInfoCliente(cliTemp);
                if (oGva21.COD_CLIENT.Equals(""))
                {
                    ret = "Cliente no tiene cargado el contrato en Tango!";
                    return ret;
                }
                oGva03.COD_ARTICU = Existearticu(ped.articulo);
                if (oGva03.COD_ARTICU.Equals(""))
                {
                    ret = "Articulo no existe en Tango!";
                    return ret;
                }
                if(ped.precio <= 0)
                {
                    ret = "Importe Incorrecto! " + ped.precio.ToString();
                    return ret;
                }

                oGva21.COND_VTA = TraerCondicionVta(ped.articulo);
                oGva21.TALON_PED = talon_ped;
                oGva21.NRO_PEDIDO = TraerProximoPedido(talon_ped);
                oGva21.FECHA_PEDI = ped.fecha;
                oGva21.FECHA_INGRESO = ped.fecha;
                oGva21.HORA = "100000";
                oGva21.HORA_INGRESO = "100000";
                //COTIZ
                oGva21.COTIZ = ped.cotiz;

                oGva21.ID_DIRECCION_ENTREGA = TraerDireccionEntrega(oGva21.COD_CLIENT);
                //oGva03.COD_ARTICU = ped.articulo;
                oGva03.PRECIO = ped.precio;
                oGva03.PRECIO_LISTA = ped.precio;
                oGva03.PRECIO_BONIF = ped.precio;
                oGva03.COD_DEPOSI = oGva21.COD_SUCURS;

                oGva03.N_RENGLON = 1;
                GVA03 rengl_adic1 = TraerGVA03Adic(ped.leyenda, ped.leyenda2);
                rengl_adic1.N_RENGLON = 2;
                rengl_adic1.TALON_PED = oGva21.TALON_PED;
                rengl_adic1.NRO_PEDIDO = oGva21.NRO_PEDIDO;
                GVA03 rengl_adic2 = TraerGVA03Adic(ped.leyenda, ped.leyenda2);
                rengl_adic2.N_RENGLON = 3;
                rengl_adic2.TALON_PED = oGva21.TALON_PED;
                rengl_adic2.NRO_PEDIDO = oGva21.NRO_PEDIDO;

                if (ped.articulo.Equals("Rent"))
                {
                    rengl_adic1.DESC = "Correspondiente al mes:";
                    rengl_adic2.DESC = ped.leyenda;
                }
                if (ped.articulo.Equals("URE"))
                {
                    rengl_adic1.DESC = "PARTE NRO-" + ped.cliente.Substring(ped.cliente.IndexOf("-"),3);
                }

                string sqltemp = "";

                db.CrearComando(oGva21.Insert());
                db.EjecutarComando();
                oGva03.TALON_PED = oGva21.TALON_PED;
                oGva03.NRO_PEDIDO = oGva21.NRO_PEDIDO;
                sqltemp = oGva03.Insert();
                db.CrearComando(oGva03.Insert());
                db.EjecutarComando();

                if (ped.articulo.Equals("Rent") || ped.articulo.Equals("URE"))
                {
                    db.CrearComando(rengl_adic1.Insert());
                    db.EjecutarComando();
                    db.CrearComando(rengl_adic1.TOGVA45());
                    db.EjecutarComando();
                    if (ped.articulo.Equals("Rent"))
                    {
                        db.CrearComando(rengl_adic2.Insert());
                        db.EjecutarComando();
                        db.CrearComando(rengl_adic2.TOGVA45());
                        db.EjecutarComando();
                    }
                    
                }

                ActualizarTalonario(oGva21.NRO_PEDIDO, oGva21.TALON_PED);
                ret = "Ok-" + oGva21.NRO_PEDIDO;
            }
            catch (Exception ex)
            {
                ret = ex.Message.ToString();
            }

            

            return ret;
        }

        private int TraerCondicionVta(string articulo)
        {
            int ret = 7;

            switch (articulo)
            {
                case "Sale":
                    ret = 1;
                    break;
            }
            return ret;
        }

        private string TraerProximoPedido(int talon_ped)
        {
            string sNumber = "";

            string sSql = "SELECT * FROM GVA43 WHERE TALONARIO =" + talon_ped.ToString();

            db.CrearComando(sSql);
            DbDataReader dr = db.EjecutarConsulta();
            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count == 1)
            {
                TG oTg = new TG();

                sNumber = dt.Rows[0]["TIPO"].ToString().PadLeft(1, ' ')
                     + dt.Rows[0]["SUCURSAL"].ToString().PadLeft(5, '0')
                     + oTg.DocNumberDecrypt(dt.Rows[0]["PROXIMO"].ToString()).PadLeft(8, '0');
            }

            return sNumber;
        }


        private void ActualizarTalonario(string n_comp,int talonario)
        {
            int dNumber = int.Parse(n_comp.Substring(n_comp.Length-8));
            TG oTg = new TG();
            string sNextNumber = oTg.DocNumberEncrypt((dNumber + 1).ToString());


            string sSql = "UPDATE GVA43 ";
            sSql += "SET PROXIMO = '" + sNextNumber + "' ";
            sSql +=  "WHERE TALONARIO = " + talonario;

            db.CrearComando(sSql);
            db.EjecutarComando();

        }

        private GVA03 TraerGVA03Adic(string leyenda, string leyenda2)
        {
            GVA03 o = new GVA03();

            o.CANT_A_DES = 0;
            o.CANT_A_FAC = 0;
            o.CANT_PEDID = 0;
            o.CANT_PEN_D = 0;
            o.CANT_PEN_F = 0;
            o.COD_ARTICU = "";
            o.ID_MEDIDA_STOCK = -1;
            o.ID_MEDIDA_VENTAS = -1;
            o.DESC = leyenda;
            o.N_RENGLON = 2;
            o.DESC_ADIC = leyenda2;
            return o;

        }

        internal void CancelarTransac()
        {
            db.CancelarTransaccion();
        }

        public string Existearticu(string cod_articu)
        {
            string ret = "";
            db.CrearComando("SELECT COD_ARTICU FROM STA11 WHERE SINONIMO = '" + cod_articu + @"'");
            DbDataReader dr = db.EjecutarConsulta();

            DataTable dt = new DataTable();
            dt.Load(dr);

            if (dt.Rows.Count == 1)
            {
                ret = dt.Rows[0]["COD_ARTICU"].ToString();
            }

            dr.Close();
            dr = null;

            return ret;

        }

    }
}
