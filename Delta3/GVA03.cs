using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta3
{
    public class GVA03
    {
        public virtual string _archivo
        {
            get
            {
                return "CONFIG\\GVA03.XML";
            }
        }

        #region PropsRelacion
        public int R_LISTA { get; set; }
        public string R_COD_VENDED { get; set; }
        #endregion

        #region Props
        public string FILLER { get; set; }
        public decimal CAN_EQUI_V { get; set; }
        public decimal CANT_A_DES { get; set; }
        public decimal CANT_A_FAC { get; set; }
        public decimal CANT_PEDID { get; set; }
        public decimal CANT_PEN_D { get; set; }
        public decimal CANT_PEN_F { get; set; }
        public string COD_ARTICU { get; set; }
        public decimal DESCUENTO { get; set; }
        public int N_RENGLON { get; set; }
        public string NRO_PEDIDO { get; set; }
        public decimal PEN_REM_FC { get; set; }
        public decimal PEN_FAC_RE { get; set; }
        public decimal PRECIO { get; set; }
        public int TALON_PED { get; set; }
        public string COD_CLASIF { get; set; }
        public decimal CANT_A_DES_2 { get; set; }
        public decimal CANT_A_FAC_2 { get; set; }
        public decimal CANT_PEDID_2 { get; set; }
        public decimal CANT_PEN_D_2 { get; set; }
        public decimal CANT_PEN_F_2 { get; set; }
        public decimal PEN_REM_FC_2 { get; set; }
        public decimal PEN_FAC_RE_2 { get; set; }
        public int ID_MEDIDA_VENTAS { get; set; }
        public int ID_MEDIDA_STOCK_2 { get; set; }
        public int ID_MEDIDA_STOCK { get; set; }
        public string UNIDAD_MEDIDA_SELECCIONADA { get; set; }
        public string COD_ARTICU_KIT { get; set; }
        public int RENGL_PADR { get; set; }
        public bool PROMOCION { get; set; }
        public decimal PRECIO_ADICIONAL_KIT { get; set; }
        public bool KIT_COMPLETO { get; set; }
        public bool INSUMO_KIT_SEPARADO { get; set; }
        public decimal PRECIO_LISTA { get; set; }
        public decimal PRECIO_BONIF { get; set; }
        public decimal DESCUENTO_PARAM { get; set; }
        public DateTime PRECIO_FECHA { get; set; }
        public DateTime FECHA_MODIFICACION_PRECIO { get; set; }
        public string USUARIO_MODIFICACION_PRECIO { get; set; }
        public string TERMINAL_MODIFICACION_PRECIO { get; set; }
        public int ID_NEXO_PEDIDOS_RENGLON_ORDEN { get; set; }
        public long ROW_VERSION { get; set; }
        public decimal CANT_A_DES_EXPORTADA { get; set; }
        public decimal CANT_A_FAC_EXPORTADA { get; set; }
        public decimal CANT_A_DES_2_EXPORTADA { get; set; }
        public decimal CANT_A_FAC_2_EXPORTADA { get; set; }
        public string COD_DEPOSI { get; set; }
        public int ID_GVA21 { get; set; }
        public int ID_STA11 { get; set; }
        public int ID_STA22 { get; set; }
        #endregion

        #region Constructor
        public GVA03()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(_archivo);

            CultureInfo culture = SQLH.Cultura();

            FILLER = ds.Tables[0].Rows[0]["FILLER"].ToString();
            CAN_EQUI_V = decimal.Parse(ds.Tables[0].Rows[0]["CAN_EQUI_V"].ToString(), culture);
            CANT_A_DES = decimal.Parse(ds.Tables[0].Rows[0]["CANT_A_DES"].ToString(), culture);
            CANT_A_FAC = decimal.Parse(ds.Tables[0].Rows[0]["CANT_A_FAC"].ToString(), culture);
            CANT_PEDID = decimal.Parse(ds.Tables[0].Rows[0]["CANT_PEDID"].ToString(), culture);
            CANT_PEN_D = decimal.Parse(ds.Tables[0].Rows[0]["CANT_PEN_D"].ToString(), culture);
            CANT_PEN_F = decimal.Parse(ds.Tables[0].Rows[0]["CANT_PEN_F"].ToString(), culture);
            COD_ARTICU = ds.Tables[0].Rows[0]["COD_ARTICU"].ToString();
            DESCUENTO = decimal.Parse(ds.Tables[0].Rows[0]["DESCUENTO"].ToString(), culture);
            N_RENGLON = int.Parse(ds.Tables[0].Rows[0]["N_RENGLON"].ToString());
            NRO_PEDIDO = ds.Tables[0].Rows[0]["NRO_PEDIDO"].ToString();
            PEN_REM_FC = decimal.Parse(ds.Tables[0].Rows[0]["PEN_REM_FC"].ToString(), culture);
            PEN_FAC_RE = decimal.Parse(ds.Tables[0].Rows[0]["PEN_FAC_RE"].ToString(), culture);
            PRECIO = decimal.Parse(ds.Tables[0].Rows[0]["PRECIO"].ToString(), culture);
            TALON_PED = int.Parse(ds.Tables[0].Rows[0]["TALON_PED"].ToString());
            COD_CLASIF = ds.Tables[0].Rows[0]["COD_CLASIF"].ToString();
            CANT_A_DES_2 = decimal.Parse(ds.Tables[0].Rows[0]["CANT_A_DES_2"].ToString(), culture);
            CANT_A_FAC_2 = decimal.Parse(ds.Tables[0].Rows[0]["CANT_A_FAC_2"].ToString(), culture);
            CANT_PEDID_2 = decimal.Parse(ds.Tables[0].Rows[0]["CANT_PEDID_2"].ToString(), culture);
            CANT_PEN_D_2 = decimal.Parse(ds.Tables[0].Rows[0]["CANT_PEN_D_2"].ToString(), culture);
            CANT_PEN_F_2 = decimal.Parse(ds.Tables[0].Rows[0]["CANT_PEN_F_2"].ToString(), culture);
            PEN_REM_FC_2 = decimal.Parse(ds.Tables[0].Rows[0]["PEN_REM_FC_2"].ToString(), culture);
            PEN_FAC_RE_2 = decimal.Parse(ds.Tables[0].Rows[0]["PEN_FAC_RE_2"].ToString(), culture);
            ID_MEDIDA_VENTAS = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_VENTAS"].ToString());
            ID_MEDIDA_STOCK_2 = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_STOCK_2"].ToString());
            ID_MEDIDA_STOCK = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_STOCK"].ToString());
            UNIDAD_MEDIDA_SELECCIONADA = ds.Tables[0].Rows[0]["UNIDAD_MEDIDA_SELECCIONADA"].ToString();
            COD_ARTICU_KIT = ds.Tables[0].Rows[0]["COD_ARTICU_KIT"].ToString();
            RENGL_PADR = int.Parse(ds.Tables[0].Rows[0]["RENGL_PADR"].ToString());
            PROMOCION = ds.Tables[0].Rows[0]["PROMOCION"].ToString() == "" ? true : false;
            PRECIO_ADICIONAL_KIT = decimal.Parse(ds.Tables[0].Rows[0]["PRECIO_ADICIONAL_KIT"].ToString(), culture);
            KIT_COMPLETO = ds.Tables[0].Rows[0]["KIT_COMPLETO"].ToString() == "" ? true : false;
            INSUMO_KIT_SEPARADO = ds.Tables[0].Rows[0]["INSUMO_KIT_SEPARADO"].ToString() == "" ? true : false;
            PRECIO_LISTA = decimal.Parse(ds.Tables[0].Rows[0]["PRECIO_LISTA"].ToString(), culture);
            PRECIO_BONIF = decimal.Parse(ds.Tables[0].Rows[0]["PRECIO_BONIF"].ToString(), culture);
            DESCUENTO_PARAM = decimal.Parse(ds.Tables[0].Rows[0]["DESCUENTO_PARAM"].ToString(), culture);
            PRECIO_FECHA = DateTime.ParseExact(ds.Tables[0].Rows[0]["PRECIO_FECHA"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            FECHA_MODIFICACION_PRECIO = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_MODIFICACION_PRECIO"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            USUARIO_MODIFICACION_PRECIO = ds.Tables[0].Rows[0]["USUARIO_MODIFICACION_PRECIO"].ToString();
            TERMINAL_MODIFICACION_PRECIO = ds.Tables[0].Rows[0]["TERMINAL_MODIFICACION_PRECIO"].ToString();
            ID_NEXO_PEDIDOS_RENGLON_ORDEN = int.Parse(ds.Tables[0].Rows[0]["ID_NEXO_PEDIDOS_RENGLON_ORDEN"].ToString());

            CANT_A_DES_EXPORTADA = decimal.Parse(ds.Tables[0].Rows[0]["CANT_A_DES_EXPORTADA"].ToString(), culture);
            CANT_A_FAC_EXPORTADA = decimal.Parse(ds.Tables[0].Rows[0]["CANT_A_FAC_EXPORTADA"].ToString(), culture);
            CANT_A_DES_2_EXPORTADA = decimal.Parse(ds.Tables[0].Rows[0]["CANT_A_DES_2_EXPORTADA"].ToString(), culture);
            CANT_A_FAC_2_EXPORTADA = decimal.Parse(ds.Tables[0].Rows[0]["CANT_A_FAC_2_EXPORTADA"].ToString(), culture);
            COD_DEPOSI = ds.Tables[0].Rows[0]["COD_DEPOSI"].ToString();
            ID_GVA21 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA21"].ToString());
            ID_STA11 = int.Parse(ds.Tables[0].Rows[0]["ID_STA11"].ToString());
            ID_STA22 = int.Parse(ds.Tables[0].Rows[0]["ID_STA22"].ToString());
        }
        #endregion

        #region Methods
        public string Insert()
        {
            string sql = @"INSERT INTO GVA03 (
            FILLER
            ,CAN_EQUI_V
            ,CANT_A_DES
            ,CANT_A_FAC
            ,CANT_PEDID
            ,CANT_PEN_D
            ,CANT_PEN_F
            ,COD_ARTICU
            ,DESCUENTO
            ,N_RENGLON
            ,NRO_PEDIDO
            ,PEN_REM_FC
            ,PEN_FAC_RE
            ,PRECIO
            ,TALON_PED
            ,COD_CLASIF
            ,CANT_A_DES_2
            ,CANT_A_FAC_2
            ,CANT_PEDID_2
            ,CANT_PEN_D_2
            ,CANT_PEN_F_2
            ,PEN_REM_FC_2
            ,PEN_FAC_RE_2
            ,ID_MEDIDA_VENTAS
            ,ID_MEDIDA_STOCK_2
            ,ID_MEDIDA_STOCK
            ,UNIDAD_MEDIDA_SELECCIONADA
            ,COD_ARTICU_KIT
            ,RENGL_PADR
            ,PROMOCION
            ,PRECIO_ADICIONAL_KIT
            ,KIT_COMPLETO
            ,INSUMO_KIT_SEPARADO
            ,PRECIO_LISTA
            ,PRECIO_BONIF
            ,DESCUENTO_PARAM
            ,PRECIO_FECHA
            ,FECHA_MODIFICACION_PRECIO
            ,USUARIO_MODIFICACION_PRECIO
            ,TERMINAL_MODIFICACION_PRECIO
            ,ID_NEXO_PEDIDOS_RENGLON_ORDEN
            ,CANT_A_DES_EXPORTADA
            ,CANT_A_FAC_EXPORTADA
            ,CANT_A_DES_2_EXPORTADA
            ,CANT_A_FAC_2_EXPORTADA
            ,COD_DEPOSI
            ,ID_GVA21
            ,ID_STA11
            ,ID_STA22
            ) VALUES (
            " + SQLH.ToString(FILLER) + @"
            ," + SQLH.ToDecimal(CAN_EQUI_V) + @"
            ," + SQLH.ToDecimal(CANT_A_DES) + @"
            ," + SQLH.ToDecimal(CANT_A_FAC) + @"
            ," + SQLH.ToDecimal(CANT_PEDID) + @"
            ," + SQLH.ToDecimal(CANT_PEN_D) + @"
            ," + SQLH.ToDecimal(CANT_PEN_F) + @"
            ," + SQLH.ToString(COD_ARTICU) + @"
            ," + SQLH.ToDecimal(DESCUENTO) + @"
            ," + SQLH.ToInt(N_RENGLON) + @"
            ," + SQLH.ToString(NRO_PEDIDO) + @"
            ," + SQLH.ToDecimal(PEN_REM_FC) + @"
            ," + SQLH.ToDecimal(PEN_FAC_RE) + @"
            ," + SQLH.ToDecimal(PRECIO) + @"
            ," + SQLH.ToInt(TALON_PED) + @"
            ," + SQLH.ToString(COD_CLASIF) + @"
            ," + SQLH.ToDecimal(CANT_A_DES_2) + @"
            ," + SQLH.ToDecimal(CANT_A_FAC_2) + @"
            ," + SQLH.ToDecimal(CANT_PEDID_2) + @"
            ," + SQLH.ToDecimal(CANT_PEN_D_2) + @"
            ," + SQLH.ToDecimal(CANT_PEN_F_2) + @"
            ," + SQLH.ToDecimal(PEN_REM_FC_2) + @"
            ," + SQLH.ToDecimal(PEN_FAC_RE_2) + @"
            ," + SQLH.TraerIdCampo("STA11", "ID_MEDIDA_VENTAS", "COD_ARTICU", COD_ARTICU) + @"
            ," + SQLH.ToInt(ID_MEDIDA_STOCK_2) + @"
            ," + SQLH.TraerIdCampo("STA11", "ID_MEDIDA_STOCK", "COD_ARTICU", COD_ARTICU) + @"
            ," + SQLH.ToString(UNIDAD_MEDIDA_SELECCIONADA) + @"
            ," + SQLH.ToString(COD_ARTICU_KIT) + @"
            ," + SQLH.ToInt(RENGL_PADR) + @"
            ," + SQLH.ToBool(PROMOCION) + @"
            ," + SQLH.ToDecimal(PRECIO_ADICIONAL_KIT) + @"
            ," + SQLH.ToBool(KIT_COMPLETO) + @"
            ," + SQLH.ToBool(INSUMO_KIT_SEPARADO) + @"
            ," + SQLH.ToDecimal(PRECIO_LISTA) + @"
            ," + SQLH.ToDecimal(PRECIO_BONIF) + @"
            ," + SQLH.ToDecimal(DESCUENTO_PARAM) + @"
            ," + SQLH.ToDateTime(PRECIO_FECHA) + @"
            ," + SQLH.ToDateTime(FECHA_MODIFICACION_PRECIO) + @"
            ," + SQLH.ToString(USUARIO_MODIFICACION_PRECIO) + @"
            ," + SQLH.ToString(TERMINAL_MODIFICACION_PRECIO) + @"
            ," + SQLH.ToInt(ID_NEXO_PEDIDOS_RENGLON_ORDEN) + @"
            ," + SQLH.ToDecimal(CANT_A_DES_EXPORTADA) + @"
            ," + SQLH.ToDecimal(CANT_A_FAC_EXPORTADA) + @"
            ," + SQLH.ToDecimal(CANT_A_DES_2_EXPORTADA) + @"
            ," + SQLH.ToDecimal(CANT_A_FAC_2_EXPORTADA) + @"
            ," + SQLH.ToString(COD_DEPOSI) + @"
            ,(SELECT ID_GVA21 FROM GVA21 WHERE TALON_PED = " + SQLH.ToInt(TALON_PED) + " AND NRO_PEDIDO = " + SQLH.ToString(NRO_PEDIDO) + @")
            ," + SQLH.TraerId("STA11", "COD_ARTICU", COD_ARTICU) + @"
            ," + SQLH.TraerId("STA22", "COD_SUCURS", COD_DEPOSI) + @"                  
            )";

            return sql;
        }
        #endregion

    }
}
