using Efco___Carga_de_pedidos.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Efco___Carga_de_pedidos
{
    public partial class FrmMain : Form
    {
        Procesos oProc = new Procesos();
        List<Pedido> pedidos = new List<Pedido>();
        
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LeyendaFecha();
            string log = oProc.Configurar();
            if (!log.Equals(""))
            {
                MessageBox.Show(log, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LeyendaFecha()
        {
            textBox1.Text = dateTimePicker1.Value.ToString("MMMM yyyy").ToUpper();
        }

        private void cargarArchivoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ReadExcel oExcel = new ReadExcel();
                pedidos = oExcel.leerExcel(openFileDialog1.FileName);
                dataGridView1.DataSource = pedidos;
                toolStripStatusLabel1.Text = "Cantidad de Pedidos: " + pedidos.Count.ToString();
                cargarArchivoToolStripMenuItem1.Enabled = false;
                
            }
        }

        private void pedidosATangoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (pedidos.Count < 1)
            {
                MessageBox.Show( "No hay pedidos para procesar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CultureInfo provider = new CultureInfo("en-US");
            NumberStyles style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            errorProvider1.Clear();
            try
            {
                decimal a = Decimal.Parse(textBox3.Text, style, provider);
            }
            catch(Exception ex)
            {

                errorProvider1.SetError(textBox3, "Debe ingresar un numero!");
                return;
            }


            panel1.Enabled = false;
            oProc.ComenzarTransac();
            toolStripProgressBar1.Maximum = pedidos.Count;
            toolStripProgressBar1.Step = 1;
            bool err = false;

            foreach (Pedido ped in pedidos)
            {
                ped.leyenda = textBox1.Text;
                ped.leyenda2 = textBox2.Text;

                CultureInfo culture = new CultureInfo("en-US");
                ped.cotiz = decimal.Parse(textBox3.Text, culture);

                ped.fecha = dateTimePicker1.Value;
                ped.log = oProc.CargarPedido(ped);
                if (!ped.log.Substring(0,3).Equals("Ok-"))
                {
                    err = true;
                }
                toolStripProgressBar1.PerformStep();
                Application.DoEvents();

            }
            dataGridView1.Refresh();
            if(err)
            {
                oProc.CancelarTransac();
                MessageBox.Show("Hubo errores!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                oProc.ConfirmarTransac();
                MessageBox.Show("Proceso Finalizado correctamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            panel1.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LeyendaFecha();
        }
    }
}
