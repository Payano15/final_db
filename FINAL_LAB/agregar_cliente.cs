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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BT_Salir_Clien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();

            string consulta = "select * from cliente";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, c.cnx);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            data_cliente.DataSource = dt;
        }

        private void BT_guardar_Clien_Click(object sender, EventArgs e)
        {
            conexion c = new conexion();
            //var idCliente = TB_ID_CLIENTE.Text;

            //idCliente = "" ? 0 : TB_ID_CLIENTE.Text;

            String sql = "insert into cliente (nombre,apellido,identificacion,direccion,correo,telefono)" +
               "values(@nombre,@apellido,@identificacion,@direccion,@correo,@telefono)";
            SqlCommand cmd = new SqlCommand(sql,c.cnx);
            cmd.Parameters.AddWithValue("@nombre", TB_N_CLIENTE.Text);
            cmd.Parameters.AddWithValue("@apellido", TB_A_CLIENTE.Text) ;
            cmd.Parameters.AddWithValue("@identificacion", TB_IN_CLIENTE.Text);
            cmd.Parameters.AddWithValue("@direccion", TB_D_CLIENTE.Text);
            cmd.Parameters.AddWithValue("@correo", TB_C_CLIENTE.Text);
            cmd.Parameters.AddWithValue("@telefono", TB_T_CLIENTE.Text);
            c.cnx.Open();
            try
            {
                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("El Cliente Se agrego Correcta Mente");

            }
            catch (Exception)
            {
                MessageBox.Show("Fallo al agregar Cliente");
            }
            c.cnx.Close();


        }

        private void BT_Limpiar_clien_Click(object sender, EventArgs e)
        {
            limpiar limpiar = new limpiar();
            limpiar.limpiarCampos(this);
        }
    }
}
