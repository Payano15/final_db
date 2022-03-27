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
    public partial class Condominios : Form
    {
        public Condominios()
        {
            InitializeComponent();
        }

        private void BT_salir_condo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_Guardar_cond_Click(object sender, EventArgs e)
        {
            conexion c = new conexion();
            //var idCliente = TB_ID_CLIENTE.Text;

            //idCliente = "" ? 0 : TB_ID_CLIENTE.Text;

            String sql = "insert into condominios (descripcion,numero,capaciodad,direccion,telefono,correo)" +
               "values(@descripcion,@numero,@capaciodad,@direccion,@telefono,@correo)";
            SqlCommand cmd = new SqlCommand(sql, c.cnx);
            cmd.Parameters.AddWithValue("@descripcion", TB_DESC_COND.Text);
            cmd.Parameters.AddWithValue("@numero", TB_Num_cond.Text);
            cmd.Parameters.AddWithValue("@capaciodad", TB_CAPAC_CONDO.Text);
            cmd.Parameters.AddWithValue("@direccion", TB_DIRE_CONDO.Text);
            cmd.Parameters.AddWithValue("@telefono", TB_TELE_CONDO.Text);
            cmd.Parameters.AddWithValue("@correo", TB_CORRE_CONDO.Text);
            c.cnx.Open();

            try
            {
                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("El COndominio Se agrego Correcta Mente");

            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al agregar el Condominio");
            }
            c.cnx.Close();
        }

        private void Condominios_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();

            string consulta = "select * from condominios";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, c.cnx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            data_condo.DataSource = dt;
        }

        private void BT_LIMPIAR_CONDO_Click(object sender, EventArgs e)
        {
            limpiar limpiar = new limpiar();
            limpiar.limpiarCampos(this);
        }
    }
}
