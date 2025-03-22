using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Efco___Carga_de_pedidos.Negocio
{
    public class ReadExcel
    {
        public List<Pedido> leerExcel(string archivo)
        {
            List<Pedido> cPedidos = new List<Pedido>();

            Excel.Application oExcel = new Excel.Application();

            Excel.Workbook WB = oExcel.Workbooks.Open(archivo, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            int fila = 2;

            try
            {
                string ExcelWorkbookname = WB.Name;

                int worksheetcount = WB.Worksheets.Count;

                Excel.Worksheet wks = (Excel.Worksheet)WB.Worksheets[1];

                string firstworksheetname = wks.Name;

                
                string columnaA = ((Excel.Range)wks.Cells[3, 1]).Value2.ToString();

                while (columnaA != "")
                {
                    fila++;

                    if (fila == 358)
                    {
                        string a = "";
                        a = "freno";
                    }
                    if(((Excel.Range)wks.Cells[fila, 1]).Value2 == null)
                    {
                        columnaA = "";
                        break;
                    }

                    columnaA = ((Excel.Range)wks.Cells[fila, 1]).Value2.ToString();
                    if(columnaA.IndexOf("Total") < 0)
                    {
                        Pedido ped = new Pedido();
                        ped.fila = fila;
                        ped.cliente = columnaA;
                        ped.articulo = ((Excel.Range)wks.Cells[fila, 8]).Value2.ToString();

                        ped.precio = ((decimal)((Excel.Range)wks.Cells[fila, 5]).Value2);

                        cPedidos.Add(ped);
                    }
                }

                Marshal.ReleaseComObject(wks);

            }
            catch (Exception ex)
            {
                //error = ex.Message;
                return new List<Pedido>();
            }
            finally
            {
                //Marshal.ReleaseComObject(Range);

                //WRITE close and release
                WB.Close(false, Missing.Value, Missing.Value);
                Marshal.ReleaseComObject(WB);
                //!WRITE quit and release
                oExcel.Quit();
                Marshal.ReleaseComObject(oExcel);
                //cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            return cPedidos;
        }

        
    }
}
