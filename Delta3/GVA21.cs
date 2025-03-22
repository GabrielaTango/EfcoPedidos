using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta3
{
    public class GVA21
    {
        #region Props
        public string FILLER { get; set; }
        public string APRUEBA { get; set; }
        public int CIRCUITO { get; set; }
        public string COD_CLIENT { get; set; }
        public string COD_SUCURS { get; set; }
        public string COD_TRANSP { get; set; }
        public string COD_VENDED { get; set; }
        public string COMENTARIO { get; set; }
        public bool COMP_STK { get; set; }
        public int COND_VTA { get; set; }
        public decimal COTIZ { get; set; }
        public int ESTADO { get; set; }
        public bool EXPORTADO { get; set; }
        public DateTime FECHA_APRU { get; set; }
        public DateTime FECHA_ENTR { get; set; }
        public DateTime FECHA_PEDI { get; set; }
        public string HORA_APRUE { get; set; }
        public string ID_EXTERNO { get; set; }
        public string LEYENDA_1 { get; set; }
        public string LEYENDA_2 { get; set; }
        public string LEYENDA_3 { get; set; }
        public string LEYENDA_4 { get; set; }
        public string LEYENDA_5 { get; set; }
        public bool MON_CTE { get; set; }
        public int N_LISTA { get; set; }
        public string N_REMITO { get; set; }
        public string NRO_PEDIDO { get; set; }
        public int NRO_SUCURS { get; set; }
        public string ORIGEN { get; set; }
        public decimal PORC_DESC { get; set; }
        public string REVISO_FAC { get; set; }
        public string REVISO_PRE { get; set; }
        public string REVISO_STK { get; set; }
        public int TALONARIO { get; set; }
        public int TALON_PED { get; set; }
        public decimal TOTAL_PEDI { get; set; }
        public string TIPO_ASIEN { get; set; }
        public string MOTIVO { get; set; }
        public string HORA { get; set; }
        public string COD_CLASIF { get; set; }
        public int ID_ASIENTO_MODELO_GV { get; set; }
        public int TAL_PE_ORI { get; set; }
        public string NRO_PE_ORI { get; set; }
        public DateTime FECHA_INGRESO { get; set; }
        public string HORA_INGRESO { get; set; }
        public string USUARIO_INGRESO { get; set; }
        public string TERMINAL_INGRESO { get; set; }
        public DateTime FECHA_ULTIMA_MODIFICACION { get; set; }
        public string HORA_ULTIMA_MODIFICACION { get; set; }
        public string USUA_ULTIMA_MODIFICACION { get; set; }
        public string TERM_ULTIMA_MODIFICACION { get; set; }
        public int ID_DIRECCION_ENTREGA { get; set; }
        public bool ES_PEDIDO_WEB { get; set; }
        public int WEB_ORDER_ID { get; set; }
        public DateTime FECHA_O_COMP { get; set; }
        public string ACTIVIDAD_COMPROBANTE_AFIP { get; set; }
        public int ID_ACTIVIDAD_EMPRESA_AFIP { get; set; }
        public int TIPO_DOCUMENTO_PAGADOR { get; set; }
        public string NUMERO_DOCUMENTO_PAGADOR { get; set; }
        public string USUARIO_TIENDA { get; set; }
        public string TIENDA { get; set; }
        public string ORDER_ID_TIENDA { get; set; }
        public string NRO_OC_COMP { get; set; }
        public string TIENDA_QUE_VENDE { get; set; }
        public decimal TOTAL_DESC_TIENDA { get; set; }
        public decimal PORCEN_DESC_TIENDA { get; set; }
        public string USUARIO_TIENDA_VENDEDOR { get; set; }
        public int ID_NEXO_PEDIDOS_ORDEN { get; set; }
        public int ID_GVA01 { get; set; }
        public int ID_GVA10 { get; set; }
        public int ID_GVA14 { get; set; }
        public int ID_GVA23 { get; set; }
        public int ID_GVA24 { get; set; }
        public int ID_GVA43_TALON_PED { get; set; }
        public int ID_GVA81 { get; set; }
        public int ID_SUCURSAL { get; set; }
        public string METODO_EXPORTACION { get; set; }
        public int NRO_SUCURSAL_DESTINO_PEDIDO { get; set; }
        public long ROW_VERSION { get; set; }
        public int ID_MODELO_PEDIDO { get; set; }

        #endregion

        #region Constructor

        public GVA21()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("CONFIG\\GVA21.XML");

            CultureInfo culture = SQLH.Cultura();

            FILLER = ds.Tables[0].Rows[0]["FILLER"].ToString();
            APRUEBA = ds.Tables[0].Rows[0]["APRUEBA"].ToString();
            CIRCUITO = int.Parse(ds.Tables[0].Rows[0]["CIRCUITO"].ToString());
            COD_CLIENT = ds.Tables[0].Rows[0]["COD_CLIENT"].ToString();
            COD_SUCURS = ds.Tables[0].Rows[0]["COD_SUCURS"].ToString();
            COD_TRANSP = ds.Tables[0].Rows[0]["COD_TRANSP"].ToString();
            COD_VENDED = ds.Tables[0].Rows[0]["COD_VENDED"].ToString();
            COMENTARIO = ds.Tables[0].Rows[0]["COMENTARIO"].ToString();
            COMP_STK = ds.Tables[0].Rows[0]["COMP_STK"].ToString() == "1" ? true : false;
            COND_VTA = int.Parse(ds.Tables[0].Rows[0]["COND_VTA"].ToString());
            COTIZ = decimal.Parse(ds.Tables[0].Rows[0]["COTIZ"].ToString(), culture);
            ESTADO = int.Parse(ds.Tables[0].Rows[0]["ESTADO"].ToString());
            EXPORTADO = ds.Tables[0].Rows[0]["EXPORTADO"].ToString() == "1" ? true : false;
            FECHA_APRU = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_APRU"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            FECHA_ENTR = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_ENTR"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            FECHA_PEDI = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_PEDI"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            HORA_APRUE = ds.Tables[0].Rows[0]["HORA_APRUE"].ToString();
            ID_EXTERNO = ds.Tables[0].Rows[0]["ID_EXTERNO"].ToString();
            LEYENDA_1 = ds.Tables[0].Rows[0]["LEYENDA_1"].ToString();
            LEYENDA_2 = ds.Tables[0].Rows[0]["LEYENDA_2"].ToString();
            LEYENDA_3 = ds.Tables[0].Rows[0]["LEYENDA_3"].ToString();
            LEYENDA_4 = ds.Tables[0].Rows[0]["LEYENDA_4"].ToString();
            LEYENDA_5 = ds.Tables[0].Rows[0]["LEYENDA_5"].ToString();
            MON_CTE = ds.Tables[0].Rows[0]["MON_CTE"].ToString() == "1" ? true : false;
            N_LISTA = int.Parse(ds.Tables[0].Rows[0]["N_LISTA"].ToString());
            N_REMITO = ds.Tables[0].Rows[0]["N_REMITO"].ToString();
            NRO_PEDIDO = ds.Tables[0].Rows[0]["NRO_PEDIDO"].ToString();
            NRO_SUCURS = int.Parse(ds.Tables[0].Rows[0]["NRO_SUCURS"].ToString());
            ORIGEN = ds.Tables[0].Rows[0]["ORIGEN"].ToString();
            PORC_DESC = decimal.Parse(ds.Tables[0].Rows[0]["PORC_DESC"].ToString(), culture);
            REVISO_FAC = ds.Tables[0].Rows[0]["REVISO_FAC"].ToString();
            REVISO_PRE = ds.Tables[0].Rows[0]["REVISO_PRE"].ToString();
            REVISO_STK = ds.Tables[0].Rows[0]["REVISO_STK"].ToString();
            TALONARIO = int.Parse(ds.Tables[0].Rows[0]["TALONARIO"].ToString());
            TALON_PED = int.Parse(ds.Tables[0].Rows[0]["TALON_PED"].ToString());
            TOTAL_PEDI = decimal.Parse(ds.Tables[0].Rows[0]["TOTAL_PEDI"].ToString(), culture);
            TIPO_ASIEN = ds.Tables[0].Rows[0]["TIPO_ASIEN"].ToString();
            MOTIVO = ds.Tables[0].Rows[0]["MOTIVO"].ToString();
            HORA = ds.Tables[0].Rows[0]["HORA"].ToString();
            COD_CLASIF = ds.Tables[0].Rows[0]["COD_CLASIF"].ToString();
            ID_ASIENTO_MODELO_GV = int.Parse(ds.Tables[0].Rows[0]["ID_ASIENTO_MODELO_GV"].ToString());
            TAL_PE_ORI = int.Parse(ds.Tables[0].Rows[0]["TAL_PE_ORI"].ToString());
            NRO_PE_ORI = ds.Tables[0].Rows[0]["NRO_PE_ORI"].ToString();
            FECHA_INGRESO = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_INGRESO"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            HORA_INGRESO = ds.Tables[0].Rows[0]["HORA_INGRESO"].ToString();
            USUARIO_INGRESO = ds.Tables[0].Rows[0]["USUARIO_INGRESO"].ToString();
            TERMINAL_INGRESO = ds.Tables[0].Rows[0]["TERMINAL_INGRESO"].ToString();
            FECHA_ULTIMA_MODIFICACION = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_ULTIMA_MODIFICACION"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            HORA_ULTIMA_MODIFICACION = ds.Tables[0].Rows[0]["HORA_ULTIMA_MODIFICACION"].ToString();
            USUA_ULTIMA_MODIFICACION = ds.Tables[0].Rows[0]["USUA_ULTIMA_MODIFICACION"].ToString();
            TERM_ULTIMA_MODIFICACION = ds.Tables[0].Rows[0]["TERM_ULTIMA_MODIFICACION"].ToString();
            ID_DIRECCION_ENTREGA = int.Parse(ds.Tables[0].Rows[0]["ID_DIRECCION_ENTREGA"].ToString());
            ES_PEDIDO_WEB = ds.Tables[0].Rows[0]["ES_PEDIDO_WEB"].ToString() == "1" ? true : false;
            WEB_ORDER_ID = int.Parse(ds.Tables[0].Rows[0]["WEB_ORDER_ID"].ToString());
            FECHA_O_COMP = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_O_COMP"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ACTIVIDAD_COMPROBANTE_AFIP = ds.Tables[0].Rows[0]["ACTIVIDAD_COMPROBANTE_AFIP"].ToString();
            ID_ACTIVIDAD_EMPRESA_AFIP = int.Parse(ds.Tables[0].Rows[0]["ID_ACTIVIDAD_EMPRESA_AFIP"].ToString());
            TIPO_DOCUMENTO_PAGADOR = int.Parse(ds.Tables[0].Rows[0]["TIPO_DOCUMENTO_PAGADOR"].ToString());
            NUMERO_DOCUMENTO_PAGADOR = ds.Tables[0].Rows[0]["NUMERO_DOCUMENTO_PAGADOR"].ToString();
            USUARIO_TIENDA = ds.Tables[0].Rows[0]["USUARIO_TIENDA"].ToString();
            TIENDA = ds.Tables[0].Rows[0]["TIENDA"].ToString();
            ORDER_ID_TIENDA = ds.Tables[0].Rows[0]["ORDER_ID_TIENDA"].ToString();
            NRO_OC_COMP = ds.Tables[0].Rows[0]["NRO_OC_COMP"].ToString();
            TIENDA_QUE_VENDE = ds.Tables[0].Rows[0]["TIENDA_QUE_VENDE"].ToString();
            TOTAL_DESC_TIENDA = decimal.Parse(ds.Tables[0].Rows[0]["TOTAL_DESC_TIENDA"].ToString(), culture);
            PORCEN_DESC_TIENDA = decimal.Parse(ds.Tables[0].Rows[0]["PORCEN_DESC_TIENDA"].ToString(), culture);
            USUARIO_TIENDA_VENDEDOR = ds.Tables[0].Rows[0]["USUARIO_TIENDA_VENDEDOR"].ToString();
            ID_NEXO_PEDIDOS_ORDEN = int.Parse(ds.Tables[0].Rows[0]["ID_NEXO_PEDIDOS_ORDEN"].ToString());
            ID_GVA01 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA01"].ToString());
            ID_GVA10 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA10"].ToString());
            ID_GVA14 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA14"].ToString());
            ID_GVA23 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA23"].ToString());
            ID_GVA24 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA24"].ToString());
            ID_GVA43_TALON_PED = int.Parse(ds.Tables[0].Rows[0]["ID_GVA43_TALON_PED"].ToString());
            ID_GVA81 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA81"].ToString());
            ID_SUCURSAL = int.Parse(ds.Tables[0].Rows[0]["ID_SUCURSAL"].ToString());
            METODO_EXPORTACION = ds.Tables[0].Rows[0]["METODO_EXPORTACION"].ToString();
            NRO_SUCURSAL_DESTINO_PEDIDO = int.Parse(ds.Tables[0].Rows[0]["NRO_SUCURSAL_DESTINO_PEDIDO"].ToString());
            ID_MODELO_PEDIDO = int.Parse(ds.Tables[0].Rows[0]["ID_MODELO_PEDIDO"].ToString());
        }

        #endregion

        #region Methods
        public string Insert()
        {
            string sql = @"INSERT INTO GVA21 (
FILLER
,APRUEBA
,CIRCUITO
,COD_CLIENT
,COD_SUCURS
,COD_TRANSP
,COD_VENDED
,COMENTARIO
,COMP_STK
,COND_VTA
,COTIZ
,ESTADO
,EXPORTADO
,FECHA_APRU
,FECHA_ENTR
,FECHA_PEDI
,HORA_APRUE
,ID_EXTERNO
,LEYENDA_1
,LEYENDA_2
,LEYENDA_3
,LEYENDA_4
,LEYENDA_5
,MON_CTE
,N_LISTA
,N_REMITO
,NRO_PEDIDO
,NRO_SUCURS
,ORIGEN
,PORC_DESC
,REVISO_FAC
,REVISO_PRE
,REVISO_STK
,TALONARIO
,TALON_PED
,TOTAL_PEDI
,TIPO_ASIEN
,MOTIVO
,HORA
,COD_CLASIF
,ID_ASIENTO_MODELO_GV
,TAL_PE_ORI
,NRO_PE_ORI
,FECHA_INGRESO
,HORA_INGRESO
,USUARIO_INGRESO
,TERMINAL_INGRESO
,FECHA_ULTIMA_MODIFICACION
,HORA_ULTIMA_MODIFICACION
,USUA_ULTIMA_MODIFICACION
,TERM_ULTIMA_MODIFICACION
,ID_DIRECCION_ENTREGA
,ES_PEDIDO_WEB
,WEB_ORDER_ID
,FECHA_O_COMP
,ACTIVIDAD_COMPROBANTE_AFIP
,ID_ACTIVIDAD_EMPRESA_AFIP
,TIPO_DOCUMENTO_PAGADOR
,NUMERO_DOCUMENTO_PAGADOR
,USUARIO_TIENDA
,TIENDA
,ORDER_ID_TIENDA
,NRO_OC_COMP
,TIENDA_QUE_VENDE
,TOTAL_DESC_TIENDA
,PORCEN_DESC_TIENDA
,USUARIO_TIENDA_VENDEDOR
,ID_NEXO_PEDIDOS_ORDEN
,ID_GVA01
,ID_GVA10
,ID_GVA14
,ID_GVA23
,ID_GVA24
,ID_GVA43_TALON_PED
,ID_GVA81
,ID_SUCURSAL
,METODO_EXPORTACION
,NRO_SUCURSAL_DESTINO_PEDIDO
,ID_MODELO_PEDIDO
) VALUES (
" + SQLH.ToString(FILLER) + @"
," + SQLH.ToString(APRUEBA) + @"
," + SQLH.ToInt(CIRCUITO) + @"
," + SQLH.ToString(COD_CLIENT) + @"
," + SQLH.ToString(COD_SUCURS) + @"
," + SQLH.ToString(COD_TRANSP) + @"
," + SQLH.ToString(COD_VENDED) + @"
," + SQLH.ToString(COMENTARIO) + @"
," + SQLH.ToBool(COMP_STK) + @"
," + SQLH.ToInt(COND_VTA) + @"
," + SQLH.ToDecimal(COTIZ) + @"
," + SQLH.ToInt(ESTADO) + @"
," + SQLH.ToBool(EXPORTADO) + @"
," + SQLH.ToDateTime(FECHA_APRU) + @"
," + SQLH.ToDateTime(FECHA_ENTR) + @"
," + SQLH.ToDateTime(FECHA_PEDI) + @"
," + SQLH.ToString(HORA_APRUE) + @"
," + SQLH.ToString(ID_EXTERNO) + @"
," + SQLH.ToString(LEYENDA_1) + @"
," + SQLH.ToString(LEYENDA_2) + @"
," + SQLH.ToString(LEYENDA_3) + @"
," + SQLH.ToString(LEYENDA_4) + @"
," + SQLH.ToString(LEYENDA_5) + @"
," + SQLH.ToBool(MON_CTE) + @"
," + SQLH.ToInt(N_LISTA) + @"
," + SQLH.ToString(N_REMITO) + @"
," + SQLH.ToString(NRO_PEDIDO) + @"
," + SQLH.ToInt(NRO_SUCURS) + @"
," + SQLH.ToString(ORIGEN) + @"
," + SQLH.ToDecimal(PORC_DESC) + @"
," + SQLH.ToString(REVISO_FAC) + @"
," + SQLH.ToString(REVISO_PRE) + @"
," + SQLH.ToString(REVISO_STK) + @"
," + SQLH.ToInt(TALONARIO) + @"
," + SQLH.ToInt(TALON_PED) + @"
," + SQLH.ToDecimal(TOTAL_PEDI) + @"
," + SQLH.ToString(TIPO_ASIEN) + @"
," + SQLH.ToString(MOTIVO) + @"
," + SQLH.ToString(HORA) + @"
," + SQLH.ToString(COD_CLASIF) + @"
," + SQLH.ToInt(ID_ASIENTO_MODELO_GV) + @"
," + SQLH.ToInt(TAL_PE_ORI) + @"
," + SQLH.ToString(NRO_PE_ORI) + @"
," + SQLH.ToDateTime(FECHA_INGRESO) + @"
," + SQLH.ToString(HORA_INGRESO) + @"
," + SQLH.ToString(USUARIO_INGRESO) + @"
," + SQLH.ToString(TERMINAL_INGRESO) + @"
," + SQLH.ToDateTime(FECHA_ULTIMA_MODIFICACION) + @"
," + SQLH.ToString(HORA_ULTIMA_MODIFICACION) + @"
," + SQLH.ToString(USUA_ULTIMA_MODIFICACION) + @"
," + SQLH.ToString(TERM_ULTIMA_MODIFICACION) + @"
," + SQLH.ToInt(ID_DIRECCION_ENTREGA) + @"
," + SQLH.ToBool(ES_PEDIDO_WEB) + @"
," + SQLH.ToInt(WEB_ORDER_ID) + @"
," + SQLH.ToDateTime(FECHA_O_COMP) + @"
," + SQLH.ToString(ACTIVIDAD_COMPROBANTE_AFIP) + @"
," + SQLH.ToInt(ID_ACTIVIDAD_EMPRESA_AFIP) + @"
," + SQLH.ToInt(TIPO_DOCUMENTO_PAGADOR) + @"
," + SQLH.ToString(NUMERO_DOCUMENTO_PAGADOR) + @"
," + SQLH.ToString(USUARIO_TIENDA) + @"
," + SQLH.ToString(TIENDA) + @"
," + SQLH.ToString(ORDER_ID_TIENDA) + @"
," + SQLH.ToString(NRO_OC_COMP) + @"
," + SQLH.ToString(TIENDA_QUE_VENDE) + @"
," + SQLH.ToDecimal(TOTAL_DESC_TIENDA) + @"
," + SQLH.ToDecimal(PORCEN_DESC_TIENDA) + @"
," + SQLH.ToString(USUARIO_TIENDA_VENDEDOR) + @"
," + SQLH.ToInt(ID_NEXO_PEDIDOS_ORDEN) + @"
," + SQLH.TraerId("GVA01", "COND_VTA", COND_VTA.ToString()) + @"
," + SQLH.TraerId("GVA10", "NRO_DE_LIS", N_LISTA.ToString()) + @"
," + SQLH.TraerId("GVA14", "COD_CLIENT", COD_CLIENT) + @"
," + SQLH.TraerId("GVA23", "COD_VENDED", COD_VENDED) + @"
," + SQLH.TraerId("GVA24", "COD_TRANSP", COD_TRANSP) + @"
," + SQLH.TraerId("GVA43", "TALONARIO", TALON_PED.ToString()) + @"
," + SQLH.TraerId("GVA81", "COD_CLASIF", COD_CLASIF) + @"
," + SQLH.ToInt(ID_SUCURSAL) + @"
," + SQLH.ToString(METODO_EXPORTACION) + @"
," + SQLH.ToInt(NRO_SUCURSAL_DESTINO_PEDIDO) + @"
," + SQLH.ToInt(ID_MODELO_PEDIDO) + @"
)
            ";
            return sql;
        }
        #endregion


    }
}
