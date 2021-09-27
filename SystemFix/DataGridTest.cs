using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemFix
{
    public partial class DataGridTest : Form
    {
        public DataGridTest()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridTest_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "asdsd";
            dataGridView1.DataSource = Global.lista;
            dataGridView1.Columns[0].HeaderText = "Nombres";
            dataGridView1.Columns[1].HeaderText = "Apellidos";
            dataGridView1.Columns[2].HeaderText = "Documento";
            dataGridView1.Columns[3].HeaderText = "Teléfono";
            dataGridView1.Columns[4].HeaderText = "Dirección";
            dataGridView1.Columns[5].HeaderText = "Pago abonado";
            dataGridView1.Columns[6].HeaderText = "Marca";
            dataGridView1.Columns[7].HeaderText = "Referencia";
            dataGridView1.Columns[8].HeaderText = "Detalles";
            dataGridView1.Columns[9].HeaderText = "Tipo de dispositivo";

        }
    }
}
