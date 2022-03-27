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
    public partial class ALQUILER_CONDOMINIOS : Form
    {
        public ALQUILER_CONDOMINIOS()
        {
            InitializeComponent();
        }

        private void BT_SALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BT_CLIEN_Click(object sender, EventArgs e)
        {
            Cliente agregar_cliente = new Cliente();
            agregar_cliente.Show();
            
        }

        private void BT_CONDO_Click(object sender, EventArgs e)
        {
            Condominios agregar_condominios = new Condominios();
            agregar_condominios.Show();
        }

        private void BT_ALQUI_Click(object sender, EventArgs e)
        {
            Alquiler pt_alquilar = new Alquiler();
            pt_alquilar.Show();
        }

        //private void BT_RPT_Click(object sender, EventArgs e)
        //{
        //    rpt_alquiler rptalquiler = new rpt_alquiler();
        //    rptalquiler.Show();
        //}

        private void ALQUILER_CONDOMINIOS_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();



        }

        private void BT_RPT_Click_1(object sender, EventArgs e)
        {
            rpt_alquiler rptalquiler = new rpt_alquiler();
            rptalquiler.Show();
        }
    }
}
