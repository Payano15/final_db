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
    public partial class Alquiler : Form
    {
        public Alquiler()
        {
            InitializeComponent();
        }

        private void BT_GUAR_ALQUI_CONDO_Click(object sender, EventArgs e)
        {


            conexion c = new conexion();
            //var idCliente = TB_ID_CLIENTE.Text;

            //idCliente = "" ? 0 : TB_ID_CLIENTE.Text;

            String sql = "insert into alquiler2 (Condominio,Cliente,fechaentra,fechasali,montoalqui,pagoestra,montototal)" +
               "values(@Condominio,@Cliente,@fechaentra,@fechasali,@montoalqui,@pagoestra,@montototal)";
            SqlCommand cmd = new SqlCommand(sql, c.cnx);
            cmd.Parameters.AddWithValue("@Condominio", COM_ALQUI_CONDO.Text);
            cmd.Parameters.AddWithValue("@Cliente", COMB_ALQUI_CONDO_CLIENTE.Text);
            cmd.Parameters.AddWithValue("@fechaentra", FECHA_ENTRADA_ALQUI.Text);
            cmd.Parameters.AddWithValue("@fechasali", FECHA_SALIDA_ALQUI.Text);
            cmd.Parameters.AddWithValue("@montoalqui", TB_MONT_ALQUI_CONDO.Text);
            cmd.Parameters.AddWithValue("@pagoestra", TB_MONT_ESTRA_ALQUILER_CONDO.Text);
            cmd.Parameters.AddWithValue("@montototal", TB_ALQUI_TOTAL.Text);
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

        private void COM_ALQUI_CONDO_SelectedIndexChanged(object sender, EventArgs e)
        {

            conexion c = new conexion();
            //var idCliente = TB_ID_CLIENTE.Text;

            //idCliente = "" ? 0 : TB_ID_CLIENTE.Text;

            String sql = "select * from condominios";
            SqlCommand cmd = new SqlCommand(sql, c.cnx);
            cmd.Parameters.AddWithValue("@Condominio", COM_ALQUI_CONDO.Text);
            c.cnx.Open();
            cmd.ExecuteNonQuery();
            c.cnx.Close();
        }

        private void BT_limp_alqui_condo_Click(object sender, EventArgs e)
        {
            limpiar limpiar = new limpiar();
            limpiar.limpiarCampos(this);
        }

        private void Alquiler_Load(object sender, EventArgs e)
        {
            conexion db = new conexion();
            SqlCommand comando = new SqlCommand("select descripcion from condominios",db.cnx);
            db.cnx.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read()) 
            {
                COM_ALQUI_CONDO.Items.Add(registro["descripcion"].ToString());
            }
            db.cnx.Close();

            conexion dbs = new conexion();
            SqlCommand comandoa = new SqlCommand("select NOMBRE from CLIENTE", dbs.cnx);
            dbs.cnx.Open();
            SqlDataReader registroa = comandoa.ExecuteReader();
            while (registroa.Read())
            {
                COMB_ALQUI_CONDO_CLIENTE.Items.Add(registroa["nombre"].ToString());
            }
            dbs.cnx.Close();


        }

        private void COMB_ALQUI_CONDO_CLIENTE_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void BT_TT_PAGA_ALQUI_Click(object sender, EventArgs e)
        {
            TB_ALQUI_TOTAL.Text = (Convert.ToInt32(TB_MONT_ALQUI_CONDO.Text ) + Convert.ToInt32(TB_MONT_ESTRA_ALQUILER_CONDO.Text)).ToString();
        }
    }
}
