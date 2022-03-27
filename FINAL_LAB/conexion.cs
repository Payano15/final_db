using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

    namespace FINAL_LAB
    {
        class conexion
        {
          public  SqlConnection cnx;

            public conexion() 
            {
                try
                {
                    cnx = new SqlConnection("Data Source=DESKTOP-AKVR2DH\\ESP;Initial Catalog=FINAL_DB; User ID=sa; Password=esp1234");
                    cnx.Open();
                  
                }
                catch (Exception a)
                {
                    MessageBox.Show("Error al Conectar" + a.Message,"No se Conecto");

                }
                   cnx.Close();    
        
        
            }

          
        }
    } 
