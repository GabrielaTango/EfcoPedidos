using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta3
{
    public class STA11
    {
        public virtual string _archivo
        {
            get
            {
                return "CONFIG\\STA11.XML";
            }
        }

        #region Constructor
        public STA11()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(_archivo);

            CultureInfo culture = SQLH.Cultura();

            FILLER = ds.Tables[0].Rows[0]["FILLER"].ToString();
            ADJUNTO = ds.Tables[0].Rows[0]["ADJUNTO"].ToString();
            ALI_NO_CAT = int.Parse(ds.Tables[0].Rows[0]["ALI_NO_CAT"].ToString());
            BAJA_STK = ds.Tables[0].Rows[0]["BAJA_STK"].ToString();
            BMP = ds.Tables[0].Rows[0]["BMP"].ToString();
            CL_SIAP_CP = ds.Tables[0].Rows[0]["CL_SIAP_CP"].ToString();
            CL_SIAP_GV = ds.Tables[0].Rows[0]["CL_SIAP_GV"].ToString();
            COD_ACTIVI = int.Parse(ds.Tables[0].Rows[0]["COD_ACTIVI"].ToString());
            COD_ARTICU = ds.Tables[0].Rows[0]["COD_ARTICU"].ToString();
            COD_BARRA = ds.Tables[0].Rows[0]["COD_BARRA"].ToString();
            COD_DEP = ds.Tables[0].Rows[0]["COD_DEP"].ToString();
            COD_IB = int.Parse(ds.Tables[0].Rows[0]["COD_IB"].ToString());
            COD_IB3 = int.Parse(ds.Tables[0].Rows[0]["COD_IB3"].ToString());
            COD_II = int.Parse(ds.Tables[0].Rows[0]["COD_II"].ToString());
            COD_II_CO = int.Parse(ds.Tables[0].Rows[0]["COD_II_CO"].ToString());
            COD_IVA = int.Parse(ds.Tables[0].Rows[0]["COD_IVA"].ToString());
            COD_IVA_CO = int.Parse(ds.Tables[0].Rows[0]["COD_IVA_CO"].ToString());
            COD_S_II = int.Parse(ds.Tables[0].Rows[0]["COD_S_II"].ToString());
            COD_S_II_C = int.Parse(ds.Tables[0].Rows[0]["COD_S_II_C"].ToString());
            COD_S_IVA = int.Parse(ds.Tables[0].Rows[0]["COD_S_IVA"].ToString());
            COD_S_IV_C = int.Parse(ds.Tables[0].Rows[0]["COD_S_IV_C"].ToString());
            COMISION_V = decimal.Parse(ds.Tables[0].Rows[0]["COMISION_V"].ToString(), culture);
            CONSID_TMP = ds.Tables[0].Rows[0]["CONSID_TMP"].ToString() == "1" ? true : false;
            CTA_COMPRA = int.Parse(ds.Tables[0].Rows[0]["CTA_COMPRA"].ToString(), culture);
            CTA_VENTAS = int.Parse(ds.Tables[0].Rows[0]["CTA_VENTAS"].ToString(), culture);
            CTO_COMPRA = ds.Tables[0].Rows[0]["CTO_COMPRA"].ToString();
            CTO_VENTAS = ds.Tables[0].Rows[0]["CTO_VENTAS"].ToString();
            DESC_ADIC = ds.Tables[0].Rows[0]["DESC_ADIC"].ToString();
            DESCRIPCIO = ds.Tables[0].Rows[0]["DESCRIPCIO"].ToString();
            DESCUENTO = decimal.Parse(ds.Tables[0].Rows[0]["DESCUENTO"].ToString(), culture);
            DESTI_ART = ds.Tables[0].Rows[0]["DESTI_ART"].ToString() == "1" ? true : false;
            EQUIVALE_V = decimal.Parse(ds.Tables[0].Rows[0]["EQUIVALE_V"].ToString(), culture);
            ESCALA_1 = ds.Tables[0].Rows[0]["ESCALA_1"].ToString();
            ESCALA_2 = ds.Tables[0].Rows[0]["ESCALA_2"].ToString();
            ESPEC_AUTO = ds.Tables[0].Rows[0]["ESPEC_AUTO"].ToString();
            FACT_IMPOR = ds.Tables[0].Rows[0]["FACT_IMPOR"].ToString() == "1" ? true : false;
            FAVORITO = ds.Tables[0].Rows[0]["FAVORITO"].ToString() == "1" ? true : false;
            FECHA_ALTA = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_ALTA"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            GEN_IB = ds.Tables[0].Rows[0]["GEN_IB"].ToString() == "1" ? true : false;
            GEN_IB3 = ds.Tables[0].Rows[0]["GEN_IB3"].ToString() == "1" ? true : false;
            IMPR_CARTA = ds.Tables[0].Rows[0]["IMPR_CARTA"].ToString() == "1" ? true : false;
            IMPUESTO_I = decimal.Parse(ds.Tables[0].Rows[0]["IMPUESTO_I"].ToString(), culture);
            IMPUEST_IC = decimal.Parse(ds.Tables[0].Rows[0]["IMPUEST_IC"].ToString(), culture);
            MOD_DESCAR = ds.Tables[0].Rows[0]["MOD_DESCAR"].ToString();
            PERC_NO_CA = ds.Tables[0].Rows[0]["PERC_NO_CA"].ToString() == "1" ? true : false;
            PERFIL = ds.Tables[0].Rows[0]["PERFIL"].ToString();
            PORC_DESVI = decimal.Parse(ds.Tables[0].Rows[0]["PORC_DESVI"].ToString(), culture);
            PORC_SCRAP = decimal.Parse(ds.Tables[0].Rows[0]["PORC_SCRAP"].ToString(), culture);
            PORC_UTILI = decimal.Parse(ds.Tables[0].Rows[0]["PORC_UTILI"].ToString(), culture);
            PROMODESDE = DateTime.ParseExact(ds.Tables[0].Rows[0]["PROMODESDE"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            PROMOHASTA = DateTime.ParseExact(ds.Tables[0].Rows[0]["PROMOHASTA"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            PROMO_MENU = ds.Tables[0].Rows[0]["PROMO_MENU"].ToString();
            PTO_PEDIDO = decimal.Parse(ds.Tables[0].Rows[0]["PTO_PEDIDO"].ToString(), culture);
            PUNTAJE = int.Parse(ds.Tables[0].Rows[0]["PUNTAJE"].ToString(), culture);
            RET_RNI = ds.Tables[0].Rows[0]["RET_RNI"].ToString() == "1" ? true : false;
            RET_RNI_CO = int.Parse(ds.Tables[0].Rows[0]["RET_RNI_CO"].ToString());
            SINONIMO = ds.Tables[0].Rows[0]["SINONIMO"].ToString();
            STOCK = ds.Tables[0].Rows[0]["STOCK"].ToString() == "1" ? true : false;
            STOCK_MAXI = decimal.Parse(ds.Tables[0].Rows[0]["STOCK_MAXI"].ToString(), culture);
            STOCK_MINI = decimal.Parse(ds.Tables[0].Rows[0]["STOCK_MINI"].ToString(), culture);
            STOCK_NEG = ds.Tables[0].Rows[0]["STOCK_NEG"].ToString() == "1" ? true : false;
            TIEMPO = ds.Tables[0].Rows[0]["TIEMPO"].ToString();
            TIPO_PROMO = ds.Tables[0].Rows[0]["TIPO_PROMO"].ToString();
            USA_ESC = ds.Tables[0].Rows[0]["USA_ESC"].ToString();
            USA_PARTID = ds.Tables[0].Rows[0]["USA_PARTID"].ToString() == "1" ? true : false;
            USA_SCRAP = ds.Tables[0].Rows[0]["USA_SCRAP"].ToString() == "1" ? true : false;
            USA_SERIE = ds.Tables[0].Rows[0]["USA_SERIE"].ToString() == "1" ? true : false;
            FECHA_MODI = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_MODI"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DISP_MOVIL = ds.Tables[0].Rows[0]["DISP_MOVIL"].ToString();
            RENTA_UM_S = ds.Tables[0].Rows[0]["RENTA_UM_S"].ToString();
            RENTA_UM_V = ds.Tables[0].Rows[0]["RENTA_UM_V"].ToString();
            RENTA_PROD = ds.Tables[0].Rows[0]["RENTA_PROD"].ToString();
            RENTA_EQ_S = decimal.Parse(ds.Tables[0].Rows[0]["RENTA_EQ_S"].ToString(), culture);
            RENTA_EQ_V = decimal.Parse(ds.Tables[0].Rows[0]["RENTA_EQ_V"].ToString(), culture);
            GENERACOT = ds.Tables[0].Rows[0]["GENERACOT"].ToString() == "1" ? true : false;
            USA_CTRPRE = ds.Tables[0].Rows[0]["USA_CTRPRE"].ToString() == "1" ? true : false;
            COD_II_V_2 = int.Parse(ds.Tables[0].Rows[0]["COD_II_V_2"].ToString());
            COD_SII_V2 = int.Parse(ds.Tables[0].Rows[0]["COD_SII_V2"].ToString());
            IMP_II_V_2 = decimal.Parse(ds.Tables[0].Rows[0]["IMP_II_V_2"].ToString(), culture);
            BASE = ds.Tables[0].Rows[0]["BASE"].ToString();
            VALOR1 = ds.Tables[0].Rows[0]["VALOR1"].ToString();
            VALOR2 = ds.Tables[0].Rows[0]["VALOR2"].ToString();
            MET_DES_PA = ds.Tables[0].Rows[0]["MET_DES_PA"].ToString();
            ORD_DES_PA = ds.Tables[0].Rows[0]["ORD_DES_PA"].ToString();
            AFIP_UM_S = int.Parse(ds.Tables[0].Rows[0]["AFIP_UM_S"].ToString());
            AFIP_UM_V = int.Parse(ds.Tables[0].Rows[0]["AFIP_UM_V"].ToString());
            AFIP_EQ_S = decimal.Parse(ds.Tables[0].Rows[0]["AFIP_EQ_S"].ToString(), culture);
            AFIP_EQ_V = decimal.Parse(ds.Tables[0].Rows[0]["AFIP_EQ_V"].ToString(), culture);
            FERIADOS = ds.Tables[0].Rows[0]["FERIADOS"].ToString() == "1" ? true : false;
            LUNES = ds.Tables[0].Rows[0]["LUNES"].ToString() == "1" ? true : false;
            MARTES = ds.Tables[0].Rows[0]["MARTES"].ToString() == "1" ? true : false;
            MIERCOLES = ds.Tables[0].Rows[0]["MIERCOLES"].ToString() == "1" ? true : false;
            JUEVES = ds.Tables[0].Rows[0]["JUEVES"].ToString() == "1" ? true : false;
            VIERNES = ds.Tables[0].Rows[0]["VIERNES"].ToString() == "1" ? true : false;
            SABADO = ds.Tables[0].Rows[0]["SABADO"].ToString() == "1" ? true : false; 
            DOMINGO = ds.Tables[0].Rows[0]["DOMINGO"].ToString() == "1" ? true : false;
            COD_PLANTI = ds.Tables[0].Rows[0]["COD_PLANTI"].ToString();
            AFECTA_AF = ds.Tables[0].Rows[0]["AFECTA_AF"].ToString() == "1" ? true : false;
            COD_TIPOB = ds.Tables[0].Rows[0]["COD_TIPOB"].ToString();
            REMITIBLE = ds.Tables[0].Rows[0]["REMITIBLE"].ToString();
            CARGA_RAP = ds.Tables[0].Rows[0]["CARGA_RAP"].ToString();
            COD_STA11 = ds.Tables[0].Rows[0]["COD_STA11"].ToString();
            AFIP_UMEX_V = int.Parse(ds.Tables[0].Rows[0]["AFIP_UMEX_V"].ToString());
            AFIP_UMEX_S = int.Parse(ds.Tables[0].Rows[0]["AFIP_UMEX_S"].ToString());
            LLEVA_DOBLE_UNIDAD_MEDIDA = ds.Tables[0].Rows[0]["LLEVA_DOBLE_UNIDAD_MEDIDA"].ToString() == "1" ? true : false;
            EQUIVALENCIA_STOCK_2 = decimal.Parse(ds.Tables[0].Rows[0]["EQUIVALENCIA_STOCK_2"].ToString(), culture);
            ID_MEDIDA_STOCK_2 = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_STOCK_2"].ToString());
            ID_MEDIDA_STOCK = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_STOCK"].ToString());
            ID_MEDIDA_VENTAS = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_VENTAS"].ToString());
            EQUIVALENCIA_MEDIDA_PESO = decimal.Parse(ds.Tables[0].Rows[0]["EQUIVALENCIA_MEDIDA_PESO"].ToString(), culture);
            EQUIVALENCIA_MEDIDA_VOLUMEN = decimal.Parse(ds.Tables[0].Rows[0]["EQUIVALENCIA_MEDIDA_VOLUMEN"].ToString(), culture);
            FECHA_INGRESO = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_INGRESO"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            USUARIO = ds.Tables[0].Rows[0]["USUARIO"].ToString();
            TERMINAL = ds.Tables[0].Rows[0]["TERMINAL"].ToString();
            FECHA_ULTIMA_MODIFICACION = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_ULTIMA_MODIFICACION"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            USUA_ULTIMA_MODIFICACION = ds.Tables[0].Rows[0]["USUA_ULTIMA_MODIFICACION"].ToString();
            TERM_ULTIMA_MODIFICACION = ds.Tables[0].Rows[0]["TERM_ULTIMA_MODIFICACION"].ToString();
            OBSERVACIONES = ds.Tables[0].Rows[0]["OBSERVACIONES"].ToString();
            DESCARGA_NEGATIVO_STOCK = ds.Tables[0].Rows[0]["DESCARGA_NEGATIVO_STOCK"].ToString() == "1" ? true : false;
            DESCARGA_NEGATIVO_VENTAS = ds.Tables[0].Rows[0]["DESCARGA_NEGATIVO_VENTAS"].ToString() == "1" ? true : false;
            ID_TYPS = int.Parse(ds.Tables[0].Rows[0]["ID_TYPS"].ToString());
            ADMITE_VENTA_FRACCIONADA = ds.Tables[0].Rows[0]["ADMITE_VENTA_FRACCIONADA"].ToString() == "1" ? true : false; ;
            ADMITE_INVITACION = ds.Tables[0].Rows[0]["ADMITE_INVITACION"].ToString() == "1" ? true : false;
            TIPO_RECARGO_VENTA_FRACCIONADA = ds.Tables[0].Rows[0]["TIPO_RECARGO_VENTA_FRACCIONADA"].ToString();
            PORC_RECARGO_VENTA_FRACCIONADA = decimal.Parse(ds.Tables[0].Rows[0]["PORC_RECARGO_VENTA_FRACCIONADA"].ToString(), culture);
            IMP_RECARGO_VENTA_FRACCIONADA = decimal.Parse(ds.Tables[0].Rows[0]["IMP_RECARGO_VENTA_FRACCIONADA"].ToString(), culture);
            CIGARRILLO = ds.Tables[0].Rows[0]["CIGARRILLO"].ToString();
            RELACION_UNIDADES_STOCK = ds.Tables[0].Rows[0]["RELACION_UNIDADES_STOCK"].ToString();
            DESVIO_CONTROL_UNIDADES_STOCK = decimal.Parse(ds.Tables[0].Rows[0]["DESVIO_CONTROL_UNIDADES_STOCK"].ToString(), culture);
            DESVIO_CIERRE_PEDIDOS = decimal.Parse(ds.Tables[0].Rows[0]["DESVIO_CIERRE_PEDIDOS"].ToString(), culture);
            ID_MEDIDA_CONTROL_STOCK = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_CONTROL_STOCK"].ToString());
            USA_CONTROL_UNIDADES_STOCK = ds.Tables[0].Rows[0]["USA_CONTROL_UNIDADES_STOCK"].ToString() == "1" ? true : false;
            PRODUCTO_TERMINADO_COT = ds.Tables[0].Rows[0]["PRODUCTO_TERMINADO_COT"].ToString();
            COD_NCM = ds.Tables[0].Rows[0]["COD_NCM"].ToString();
            EDITA_PRECIO = ds.Tables[0].Rows[0]["EDITA_PRECIO"].ToString();
            SERIE_DESC_ADICIONAL_1 = ds.Tables[0].Rows[0]["SERIE_DESC_ADICIONAL_1"].ToString();
            SERIE_DESC_ADICIONAL_2 = ds.Tables[0].Rows[0]["SERIE_DESC_ADICIONAL_2"].ToString();
            EGRESO_MODIFICA_PARTIDA_PROPUESTA = ds.Tables[0].Rows[0]["EGRESO_MODIFICA_PARTIDA_PROPUESTA"].ToString();
            CALCULA_CM = ds.Tables[0].Rows[0]["CALCULA_CM"].ToString() == "1" ? true : false;
            ORIGEN_PARA_CM = ds.Tables[0].Rows[0]["ORIGEN_PARA_CM"].ToString();
            PUBLICA_WEB = ds.Tables[0].Rows[0]["PUBLICA_WEB"].ToString() == "1" ? true : false;
            PUBLICA_WEB_PEDIDO = ds.Tables[0].Rows[0]["PUBLICA_WEB_PEDIDO"].ToString();
            SINCRONIZA_WEB_PEDIDO = ds.Tables[0].Rows[0]["SINCRONIZA_WEB_PEDIDO"].ToString();
            DESCRIPCION_VARIABLE = ds.Tables[0].Rows[0]["DESCRIPCION_VARIABLE"].ToString() == "1" ? true : false;
            ID_ACTIVIDAD_DGI = int.Parse(ds.Tables[0].Rows[0]["ID_ACTIVIDAD_DGI"].ToString());
            DESCRIPCION_LARGA = ds.Tables[0].Rows[0]["DESCRIPCION_LARGA"].ToString();
            ID_TRA_CLASE_ARTICULO = int.Parse(ds.Tables[0].Rows[0]["ID_TRA_CLASE_ARTICULO"].ToString());
            ID_CODIGO_ITEM_TURISMO = int.Parse(ds.Tables[0].Rows[0]["ID_CODIGO_ITEM_TURISMO"].ToString());
            ID_TIPO_UNIDAD_TURISMO = int.Parse(ds.Tables[0].Rows[0]["ID_TIPO_UNIDAD_TURISMO"].ToString());
            ID_TIPO_ITEM_AFIP = int.Parse(ds.Tables[0].Rows[0]["ID_TIPO_ITEM_AFIP"].ToString());
            SEPARADOR_DEFECTO = ds.Tables[0].Rows[0]["SEPARADOR_DEFECTO"].ToString();
            SOLICITA_PRECIO = ds.Tables[0].Rows[0]["SOLICITA_PRECIO"].ToString();
            DESCRIPCION_RECETA = ds.Tables[0].Rows[0]["DESCRIPCION_RECETA"].ToString();
            REV_PEND = ds.Tables[0].Rows[0]["REV_PEND"].ToString() == "1" ? true : false;
            ID_STA32_ESCALA_1 = int.Parse(ds.Tables[0].Rows[0]["ID_STA32_ESCALA_1"].ToString());
            ID_STA32_ESCALA_2 = int.Parse(ds.Tables[0].Rows[0]["ID_STA32_ESCALA_2"].ToString());
            ID_STA33_VALOR1 = int.Parse(ds.Tables[0].Rows[0]["ID_STA33_VALOR1"].ToString());
            ID_STA33_VALOR2 = int.Parse(ds.Tables[0].Rows[0]["ID_STA33_VALOR2"].ToString());
            //Row Version
            //Campos Adicionales
            ID_STA11_BASE = int.Parse(ds.Tables[0].Rows[0]["ID_STA11_BASE"].ToString());
            ID_GVA22 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA22"].ToString());
            ID_TIPO_BIEN = int.Parse(ds.Tables[0].Rows[0]["ID_TIPO_BIEN"].ToString());
            ID_STA115 = int.Parse(ds.Tables[0].Rows[0]["ID_STA115"].ToString());
            ID_GVA41_COD_IVA = int.Parse(ds.Tables[0].Rows[0]["ID_GVA41_COD_IVA"].ToString());
            ID_GVA41_COD_S_IVA = int.Parse(ds.Tables[0].Rows[0]["ID_GVA41_COD_S_IVA"].ToString());
            ID_GVA41_COD_II = int.Parse(ds.Tables[0].Rows[0]["ID_GVA41_COD_II"].ToString());
            ID_GVA41_COD_S_II = int.Parse(ds.Tables[0].Rows[0]["ID_GVA41_COD_S_II"].ToString());
            ID_GVA41_COD_II_V_2 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA41_COD_II_V_2"].ToString());
            ID_GVA41_COD_SII_V2 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA41_COD_SII_V2"].ToString());
            ID_GVA41_COD_IB = int.Parse(ds.Tables[0].Rows[0]["ID_GVA41_COD_IB"].ToString());
            ID_GVA41_COD_IB3 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA41_COD_IB3"].ToString());
            ID_GVA41_ALI_NO_CAT = int.Parse(ds.Tables[0].Rows[0]["ID_GVA41_ALI_NO_CAT"].ToString());
            ID_CPA14_COD_IVA_CO = int.Parse(ds.Tables[0].Rows[0]["ID_CPA14_COD_IVA_CO"].ToString());
            ID_CPA14_COD_S_IV_C = int.Parse(ds.Tables[0].Rows[0]["ID_CPA14_COD_S_IV_C"].ToString());
            ID_CPA14_COD_II_CO = int.Parse(ds.Tables[0].Rows[0]["ID_CPA14_COD_II_CO"].ToString());
            ID_CPA14_COD_S_II_C = int.Parse(ds.Tables[0].Rows[0]["ID_CPA14_COD_S_II_C"].ToString());
            ID_GVA125 = int.Parse(ds.Tables[0].Rows[0]["ID_GVA125"].ToString());
            ID_UNIDAD_MEDIDA_AFIP_UM_S = int.Parse(ds.Tables[0].Rows[0]["ID_UNIDAD_MEDIDA_AFIP_UM_S"].ToString());
            ID_UNIDAD_MEDIDA_AFIP_UM_V = int.Parse(ds.Tables[0].Rows[0]["ID_UNIDAD_MEDIDA_AFIP_UM_V"].ToString());
            ID_UNIDAD_MEDIDA_AFIP_UMEX_S = int.Parse(ds.Tables[0].Rows[0]["ID_UNIDAD_MEDIDA_AFIP_UMEX_S"].ToString());
            ID_UNIDAD_MEDIDA_AFIP_UMEX_V = int.Parse(ds.Tables[0].Rows[0]["ID_UNIDAD_MEDIDA_AFIP_UMEX_V"].ToString());
            ID_CLASIFICACION_SIAP_CL_SIAP_GV = int.Parse(ds.Tables[0].Rows[0]["ID_CLASIFICACION_SIAP_CL_SIAP_GV"].ToString());
            ID_CLASIFICACION_SIAP_CL_SIAP_CP = int.Parse(ds.Tables[0].Rows[0]["ID_CLASIFICACION_SIAP_CL_SIAP_CP"].ToString());
            FECHA_MODI_PORC_UTILIDAD = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_MODI_PORC_UTILIDAD"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ID_MODELO_PERCEPCION_VENTAS = int.Parse(ds.Tables[0].Rows[0]["ID_MODELO_PERCEPCION_VENTAS"].ToString());
            ID_CPA01_HABITUAL = int.Parse(ds.Tables[0].Rows[0]["ID_CPA01_HABITUAL"].ToString());
            SINCRONIZA_NEXO_TIENDAS = ds.Tables[0].Rows[0]["SINCRONIZA_NEXO_TIENDAS"].ToString() == "1" ? true : false;
        }
        #endregion

        #region Props
        public string FILLER { get; set; }
        public string ADJUNTO { get; set; }
        public int ALI_NO_CAT { get; set; }
        public string BAJA_STK { get; set; }
        public string BMP { get; set; }
        public string CL_SIAP_CP { get; set; }
        public string CL_SIAP_GV { get; set; }
        public int COD_ACTIVI { get; set; }
        public string COD_ARTICU { get; set; }
        public string COD_BARRA { get; set; }
        public string COD_DEP { get; set; }
        public int COD_IB { get; set; }
        public int COD_IB3 { get; set; }
        public int COD_II { get; set; }
        public int COD_II_CO { get; set; }
        public int COD_IVA { get; set; }
        public int COD_IVA_CO { get; set; }
        public int COD_S_II { get; set; }
        public int COD_S_II_C { get; set; }
        public int COD_S_IVA { get; set; }
        public int COD_S_IV_C { get; set; }
        public decimal COMISION_V { get; set; }
        public bool CONSID_TMP { get; set; }
        public int CTA_COMPRA { get; set; }
        public int CTA_VENTAS { get; set; }
        public string CTO_COMPRA { get; set; }
        public string CTO_VENTAS { get; set; }
        public string DESC_ADIC { get; set; }
        public string DESCRIPCIO { get; set; }
        public decimal DESCUENTO { get; set; }
        public bool DESTI_ART { get; set; }
        public decimal EQUIVALE_V { get; set; }
        public string ESCALA_1 { get; set; }
        public string ESCALA_2 { get; set; }
        public string ESPEC_AUTO { get; set; }
        public bool FACT_IMPOR { get; set; }
        public bool FAVORITO { get; set; }
        public DateTime FECHA_ALTA { get; set; }
        public bool GEN_IB { get; set; }
        public bool GEN_IB3 { get; set; }
        public bool IMPR_CARTA { get; set; }
        public decimal IMPUESTO_I { get; set; }
        public decimal IMPUEST_IC { get; set; }
        public string MOD_DESCAR { get; set; }
        public bool PERC_NO_CA { get; set; }
        public string PERFIL { get; set; }
        public decimal PORC_DESVI { get; set; }
        public decimal PORC_SCRAP { get; set; }
        public decimal PORC_UTILI { get; set; }
        public DateTime PROMODESDE { get; set; }
        public DateTime PROMOHASTA { get; set; }
        public string PROMO_MENU { get; set; }
        public decimal PTO_PEDIDO { get; set; }
        public int PUNTAJE { get; set; }
        public bool RET_RNI { get; set; }
        public int RET_RNI_CO { get; set; }
        public string SINONIMO { get; set; }
        public bool STOCK { get; set; }
        public decimal STOCK_MAXI { get; set; }
        public decimal STOCK_MINI { get; set; }
        public bool STOCK_NEG { get; set; }
        public string TIEMPO { get; set; }
        public string TIPO_PROMO { get; set; }
        public string USA_ESC { get; set; }
        public bool USA_PARTID { get; set; }
        public bool USA_SCRAP { get; set; }
        public bool USA_SERIE { get; set; }
        public DateTime FECHA_MODI { get; set; }
        public string DISP_MOVIL { get; set; }
        public string RENTA_UM_S { get; set; }
        public string RENTA_UM_V { get; set; }
        public string RENTA_PROD { get; set; }
        public decimal RENTA_EQ_S { get; set; }
        public decimal RENTA_EQ_V { get; set; }
        public bool GENERACOT { get; set; }
        public bool USA_CTRPRE { get; set; }
        public int COD_II_V_2 { get; set; }
        public int COD_SII_V2 { get; set; }
        public decimal IMP_II_V_2 { get; set; }
        public string BASE { get; set; }
        public string VALOR1 { get; set; }
        public string VALOR2 { get; set; }
        public string MET_DES_PA { get; set; }
        public string ORD_DES_PA { get; set; }
        public int AFIP_UM_S { get; set; }
        public int AFIP_UM_V { get; set; }
        public decimal AFIP_EQ_S { get; set; }
        public decimal AFIP_EQ_V { get; set; }
        public bool FERIADOS { get; set; }
        public bool LUNES { get; set; }
        public bool MARTES { get; set; }
        public bool MIERCOLES { get; set; }
        public bool JUEVES { get; set; }
        public bool VIERNES { get; set; }
        public bool SABADO { get; set; }
        public bool DOMINGO { get; set; }
        public string COD_PLANTI { get; set; }
        public bool AFECTA_AF { get; set; }
        public string COD_TIPOB { get; set; }
        public string REMITIBLE { get; set; }
        public string CARGA_RAP { get; set; }
        public string COD_STA11 { get; set; }
        public int AFIP_UMEX_V { get; set; }
        public int AFIP_UMEX_S { get; set; }
        public bool LLEVA_DOBLE_UNIDAD_MEDIDA { get; set; }
        public decimal EQUIVALENCIA_STOCK_2 { get; set; }
        public int ID_MEDIDA_STOCK_2 { get; set; }
        public int ID_MEDIDA_STOCK { get; set; }
        public int ID_MEDIDA_VENTAS { get; set; }
        public decimal EQUIVALENCIA_MEDIDA_PESO { get; set; }
        public decimal EQUIVALENCIA_MEDIDA_VOLUMEN { get; set; }
        public DateTime FECHA_INGRESO { get; set; }
        public string USUARIO { get; set; }
        public string TERMINAL { get; set; }
        public DateTime FECHA_ULTIMA_MODIFICACION { get; set; }
        public string USUA_ULTIMA_MODIFICACION { get; set; }
        public string TERM_ULTIMA_MODIFICACION { get; set; }
        public string OBSERVACIONES { get; set; }
        public int ID_STA11 { get; set; }
        public bool DESCARGA_NEGATIVO_STOCK { get; set; }
        public bool DESCARGA_NEGATIVO_VENTAS { get; set; }
        public int ID_TYPS { get; set; }
        public bool ADMITE_VENTA_FRACCIONADA { get; set; }
        public bool ADMITE_INVITACION { get; set; }
        public string TIPO_RECARGO_VENTA_FRACCIONADA { get; set; }
        public decimal PORC_RECARGO_VENTA_FRACCIONADA { get; set; }
        public decimal IMP_RECARGO_VENTA_FRACCIONADA { get; set; }
        public string CIGARRILLO { get; set; }
        public string RELACION_UNIDADES_STOCK { get; set; }
        public decimal DESVIO_CONTROL_UNIDADES_STOCK { get; set; }
        public decimal DESVIO_CIERRE_PEDIDOS { get; set; }
        public int ID_MEDIDA_CONTROL_STOCK { get; set; }
        public bool USA_CONTROL_UNIDADES_STOCK { get; set; }
        public string PRODUCTO_TERMINADO_COT { get; set; }
        public string COD_NCM { get; set; }
        public string EDITA_PRECIO { get; set; }
        public string SERIE_DESC_ADICIONAL_1 { get; set; }
        public string SERIE_DESC_ADICIONAL_2 { get; set; }
        public string EGRESO_MODIFICA_PARTIDA_PROPUESTA { get; set; }
        public bool CALCULA_CM { get; set; }
        public string ORIGEN_PARA_CM { get; set; }
        public bool PUBLICA_WEB { get; set; }
        public string PUBLICA_WEB_PEDIDO { get; set; }
        public string SINCRONIZA_WEB_PEDIDO { get; set; }
        public bool DESCRIPCION_VARIABLE { get; set; }
        public int ID_ACTIVIDAD_DGI { get; set; }
        public string DESCRIPCION_LARGA { get; set; }
        public int ID_TRA_CLASE_ARTICULO { get; set; }
        public int ID_CODIGO_ITEM_TURISMO { get; set; }
        public int ID_TIPO_UNIDAD_TURISMO { get; set; }
        public int ID_TIPO_ITEM_AFIP { get; set; }
        public string SEPARADOR_DEFECTO { get; set; }
        public string SOLICITA_PRECIO { get; set; }
        public string DESCRIPCION_RECETA { get; set; }
        public bool REV_PEND { get; set; }
        public int ID_STA32_ESCALA_1 { get; set; }
        public int ID_STA32_ESCALA_2 { get; set; }
        public int ID_STA33_VALOR1 { get; set; }
        public int ID_STA33_VALOR2 { get; set; }
        public long ROW_VERSION { get; set; }
        
        //Campos Adicionales
        public int ID_STA11_BASE { get; set; }
        public int ID_GVA22 { get; set; }
        public int ID_TIPO_BIEN { get; set; }
        public int ID_STA115 { get; set; }
        public int ID_GVA41_COD_IVA { get; set; }
        public int ID_GVA41_COD_S_IVA { get; set; }
        public int ID_GVA41_COD_II { get; set; }
        public int ID_GVA41_COD_S_II { get; set; }
        public int ID_GVA41_COD_II_V_2 { get; set; }
        public int ID_GVA41_COD_SII_V2 { get; set; }
        public int ID_GVA41_COD_IB { get; set; }
        public int ID_GVA41_COD_IB3 { get; set; }
        public int ID_GVA41_ALI_NO_CAT { get; set; }
        public int ID_CPA14_COD_IVA_CO { get; set; }
        public int ID_CPA14_COD_S_IV_C { get; set; }
        public int ID_CPA14_COD_II_CO { get; set; }
        public int ID_CPA14_COD_S_II_C { get; set; }
        public int ID_GVA125 { get; set; }
        public int ID_UNIDAD_MEDIDA_AFIP_UM_S { get; set; }
        public int ID_UNIDAD_MEDIDA_AFIP_UM_V { get; set; }
        public int ID_UNIDAD_MEDIDA_AFIP_UMEX_S { get; set; }
        public int ID_UNIDAD_MEDIDA_AFIP_UMEX_V { get; set; }
        public int ID_CLASIFICACION_SIAP_CL_SIAP_GV { get; set; }
        public int ID_CLASIFICACION_SIAP_CL_SIAP_CP { get; set; }
        public DateTime FECHA_MODI_PORC_UTILIDAD { get; set; }
        public int ID_MODELO_PERCEPCION_VENTAS { get; set; }
        public int ID_CPA01_HABITUAL { get; set; }
        public bool SINCRONIZA_NEXO_TIENDAS { get; set; }
        #endregion

        #region Methods
        public string Insert()
        {
            string sql = @"INSERT INTO STA11 (
FILLER
,ADJUNTO
,ALI_NO_CAT
,BAJA_STK
,BMP
,CL_SIAP_CP
,CL_SIAP_GV
,COD_ACTIVI
,COD_ARTICU
,COD_BARRA
,COD_DEP
,COD_IB
,COD_IB3
,COD_II
,COD_II_CO
,COD_IVA
,COD_IVA_CO
,COD_S_II
,COD_S_II_C
,COD_S_IVA
,COD_S_IV_C
,COMISION_V
,CONSID_TMP
,CTA_COMPRA
,CTA_VENTAS
,CTO_COMPRA
,CTO_VENTAS
,DESC_ADIC
,DESCRIPCIO
,DESCUENTO
,DESTI_ART
,EQUIVALE_V
,ESCALA_1
,ESCALA_2
,ESPEC_AUTO
,FACT_IMPOR
,FAVORITO
,FECHA_ALTA
,GEN_IB
,GEN_IB3
,IMPR_CARTA
,IMPUESTO_I
,IMPUEST_IC
,MOD_DESCAR
,PERC_NO_CA
,PERFIL
,PORC_DESVI
,PORC_SCRAP
,PORC_UTILI
,PROMODESDE
,PROMOHASTA
,PROMO_MENU
,PTO_PEDIDO
,PUNTAJE
,RET_RNI
,RET_RNI_CO
,SINONIMO
,STOCK
,STOCK_MAXI
,STOCK_MINI
,STOCK_NEG
,TIEMPO
,TIPO_PROMO
,USA_ESC
,USA_PARTID
,USA_SCRAP
,USA_SERIE
,FECHA_MODI
,DISP_MOVIL
,RENTA_UM_S
,RENTA_UM_V
,RENTA_PROD
,RENTA_EQ_S
,RENTA_EQ_V
,GENERACOT
,USA_CTRPRE
,COD_II_V_2
,COD_SII_V2
,IMP_II_V_2
,BASE
,VALOR1
,VALOR2
,MET_DES_PA
,ORD_DES_PA
,AFIP_UM_S
,AFIP_UM_V
,AFIP_EQ_S
,AFIP_EQ_V
,FERIADOS
,LUNES
,MARTES
,MIERCOLES
,JUEVES
,VIERNES
,SABADO
,DOMINGO
,COD_PLANTI
,AFECTA_AF
,COD_TIPOB
,REMITIBLE
,CARGA_RAP
,COD_STA11
,AFIP_UMEX_V
,AFIP_UMEX_S
,LLEVA_DOBLE_UNIDAD_MEDIDA
,EQUIVALENCIA_STOCK_2
,ID_MEDIDA_STOCK_2
,ID_MEDIDA_STOCK
,ID_MEDIDA_VENTAS
,EQUIVALENCIA_MEDIDA_PESO
,EQUIVALENCIA_MEDIDA_VOLUMEN
,FECHA_INGRESO
,USUARIO
,TERMINAL
,FECHA_ULTIMA_MODIFICACION
,USUA_ULTIMA_MODIFICACION
,TERM_ULTIMA_MODIFICACION
,OBSERVACIONES
,ID_STA11
,DESCARGA_NEGATIVO_STOCK
,DESCARGA_NEGATIVO_VENTAS
,ID_TYPS
,ADMITE_VENTA_FRACCIONADA
,ADMITE_INVITACION
,TIPO_RECARGO_VENTA_FRACCIONADA
,PORC_RECARGO_VENTA_FRACCIONADA
,IMP_RECARGO_VENTA_FRACCIONADA
,CIGARRILLO
,RELACION_UNIDADES_STOCK
,DESVIO_CONTROL_UNIDADES_STOCK
,DESVIO_CIERRE_PEDIDOS
,ID_MEDIDA_CONTROL_STOCK
,USA_CONTROL_UNIDADES_STOCK
,PRODUCTO_TERMINADO_COT
,COD_NCM
,EDITA_PRECIO
,SERIE_DESC_ADICIONAL_1
,SERIE_DESC_ADICIONAL_2
,EGRESO_MODIFICA_PARTIDA_PROPUESTA
,CALCULA_CM
,ORIGEN_PARA_CM
,PUBLICA_WEB
,PUBLICA_WEB_PEDIDO
,SINCRONIZA_WEB_PEDIDO
,DESCRIPCION_VARIABLE
,ID_ACTIVIDAD_DGI
,DESCRIPCION_LARGA
,ID_TRA_CLASE_ARTICULO
,ID_CODIGO_ITEM_TURISMO
,ID_TIPO_UNIDAD_TURISMO
,ID_TIPO_ITEM_AFIP
,SEPARADOR_DEFECTO
,SOLICITA_PRECIO
,DESCRIPCION_RECETA
,REV_PEND
,ID_STA32_ESCALA_1
,ID_STA32_ESCALA_2
,ID_STA33_VALOR1
,ID_STA33_VALOR2
,CAMPOS_ADICIONALES
,ID_STA11_BASE
,ID_GVA22
,ID_TIPO_BIEN
,ID_STA115
,ID_GVA41_COD_IVA
,ID_GVA41_COD_S_IVA
,ID_GVA41_COD_II
,ID_GVA41_COD_S_II
,ID_GVA41_COD_II_V_2
,ID_GVA41_COD_SII_V2
,ID_GVA41_COD_IB
,ID_GVA41_COD_IB3
,ID_GVA41_ALI_NO_CAT
,ID_CPA14_COD_IVA_CO
,ID_CPA14_COD_S_IV_C
,ID_CPA14_COD_II_CO
,ID_CPA14_COD_S_II_C
,ID_GVA125
,ID_UNIDAD_MEDIDA_AFIP_UM_S
,ID_UNIDAD_MEDIDA_AFIP_UM_V
,ID_UNIDAD_MEDIDA_AFIP_UMEX_S
,ID_UNIDAD_MEDIDA_AFIP_UMEX_V
,ID_CLASIFICACION_SIAP_CL_SIAP_GV
,ID_CLASIFICACION_SIAP_CL_SIAP_CP
,FECHA_MODI_PORC_UTILIDAD
,ID_MODELO_PERCEPCION_VENTAS
,ID_CPA01_HABITUAL
,SINCRONIZA_NEXO_TIENDAS
) VALUES (
" + SQLH.ToString(FILLER) + @"
," + SQLH.ToString(ADJUNTO) + @"
," + SQLH.ToInt(ALI_NO_CAT) + @"
," + SQLH.ToString(BAJA_STK) + @"
," + SQLH.ToString(BMP) + @"
," + SQLH.ToString(CL_SIAP_CP) + @"
," + SQLH.ToString(CL_SIAP_GV) + @"
," + SQLH.ToInt(COD_ACTIVI) + @"
," + SQLH.ToString(COD_ARTICU) + @"
," + SQLH.ToString(COD_BARRA) + @"
," + SQLH.ToString(COD_DEP) + @"
," + SQLH.ToInt(COD_IB) + @"
," + SQLH.ToInt(COD_IB3) + @"
," + SQLH.ToInt(COD_II) + @"
," + SQLH.ToInt(COD_II_CO) + @"
," + SQLH.ToInt(COD_IVA) + @"
," + SQLH.ToInt(COD_IVA_CO) + @"
," + SQLH.ToInt(COD_S_II) + @"
," + SQLH.ToInt(COD_S_II_C) + @"
," + SQLH.ToInt(COD_S_IVA) + @"
," + SQLH.ToInt(COD_S_IV_C) + @"
," + SQLH.ToDecimal(COMISION_V) + @"
," + SQLH.ToBool(CONSID_TMP) + @"
," + SQLH.ToInt(CTA_COMPRA) + @"
," + SQLH.ToInt(CTA_VENTAS) + @"
," + SQLH.ToString(CTO_COMPRA) + @"
," + SQLH.ToString(CTO_VENTAS) + @"
," + SQLH.ToString(DESC_ADIC) + @"
," + SQLH.ToString(DESCRIPCIO) + @"
," + SQLH.ToDecimal(DESCUENTO) + @"
," + SQLH.ToBool(DESTI_ART) + @"
," + SQLH.ToDecimal(EQUIVALE_V) + @"
," + SQLH.ToString(ESCALA_1) + @"
," + SQLH.ToString(ESCALA_2) + @"
," + SQLH.ToString(ESPEC_AUTO) + @"
," + SQLH.ToBool(FACT_IMPOR) + @"
," + SQLH.ToBool(FAVORITO) + @"
," + SQLH.ToDateTime(FECHA_ALTA) + @"
," + SQLH.ToBool(GEN_IB) + @"
," + SQLH.ToBool(GEN_IB3) + @"
," + SQLH.ToBool(IMPR_CARTA) + @"
," + SQLH.ToDecimal(IMPUESTO_I) + @"
," + SQLH.ToDecimal(IMPUEST_IC) + @"
," + SQLH.ToString(MOD_DESCAR) + @"
," + SQLH.ToBool(PERC_NO_CA) + @"
," + SQLH.ToString(PERFIL) + @"
," + SQLH.ToDecimal(PORC_DESVI) + @"
," + SQLH.ToDecimal(PORC_SCRAP) + @"
," + SQLH.ToDecimal(PORC_UTILI) + @"
," + SQLH.ToDateTime(PROMODESDE) + @"
," + SQLH.ToDateTime(PROMOHASTA) + @"
," + SQLH.ToString(PROMO_MENU) + @"
," + SQLH.ToDecimal(PTO_PEDIDO) + @"
," + SQLH.ToInt(PUNTAJE) + @"
," + SQLH.ToBool(RET_RNI) + @"
," + SQLH.ToInt(RET_RNI_CO) + @"
," + SQLH.ToString(SINONIMO) + @"
," + SQLH.ToBool(STOCK) + @"
," + SQLH.ToDecimal(STOCK_MAXI) + @"
," + SQLH.ToDecimal(STOCK_MINI) + @"
," + SQLH.ToBool(STOCK_NEG) + @"
," + SQLH.ToString(TIEMPO) + @"
," + SQLH.ToString(TIPO_PROMO) + @"
," + SQLH.ToString(USA_ESC) + @"
," + SQLH.ToBool(USA_PARTID) + @"
," + SQLH.ToBool(USA_SCRAP) + @"
," + SQLH.ToBool(USA_SERIE) + @"
," + SQLH.ToDateTime(FECHA_MODI) + @"
," + SQLH.ToString(DISP_MOVIL) + @"
," + SQLH.ToString(RENTA_UM_S) + @"
," + SQLH.ToString(RENTA_UM_V) + @"
," + SQLH.ToString(RENTA_PROD) + @"
," + SQLH.ToDecimal(RENTA_EQ_S) + @"
," + SQLH.ToDecimal(RENTA_EQ_V) + @"
," + SQLH.ToBool(GENERACOT) + @"
," + SQLH.ToBool(USA_CTRPRE) + @"
," + SQLH.ToInt(COD_II_V_2) + @"
," + SQLH.ToInt(COD_SII_V2) + @"
," + SQLH.ToDecimal(IMP_II_V_2) + @"
," + SQLH.ToString(BASE) + @"
," + SQLH.ToString(VALOR1) + @"
," + SQLH.ToString(VALOR2) + @"
," + SQLH.ToString(MET_DES_PA) + @"
," + SQLH.ToString(ORD_DES_PA) + @"
," + SQLH.ToInt(AFIP_UM_S) + @"
," + SQLH.ToInt(AFIP_UM_V) + @"
," + SQLH.ToDecimal(AFIP_EQ_S) + @"
," + SQLH.ToDecimal(AFIP_EQ_V) + @"
," + SQLH.ToBool(FERIADOS) + @"
," + SQLH.ToBool(LUNES) + @"
," + SQLH.ToBool(MARTES) + @"
," + SQLH.ToBool(MIERCOLES) + @"
," + SQLH.ToBool(JUEVES) + @"
," + SQLH.ToBool(VIERNES) + @"
," + SQLH.ToBool(SABADO) + @"
," + SQLH.ToBool(DOMINGO) + @"
," + SQLH.ToString(COD_PLANTI) + @"
," + SQLH.ToBool(AFECTA_AF) + @"
," + SQLH.ToString(COD_TIPOB) + @"
," + SQLH.ToString(REMITIBLE) + @"
," + SQLH.ToString(CARGA_RAP) + @"
," + SQLH.ToString(COD_STA11) + @"
," + SQLH.ToInt(AFIP_UMEX_V) + @"
," + SQLH.ToInt(AFIP_UMEX_S) + @"
," + SQLH.ToBool(LLEVA_DOBLE_UNIDAD_MEDIDA) + @"
," + SQLH.ToDecimal(EQUIVALENCIA_STOCK_2) + @"
," + SQLH.ToInt(ID_MEDIDA_STOCK_2) + @"
," + SQLH.ToInt(ID_MEDIDA_STOCK) + @"
," + SQLH.ToInt(ID_MEDIDA_VENTAS) + @"
," + SQLH.ToDecimal(EQUIVALENCIA_MEDIDA_PESO) + @"
," + SQLH.ToDecimal(EQUIVALENCIA_MEDIDA_VOLUMEN) + @"
," + SQLH.ToDateTime(FECHA_INGRESO) + @"
," + SQLH.ToString(USUARIO) + @"
," + SQLH.ToString(TERMINAL) + @"
," + SQLH.ToDateTime(FECHA_ULTIMA_MODIFICACION) + @"
," + SQLH.ToString(USUA_ULTIMA_MODIFICACION) + @"
," + SQLH.ToString(TERM_ULTIMA_MODIFICACION) + @"
," + SQLH.ToString(OBSERVACIONES) + @"
,NEXT VALUE FOR SEQUENCE_STA11
," + SQLH.ToBool(DESCARGA_NEGATIVO_STOCK) + @"
," + SQLH.ToBool(DESCARGA_NEGATIVO_VENTAS) + @"
," + SQLH.ToInt(ID_TYPS) + @"
," + SQLH.ToBool(ADMITE_VENTA_FRACCIONADA) + @"
," + SQLH.ToBool(ADMITE_INVITACION) + @"
," + SQLH.ToString(TIPO_RECARGO_VENTA_FRACCIONADA) + @"
," + SQLH.ToDecimal(PORC_RECARGO_VENTA_FRACCIONADA) + @"
," + SQLH.ToDecimal(IMP_RECARGO_VENTA_FRACCIONADA) + @"
," + SQLH.ToString(CIGARRILLO) + @"
," + SQLH.ToString(RELACION_UNIDADES_STOCK) + @"
," + SQLH.ToDecimal(DESVIO_CONTROL_UNIDADES_STOCK) + @"
," + SQLH.ToDecimal(DESVIO_CIERRE_PEDIDOS) + @"
," + SQLH.ToInt(ID_MEDIDA_CONTROL_STOCK) + @"
," + SQLH.ToBool(USA_CONTROL_UNIDADES_STOCK) + @"
," + SQLH.ToString(PRODUCTO_TERMINADO_COT) + @"
," + SQLH.ToString(COD_NCM) + @"
," + SQLH.ToString(EDITA_PRECIO) + @"
," + SQLH.ToString(SERIE_DESC_ADICIONAL_1) + @"
," + SQLH.ToString(SERIE_DESC_ADICIONAL_2) + @"
," + SQLH.ToString(EGRESO_MODIFICA_PARTIDA_PROPUESTA) + @"
," + SQLH.ToBool(CALCULA_CM) + @"
," + SQLH.ToString(ORIGEN_PARA_CM) + @"
," + SQLH.ToBool(PUBLICA_WEB) + @"
," + SQLH.ToString(PUBLICA_WEB_PEDIDO) + @"
," + SQLH.ToString(SINCRONIZA_WEB_PEDIDO) + @"
," + SQLH.ToBool(DESCRIPCION_VARIABLE) + @"
," + SQLH.ToInt(ID_ACTIVIDAD_DGI) + @"
," + SQLH.ToString(DESCRIPCION_LARGA) + @"
," + SQLH.ToInt(ID_TRA_CLASE_ARTICULO) + @"
," + SQLH.ToInt(ID_CODIGO_ITEM_TURISMO) + @"
," + SQLH.ToInt(ID_TIPO_UNIDAD_TURISMO) + @"
," + SQLH.ToInt(ID_TIPO_ITEM_AFIP) + @"
," + SQLH.ToString(SEPARADOR_DEFECTO) + @"
," + SQLH.ToString(SOLICITA_PRECIO) + @"
," + SQLH.ToString(DESCRIPCION_RECETA) + @"
," + SQLH.ToBool(REV_PEND) + @"
," + SQLH.ToInt(ID_STA32_ESCALA_1) + @"
," + SQLH.ToInt(ID_STA32_ESCALA_2) + @"
," + SQLH.ToInt(ID_STA33_VALOR1) + @"
," + SQLH.ToInt(ID_STA33_VALOR2) + @"
,'<CAMPOS_ADICIONALES />'
," + SQLH.ToInt(ID_STA11_BASE) + @"
," + SQLH.ToInt(ID_GVA22) + @"
," + SQLH.ToInt(ID_TIPO_BIEN) + @"
," + SQLH.ToInt(ID_STA115) + @"
," + SQLH.ToInt(ID_GVA41_COD_IVA) + @"
," + SQLH.ToInt(ID_GVA41_COD_S_IVA) + @"
," + SQLH.ToInt(ID_GVA41_COD_II) + @"
," + SQLH.ToInt(ID_GVA41_COD_S_II) + @"
," + SQLH.ToInt(ID_GVA41_COD_II_V_2) + @"
," + SQLH.ToInt(ID_GVA41_COD_SII_V2) + @"
," + SQLH.ToInt(ID_GVA41_COD_IB) + @"
," + SQLH.ToInt(ID_GVA41_COD_IB3) + @"
," + SQLH.ToInt(ID_GVA41_ALI_NO_CAT) + @"
," + SQLH.ToInt(ID_CPA14_COD_IVA_CO) + @"
," + SQLH.ToInt(ID_CPA14_COD_S_IV_C) + @"
," + SQLH.ToInt(ID_CPA14_COD_II_CO) + @"
," + SQLH.ToInt(ID_CPA14_COD_S_II_C) + @"
," + SQLH.ToInt(ID_GVA125) + @"
," + SQLH.ToInt(ID_UNIDAD_MEDIDA_AFIP_UM_S) + @"
," + SQLH.ToInt(ID_UNIDAD_MEDIDA_AFIP_UM_V) + @"
," + SQLH.ToInt(ID_UNIDAD_MEDIDA_AFIP_UMEX_S) + @"
," + SQLH.ToInt(ID_UNIDAD_MEDIDA_AFIP_UMEX_V) + @"
," + SQLH.ToInt(ID_CLASIFICACION_SIAP_CL_SIAP_GV) + @"
," + SQLH.ToInt(ID_CLASIFICACION_SIAP_CL_SIAP_CP) + @"
," + SQLH.ToDateTime(FECHA_MODI_PORC_UTILIDAD) + @"
," + SQLH.ToInt(ID_MODELO_PERCEPCION_VENTAS) + @"
," + SQLH.ToInt(ID_CPA01_HABITUAL) + @"
," + SQLH.ToBool(SINCRONIZA_NEXO_TIENDAS) + @"
)";

            return sql;
        }
        #endregion
    }
}
