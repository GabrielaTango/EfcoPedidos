using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta3
{
    public class STA20
    {
        public virtual string _archivo
        {
            get
            {
                return "CONFIG\\STA20.XML";
            }
        }

        #region Props
        public int ID_STA20 { get; set; }
        public string FILLER { get; set; }
        public decimal CAN_EQUI_V { get; set; }
        public decimal CANT_DEV { get; set; }
        public decimal CANT_OC { get; set; }
        public decimal CANT_PEND { get; set; }
        public decimal CANT_SCRAP { get; set; }
        public decimal CANTIDAD { get; set; }
        public string COD_ARTICU { get; set; }
        public string COD_DEPOSI { get; set; }
        public string DEPOSI_DDE { get; set; }
        public decimal EQUIVALENC { get; set; }
        public DateTime FECHA_MOV { get; set; }
        public string N_ORDEN_CO { get; set; }
        public int N_RENGL_OC { get; set; }
        public int N_RENGL_S { get; set; }
        public string NCOMP_IN_S { get; set; }
        public decimal PLISTA_REM { get; set; }
        public decimal PPP_EX { get; set; }
        public decimal PPP_LO { get; set; }
        public decimal PRECIO { get; set; }
        public decimal PRECIO_REM { get; set; }
        public string TCOMP_IN_S { get; set; }
        public string TIPO_MOV { get; set; }
        public string COD_CLASIF { get; set; }
        public decimal CANT_FACTU { get; set; }
        public decimal DCTO_FACTU { get; set; }
        public decimal CANT_DEV_2 { get; set; }
        public decimal CANT_PEND_2 { get; set; }
        public decimal CANTIDAD_2 { get; set; }
        public decimal CANT_FACTU_2 { get; set; }
        public int ID_MEDIDA_STOCK_2 { get; set; }
        public int ID_MEDIDA_STOCK { get; set; }
        public int ID_MEDIDA_VENTAS { get; set; }
        public int ID_MEDIDA_COMPRA { get; set; }
        public string UNIDAD_MEDIDA_SELECCIONADA { get; set; }
        public decimal PRECIO_REMITO_VENTAS { get; set; }
        public decimal CANT_OC_2 { get; set; }
        public int RENGL_PADR { get; set; }
        public string COD_ARTICU_KIT { get; set; }
        public bool PROMOCION { get; set; }
        public decimal PRECIO_ADICIONAL_KIT { get; set; }
        public int TALONARIO_OC { get; set; }
        public int ID_STA11 { get; set; }
        public int ID_STA14 { get; set; }
        public long ROW_VERSION { get; set; }
        public string COD_DEPOSI_INGRESO { get; set; }
        #endregion

        #region Methods

        public string Insert()
        {
            string sql = @"
            INSERT INTO STA20 (
FILLER
,CAN_EQUI_V
,CANT_DEV
,CANT_OC
,CANT_PEND
,CANT_SCRAP
,CANTIDAD
,COD_ARTICU
,COD_DEPOSI
,DEPOSI_DDE
,EQUIVALENC
,FECHA_MOV
,N_ORDEN_CO
,N_RENGL_OC
,N_RENGL_S
,NCOMP_IN_S
,PLISTA_REM
,PPP_EX
,PPP_LO
,PRECIO
,PRECIO_REM
,TCOMP_IN_S
,TIPO_MOV
,COD_CLASIF
,CANT_FACTU
,DCTO_FACTU
,CANT_DEV_2
,CANT_PEND_2
,CANTIDAD_2
,CANT_FACTU_2
,ID_MEDIDA_STOCK_2
,ID_MEDIDA_STOCK
,ID_MEDIDA_VENTAS
,ID_MEDIDA_COMPRA
,UNIDAD_MEDIDA_SELECCIONADA
,PRECIO_REMITO_VENTAS
,CANT_OC_2
,RENGL_PADR
,COD_ARTICU_KIT
,PROMOCION
,PRECIO_ADICIONAL_KIT
,TALONARIO_OC
,ID_STA11
,ID_STA14
,COD_DEPOSI_INGRESO
) VALUES (
" + SQLH.ToString(FILLER) + @"
," + SQLH.ToDecimal(CAN_EQUI_V) + @"
," + SQLH.ToDecimal(CANT_DEV) + @"
," + SQLH.ToDecimal(CANT_OC) + @"
," + SQLH.ToDecimal(CANT_PEND) + @"
," + SQLH.ToDecimal(CANT_SCRAP) + @"
," + SQLH.ToDecimal(CANTIDAD) + @"
," + SQLH.ToString(COD_ARTICU) + @"
," + SQLH.ToString(COD_DEPOSI) + @"
," + SQLH.ToString(DEPOSI_DDE) + @"
," + SQLH.ToDecimal(EQUIVALENC) + @"
," + SQLH.ToDateTime(FECHA_MOV) + @"
," + SQLH.ToString(N_ORDEN_CO) + @"
," + SQLH.ToInt(N_RENGL_OC) + @"
," + SQLH.ToInt(N_RENGL_S) + @"
," + SQLH.ToString(NCOMP_IN_S) + @"
," + SQLH.ToDecimal(PLISTA_REM) + @"
," + SQLH.ToDecimal(PPP_EX) + @"
," + SQLH.ToDecimal(PPP_LO) + @"
," + SQLH.ToDecimal(PRECIO) + @"
," + SQLH.ToDecimal(PRECIO_REM) + @"
," + SQLH.ToString(TCOMP_IN_S) + @"
," + SQLH.ToString(TIPO_MOV) + @"
," + SQLH.ToString(COD_CLASIF) + @"
," + SQLH.ToDecimal(CANT_FACTU) + @"
," + SQLH.ToDecimal(DCTO_FACTU) + @"
," + SQLH.ToDecimal(CANT_DEV_2) + @"
," + SQLH.ToDecimal(CANT_PEND_2) + @"
," + SQLH.ToDecimal(CANTIDAD_2) + @"
," + SQLH.ToDecimal(CANT_FACTU_2) + @"
," + SQLH.ToInt(ID_MEDIDA_STOCK_2) + @"
," + SQLH.TraerIdCampo("STA11", "ID_MEDIDA_STOCK", "COD_ARTICU", COD_ARTICU) + @"
," + SQLH.ToInt(ID_MEDIDA_VENTAS) + @"
," + SQLH.ToInt(ID_MEDIDA_COMPRA) + @"
," + SQLH.ToString(UNIDAD_MEDIDA_SELECCIONADA) + @"
," + SQLH.ToDecimal(PRECIO_REMITO_VENTAS) + @"
," + SQLH.ToDecimal(CANT_OC_2) + @"
," + SQLH.ToInt(RENGL_PADR) + @"
," + SQLH.ToString(COD_ARTICU_KIT) + @"
," + SQLH.ToBool(PROMOCION) + @"
," + SQLH.ToDecimal(PRECIO_ADICIONAL_KIT) + @"
," + SQLH.ToInt(TALONARIO_OC) + @"
," + SQLH.TraerId("STA11", "COD_ARTICU", COD_ARTICU) + @"
," + SQLH.ToInt(ID_STA14) + @"
," + SQLH.ToString(COD_DEPOSI_INGRESO) + @"
)
";

            return sql;
        }
        #endregion

        #region Constructor
        public STA20()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(_archivo);

            CultureInfo culture = SQLH.Cultura();

            FILLER = ds.Tables[0].Rows[0]["FILLER"].ToString();
            CAN_EQUI_V = decimal.Parse(ds.Tables[0].Rows[0]["CAN_EQUI_V"].ToString(), culture);
            CANT_DEV = decimal.Parse(ds.Tables[0].Rows[0]["CANT_DEV"].ToString(), culture);
            CANT_OC = decimal.Parse(ds.Tables[0].Rows[0]["CANT_OC"].ToString(), culture);
            CANT_PEND = decimal.Parse(ds.Tables[0].Rows[0]["CANT_PEND"].ToString(), culture);
            CANT_SCRAP = decimal.Parse(ds.Tables[0].Rows[0]["CANT_SCRAP"].ToString(), culture);
            CANTIDAD = decimal.Parse(ds.Tables[0].Rows[0]["CANTIDAD"].ToString(), culture);
            COD_ARTICU = ds.Tables[0].Rows[0]["COD_ARTICU"].ToString();
            COD_DEPOSI = ds.Tables[0].Rows[0]["COD_DEPOSI"].ToString();
            DEPOSI_DDE = ds.Tables[0].Rows[0]["DEPOSI_DDE"].ToString();
            EQUIVALENC = decimal.Parse(ds.Tables[0].Rows[0]["EQUIVALENC"].ToString(), culture);
            FECHA_MOV = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_MOV"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            N_ORDEN_CO = ds.Tables[0].Rows[0]["N_ORDEN_CO"].ToString();
            N_RENGL_OC = int.Parse(ds.Tables[0].Rows[0]["N_RENGL_OC"].ToString());
            N_RENGL_S = int.Parse(ds.Tables[0].Rows[0]["N_RENGL_S"].ToString());
            NCOMP_IN_S = ds.Tables[0].Rows[0]["NCOMP_IN_S"].ToString();
            PLISTA_REM = decimal.Parse(ds.Tables[0].Rows[0]["PLISTA_REM"].ToString(), culture);
            PPP_EX = decimal.Parse(ds.Tables[0].Rows[0]["PPP_EX"].ToString(), culture);
            PPP_LO = decimal.Parse(ds.Tables[0].Rows[0]["PPP_LO"].ToString(), culture);
            PRECIO = decimal.Parse(ds.Tables[0].Rows[0]["PRECIO"].ToString(), culture);
            PRECIO_REM = decimal.Parse(ds.Tables[0].Rows[0]["PRECIO_REM"].ToString(), culture);
            TCOMP_IN_S = ds.Tables[0].Rows[0]["TCOMP_IN_S"].ToString();
            TIPO_MOV = ds.Tables[0].Rows[0]["TIPO_MOV"].ToString();
            COD_CLASIF = ds.Tables[0].Rows[0]["COD_CLASIF"].ToString();
            CANT_FACTU = decimal.Parse(ds.Tables[0].Rows[0]["CANT_FACTU"].ToString(), culture);
            DCTO_FACTU = decimal.Parse(ds.Tables[0].Rows[0]["DCTO_FACTU"].ToString(), culture);
            CANT_DEV_2 = decimal.Parse(ds.Tables[0].Rows[0]["CANT_DEV_2"].ToString(), culture);
            CANT_PEND_2 = decimal.Parse(ds.Tables[0].Rows[0]["CANT_PEND_2"].ToString(), culture);
            CANTIDAD_2 = decimal.Parse(ds.Tables[0].Rows[0]["CANTIDAD_2"].ToString(), culture);
            CANT_FACTU_2 = decimal.Parse(ds.Tables[0].Rows[0]["CANT_FACTU_2"].ToString(), culture);
            ID_MEDIDA_STOCK_2 = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_STOCK_2"].ToString());
            ID_MEDIDA_STOCK = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_STOCK"].ToString());
            ID_MEDIDA_VENTAS = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_VENTAS"].ToString());
            ID_MEDIDA_COMPRA = int.Parse(ds.Tables[0].Rows[0]["ID_MEDIDA_COMPRA"].ToString());
            UNIDAD_MEDIDA_SELECCIONADA = ds.Tables[0].Rows[0]["UNIDAD_MEDIDA_SELECCIONADA"].ToString();
            PRECIO_REMITO_VENTAS = decimal.Parse(ds.Tables[0].Rows[0]["PRECIO_REMITO_VENTAS"].ToString(), culture);
            CANT_OC_2 = decimal.Parse(ds.Tables[0].Rows[0]["CANT_OC_2"].ToString(), culture);
            RENGL_PADR = int.Parse(ds.Tables[0].Rows[0]["RENGL_PADR"].ToString());
            COD_ARTICU_KIT = ds.Tables[0].Rows[0]["COD_ARTICU_KIT"].ToString();
            PROMOCION = ds.Tables[0].Rows[0]["PROMOCION"].ToString() == "1" ? true : false;
            PRECIO_ADICIONAL_KIT = decimal.Parse(ds.Tables[0].Rows[0]["PRECIO_ADICIONAL_KIT"].ToString(), culture);
            TALONARIO_OC = int.Parse(ds.Tables[0].Rows[0]["TALONARIO_OC"].ToString());
            ID_STA11 = int.Parse(ds.Tables[0].Rows[0]["ID_STA11"].ToString());
            ID_STA14 = int.Parse(ds.Tables[0].Rows[0]["ID_STA14"].ToString());
            COD_DEPOSI_INGRESO = ds.Tables[0].Rows[0]["COD_DEPOSI_INGRESO"].ToString();
        }
        #endregion
    }
}
