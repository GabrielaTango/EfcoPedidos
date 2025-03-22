using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delta3
{
    public class STA14
    {

        public virtual string _archivo
        {
            get
            {
                return "CONFIG\\STA14.XML";
            }
        }

        #region Props
        public int ID_STA14 { get; set; }
        public string FILLER { get; set; }
        public string COD_PRO_CL { get; set; }
        public decimal COTIZ { get; set; }
        public string ESTADO_MOV { get; set; }
        public bool EXPORTADO { get; set; }
        public bool EXP_STOCK { get; set; }
        public DateTime FECHA_ANU { get; set; }
        public DateTime FECHA_MOV { get; set; }
        public string HORA { get; set; }
        public int LISTA_REM { get; set; }
        public decimal LOTE { get; set; }
        public decimal LOTE_ANU { get; set; }
        public bool MON_CTE { get; set; }
        public string MOTIVO_REM { get; set; }
        public string N_COMP { get; set; }
        public string N_REMITO { get; set; }
        public string NCOMP_IN_S { get; set; }
        public string NCOMP_ORIG { get; set; }
        public int NRO_SUCURS { get; set; }
        public string OBSERVACIO { get; set; }
        public int SUC_ORIG { get; set; }
        public string T_COMP { get; set; }
        public int TALONARIO { get; set; }
        public string TCOMP_IN_S { get; set; }
        public string TCOMP_ORIG { get; set; }
        public string USUARIO { get; set; }
        public string COD_TRANSP { get; set; }
        public string HORA_COMP { get; set; }
        public decimal ID_A_RENTA { get; set; }
        public bool DOC_ELECTR { get; set; }
        public string COD_CLASIF { get; set; }
        public string AUDIT_IMP { get; set; }
        public decimal IMP_IVA { get; set; }
        public decimal IMP_OTIMP { get; set; }
        public decimal IMPORTE_BO { get; set; }
        public decimal IMPORTE_TO { get; set; }
        public string DIFERENCIA { get; set; }
        public int SUC_DESTIN { get; set; }
        public string T_DOC_DTE { get; set; }
        public string LEYENDA1 { get; set; }
        public string LEYENDA2 { get; set; }
        public string LEYENDA3 { get; set; }
        public string LEYENDA4 { get; set; }
        public string LEYENDA5 { get; set; }
        public decimal DCTO_CLIEN { get; set; }
        public string T_INT_ORI { get; set; }
        public string N_INT_ORI { get; set; }
        public DateTime FECHA_INGRESO { get; set; }
        public string HORA_INGRESO { get; set; }
        public string USUARIO_INGRESO { get; set; }
        public string TERMINAL_INGRESO { get; set; }
        public decimal IMPORTE_TOTAL_CON_IMPUESTOS { get; set; }
        public decimal CANTIDAD_KILOS { get; set; }
        public int ID_DIRECCION_ENTREGA { get; set; }
        public decimal IMPORTE_GRAVADO { get; set; }
        public decimal IMPORTE_EXENTO { get; set; }
        public int ID_STA13 { get; set; }
        public int NRO_SUCURSAL_DESTINO_REMITO { get; set; }
        public long ROW_VERSION { get; set; }
        #endregion

        #region Methods

        public string Insert()
        {
            string sql = @"
            INSERT INTO STA14 (
FILLER
,COD_PRO_CL
,COTIZ
,ESTADO_MOV
,EXPORTADO
,EXP_STOCK
,FECHA_ANU
,FECHA_MOV
,HORA
,LISTA_REM
,LOTE
,LOTE_ANU
,MON_CTE
,MOTIVO_REM
,N_COMP
,N_REMITO
,NCOMP_IN_S
,NCOMP_ORIG
,NRO_SUCURS
,OBSERVACIO
,SUC_ORIG
,T_COMP
,TALONARIO
,TCOMP_IN_S
,TCOMP_ORIG
,USUARIO
,COD_TRANSP
,HORA_COMP
,ID_A_RENTA
,DOC_ELECTR
,COD_CLASIF
,AUDIT_IMP
,IMP_IVA
,IMP_OTIMP
,IMPORTE_BO
,IMPORTE_TO
,DIFERENCIA
,SUC_DESTIN
,T_DOC_DTE
,LEYENDA1
,LEYENDA2
,LEYENDA3
,LEYENDA4
,LEYENDA5
,DCTO_CLIEN
,T_INT_ORI
,N_INT_ORI
,FECHA_INGRESO
,HORA_INGRESO
,USUARIO_INGRESO
,TERMINAL_INGRESO
,IMPORTE_TOTAL_CON_IMPUESTOS
,CANTIDAD_KILOS
,ID_DIRECCION_ENTREGA
,IMPORTE_GRAVADO
,IMPORTE_EXENTO
,ID_STA13
,NRO_SUCURSAL_DESTINO_REMITO
) VALUES (
" + SQLH.ToString(FILLER) + @"
," + SQLH.ToString(COD_PRO_CL) + @"
," + SQLH.ToDecimal(COTIZ) + @"
," + SQLH.ToString(ESTADO_MOV) + @"
," + SQLH.ToBool(EXPORTADO) + @"
," + SQLH.ToBool(EXP_STOCK) + @"
," + SQLH.ToDateTime(FECHA_ANU) + @"
," + SQLH.ToDateTime(FECHA_MOV) + @"
," + SQLH.ToString(HORA) + @"
," + SQLH.ToInt(LISTA_REM) + @"
," + SQLH.ToDecimal(LOTE) + @"
," + SQLH.ToDecimal(LOTE_ANU) + @"
," + SQLH.ToBool(MON_CTE) + @"
," + SQLH.ToString(MOTIVO_REM) + @"
," + SQLH.ToString(N_COMP) + @"
," + SQLH.ToString(N_REMITO) + @"
," + SQLH.ToString(NCOMP_IN_S) + @"
," + SQLH.ToString(NCOMP_ORIG) + @"
," + SQLH.ToInt(NRO_SUCURS) + @"
," + SQLH.ToString(OBSERVACIO) + @"
," + SQLH.ToInt(SUC_ORIG) + @"
," + SQLH.ToString(T_COMP) + @"
," + SQLH.ToInt(TALONARIO) + @"
," + SQLH.ToString(TCOMP_IN_S) + @"
," + SQLH.ToString(TCOMP_ORIG) + @"
," + SQLH.ToString(USUARIO) + @"
," + SQLH.ToString(COD_TRANSP) + @"
," + SQLH.ToString(HORA_COMP) + @"
," + SQLH.ToDecimal(ID_A_RENTA) + @"
," + SQLH.ToBool(DOC_ELECTR) + @"
," + SQLH.ToString(COD_CLASIF) + @"
," + SQLH.ToString(AUDIT_IMP) + @"
," + SQLH.ToDecimal(IMP_IVA) + @"
," + SQLH.ToDecimal(IMP_OTIMP) + @"
," + SQLH.ToDecimal(IMPORTE_BO) + @"
," + SQLH.ToDecimal(IMPORTE_TO) + @"
," + SQLH.ToString(DIFERENCIA) + @"
," + SQLH.ToInt(SUC_DESTIN) + @"
," + SQLH.ToString(T_DOC_DTE) + @"
," + SQLH.ToString(LEYENDA1) + @"
," + SQLH.ToString(LEYENDA2) + @"
," + SQLH.ToString(LEYENDA3) + @"
," + SQLH.ToString(LEYENDA4) + @"
," + SQLH.ToString(LEYENDA5) + @"
," + SQLH.ToDecimal(DCTO_CLIEN) + @"
," + SQLH.ToString(T_INT_ORI) + @"
," + SQLH.ToString(N_INT_ORI) + @"
," + SQLH.ToDateTime(FECHA_INGRESO) + @"
," + SQLH.ToString(HORA_INGRESO) + @"
," + SQLH.ToString(USUARIO_INGRESO) + @"
," + SQLH.ToString(TERMINAL_INGRESO) + @"
," + SQLH.ToDecimal(IMPORTE_TOTAL_CON_IMPUESTOS) + @"
," + SQLH.ToDecimal(CANTIDAD_KILOS) + @"
," + SQLH.ToInt(ID_DIRECCION_ENTREGA) + @"
," + SQLH.ToDecimal(IMPORTE_GRAVADO) + @"
," + SQLH.ToDecimal(IMPORTE_EXENTO) + @"
," + SQLH.TraerId("STA13","T_COMP",T_COMP) + @"
," + SQLH.ToInt(NRO_SUCURSAL_DESTINO_REMITO) + @"
)
";

            return sql;
        }
        #endregion


        #region Constructor
        public STA14()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(_archivo);

            CultureInfo culture = SQLH.Cultura();


            FILLER = ds.Tables[0].Rows[0]["FILLER"].ToString();
            COD_PRO_CL = ds.Tables[0].Rows[0]["COD_PRO_CL"].ToString();
            COTIZ = decimal.Parse(ds.Tables[0].Rows[0]["COTIZ"].ToString(), culture);
            ESTADO_MOV = ds.Tables[0].Rows[0]["ESTADO_MOV"].ToString();
            EXPORTADO = ds.Tables[0].Rows[0]["EXPORTADO"].ToString() == "1" ? true : false;
            EXP_STOCK = ds.Tables[0].Rows[0]["EXP_STOCK"].ToString() == "1" ? true : false;             
            FECHA_ANU = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_ANU"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            FECHA_MOV = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_MOV"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            HORA = ds.Tables[0].Rows[0]["HORA"].ToString();
            LISTA_REM = int.Parse(ds.Tables[0].Rows[0]["LISTA_REM"].ToString());
            LOTE = decimal.Parse(ds.Tables[0].Rows[0]["LOTE"].ToString(), culture);
            LOTE_ANU = decimal.Parse(ds.Tables[0].Rows[0]["LOTE_ANU"].ToString(), culture);
            MON_CTE = ds.Tables[0].Rows[0]["MON_CTE"].ToString() == "1" ? true : false;
            MOTIVO_REM = ds.Tables[0].Rows[0]["MOTIVO_REM"].ToString();
            N_COMP = ds.Tables[0].Rows[0]["N_COMP"].ToString();
            N_REMITO = ds.Tables[0].Rows[0]["N_REMITO"].ToString();
            NCOMP_IN_S = ds.Tables[0].Rows[0]["NCOMP_IN_S"].ToString();
            NCOMP_ORIG = ds.Tables[0].Rows[0]["NCOMP_ORIG"].ToString();
            NRO_SUCURS = int.Parse(ds.Tables[0].Rows[0]["NRO_SUCURS"].ToString());
            OBSERVACIO = ds.Tables[0].Rows[0]["OBSERVACIO"].ToString();
            SUC_ORIG = int.Parse(ds.Tables[0].Rows[0]["SUC_ORIG"].ToString());
            T_COMP = ds.Tables[0].Rows[0]["T_COMP"].ToString();
            TALONARIO = int.Parse(ds.Tables[0].Rows[0]["TALONARIO"].ToString());
            TCOMP_IN_S = ds.Tables[0].Rows[0]["TCOMP_IN_S"].ToString();
            TCOMP_ORIG = ds.Tables[0].Rows[0]["TCOMP_ORIG"].ToString();
            USUARIO = ds.Tables[0].Rows[0]["USUARIO"].ToString();
            COD_TRANSP = ds.Tables[0].Rows[0]["COD_TRANSP"].ToString();
            HORA_COMP = ds.Tables[0].Rows[0]["HORA_COMP"].ToString();
            ID_A_RENTA = decimal.Parse(ds.Tables[0].Rows[0]["ID_A_RENTA"].ToString(), culture);
            DOC_ELECTR = ds.Tables[0].Rows[0]["DOC_ELECTR"].ToString() == "1" ? true : false;
            COD_CLASIF = ds.Tables[0].Rows[0]["COD_CLASIF"].ToString();
            AUDIT_IMP = ds.Tables[0].Rows[0]["AUDIT_IMP"].ToString();
            IMP_IVA = decimal.Parse(ds.Tables[0].Rows[0]["IMP_IVA"].ToString(), culture);
            IMP_OTIMP = decimal.Parse(ds.Tables[0].Rows[0]["IMP_OTIMP"].ToString(), culture);
            IMPORTE_BO = decimal.Parse(ds.Tables[0].Rows[0]["IMPORTE_BO"].ToString(), culture);
            IMPORTE_TO = decimal.Parse(ds.Tables[0].Rows[0]["IMPORTE_TO"].ToString(), culture);
            DIFERENCIA = ds.Tables[0].Rows[0]["DIFERENCIA"].ToString();
            SUC_DESTIN = int.Parse(ds.Tables[0].Rows[0]["SUC_DESTIN"].ToString());
            T_DOC_DTE = ds.Tables[0].Rows[0]["T_DOC_DTE"].ToString();
            LEYENDA1 = ds.Tables[0].Rows[0]["LEYENDA1"].ToString();
            LEYENDA2 = ds.Tables[0].Rows[0]["LEYENDA2"].ToString();
            LEYENDA3 = ds.Tables[0].Rows[0]["LEYENDA3"].ToString();
            LEYENDA4 = ds.Tables[0].Rows[0]["LEYENDA4"].ToString();
            LEYENDA5 = ds.Tables[0].Rows[0]["LEYENDA5"].ToString();
            DCTO_CLIEN = decimal.Parse(ds.Tables[0].Rows[0]["DCTO_CLIEN"].ToString(), culture);
            T_INT_ORI = ds.Tables[0].Rows[0]["T_INT_ORI"].ToString();
            N_INT_ORI = ds.Tables[0].Rows[0]["N_INT_ORI"].ToString();
            FECHA_INGRESO = DateTime.ParseExact(ds.Tables[0].Rows[0]["FECHA_INGRESO"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            HORA_INGRESO = ds.Tables[0].Rows[0]["HORA_INGRESO"].ToString();
            USUARIO_INGRESO = ds.Tables[0].Rows[0]["USUARIO_INGRESO"].ToString();
            TERMINAL_INGRESO = ds.Tables[0].Rows[0]["TERMINAL_INGRESO"].ToString();
            IMPORTE_TOTAL_CON_IMPUESTOS = decimal.Parse(ds.Tables[0].Rows[0]["IMPORTE_TOTAL_CON_IMPUESTOS"].ToString(), culture);
            CANTIDAD_KILOS = decimal.Parse(ds.Tables[0].Rows[0]["CANTIDAD_KILOS"].ToString(), culture);
            ID_DIRECCION_ENTREGA = int.Parse(ds.Tables[0].Rows[0]["ID_DIRECCION_ENTREGA"].ToString());
            IMPORTE_GRAVADO = decimal.Parse(ds.Tables[0].Rows[0]["IMPORTE_GRAVADO"].ToString(), culture);
            IMPORTE_EXENTO = decimal.Parse(ds.Tables[0].Rows[0]["IMPORTE_EXENTO"].ToString(), culture);
            ID_STA13 = int.Parse(ds.Tables[0].Rows[0]["ID_STA13"].ToString());
            NRO_SUCURSAL_DESTINO_REMITO = int.Parse(ds.Tables[0].Rows[0]["NRO_SUCURSAL_DESTINO_REMITO"].ToString());
        }
        #endregion

    }
}
