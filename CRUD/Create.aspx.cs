using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
     
            
        }

        

        protected void btn_LoginSwitchCase(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Comando_Register":
                    Method_Create();
                    break;

                case "Comando_Back":
                    Server.Transfer("Login.aspx");
                    break;
            }
        }

        private void Method_Create()
        {
            Debug.WriteLine("Metodo Create");
            string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                Debug.WriteLine("Paso 1: Dentro de la Conexion ");
                string SQL_Query = @"INSERT INTO users (user_name,user_password,user_create_date,user_update_date) VALUES  (@SQL_user_name, @SQL_user_password,CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)";
                SqlCommand cmd = new SqlCommand(SQL_Query, con);

                cmd.Parameters.Add("@SQL_user_name", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_user_name"].Value = asp_UsuarioNombre.Text;
                Debug.WriteLine("SQL_user_name: " + asp_UsuarioNombre.Text);

                cmd.Parameters.Add("@SQL_user_password", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_user_password"].Value = asp_UsuarioPassword.Text;
                Debug.WriteLine("SQL_user_password: " + asp_UsuarioPassword.Text);

                Debug.WriteLine("Paso 2: Variables Registradas SQL_() ");
                try
                {
                    Debug.WriteLine("Paso 3: Preparando INSERT ");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Debug.WriteLine("Paso 4: Elemento INSERTADO");
                    con.Close();
                    Response.Redirect("Login.aspx");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    Debug.WriteLine("Error : " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}