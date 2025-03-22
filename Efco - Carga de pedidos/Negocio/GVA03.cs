using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efco___Carga_de_pedidos.Negocio
{
    public class GVA03 : Delta3.GVA03
    {
        #region Propiedades
        /*
        public int ID_GVA03 { get; set; }
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
        public decimal CANT_A_DES_EXPORTADA { get; set; }
        public decimal CANT_A_FAC_EXPORTADA { get; set; }
        public decimal CANT_A_DES_2_EXPORTADA { get; set; }
        public decimal CANT_A_FAC_2_EXPORTADA { get; set; }
        */
        public string DESC { get; set; }
        public string DESC_ADIC { get; set; } 
        #endregion

        #region Metodos
        /*
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
,(SELECT ID_MEDIDA_VENTAS FROM STA11 WHERE COD_ARTICU = '" + COD_ARTICU + @"')
," + SQLH.ToInt(ID_MEDIDA_STOCK_2) + @"
,(SELECT ID_MEDIDA_STOCK FROM STA11 WHERE COD_ARTICU = '" + COD_ARTICU + @"')
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
)";
        
            return sql;
        }*/

        public string TOGVA45()
        {
            string sql = @"INSERT INTO [dbo].[GVA45]
           ([FILLER]
           ,[COD_MODELO]
           ,[DESC]
           ,[DESC_ADIC]
           ,[N_COMP]
           ,[N_RENGLON]
           ,[TALONARIO]
           ,[T_COMP])
     VALUES
           (''
           ,''
           ," + SQLH.ToString(DESC) + @"
           ," + SQLH.ToString(DESC_ADIC) + @"
           ," + SQLH.ToString(NRO_PEDIDO) + @"
           ," + SQLH.ToInt(N_RENGLON) + @"
           ," + SQLH.ToInt(TALON_PED) + @"
           ,'PED')";

            return sql;
        }

        public GVA03() : base()
        {

            DESC = "";
            DESC_ADIC = "";
        }

        #endregion

    }
}
