using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FINAL_LAB
{
    public partial class rpt_alquiler : Form
    {
        public rpt_alquiler()
        {
            InitializeComponent();
        }

        private void rpt_alquiler_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();

            string consulta = "select * from ALQUILER2";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, c.cnx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            data_vew.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
