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
    public partial class Update : System.Web.UI.Page
    {
        string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CookieRecieve();
            }

        }

       
        public void CookieRecieve()
        {

            if (Request.Cookies["EUABApp"] != null)
            {
                Debug.WriteLine("Cookie Recibida :D con Datos");
                HttpCookie aCookie = Request.Cookies["EUABApp"];
                Debug.WriteLine(Server.HtmlEncode(aCookie.Value));
                int varCookie = int.Parse(aCookie.Value);
                Method_Fill_Info(varCookie);

            }
            else
            {
                Debug.WriteLine("Cookie Recibida :( Sin Datos");
            }
        }

        private void Method_Fill_Info(int varCookie)
        {
            Debug.WriteLine("Medoto Fill Info");


                using (SqlConnection con = new SqlConnection(ChainConexionString))
                {
                    string SQL_Query = @"SELECT * FROM users WHERE id_usuario = @SQL_ID";
                    SqlCommand cmd = new SqlCommand(SQL_Query, con);
                    int varC_IdUsuario = varCookie;
                    Debug.WriteLine("Nombre de Usuario: " + varC_IdUsuario);
                    cmd.Parameters.Add("@SQL_ID", System.Data.SqlDbType.Int);
                    cmd.Parameters["@SQL_ID"].Value = varC_IdUsuario;

                    try
                    {
                        Debug.WriteLine("Paso 3: Preparando Datos ");
                        con.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            asp_UsuarioID.Text = dr.GetValue(0).ToString();
                            asp_UsuarioNombre.Text = dr.GetValue(1).ToString();
                            asp_UsuarioPassword.Text = dr.GetValue(2).ToString();
                            dr.Close();

                            Debug.WriteLine("Paso 4: Datos cargados ");
                            con.Close();
                    }

                        
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


        protected void btn_LoginSwitchCase(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Comando_Update":
                    Debug.WriteLine("Caso Actualizar");
                    Method_Update();
                    break;

                case "Comando_Back":
                    Debug.WriteLine("Caso Back");
                    Server.Transfer("tabla_Usuarios.aspx");
                    break;
            }
        }

        private void Method_Update()
        {
            Debug.WriteLine("Metodo Update");

            //string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                Debug.WriteLine("Paso 1: Dentro de la Conexion ");
                string SQL_Query = @"UPDATE users SET user_name = @SQL_user_name , user_password = @SQL_user_password WHERE id_usuario= @SQL_ID_Usuario";
                SqlCommand cmd = new SqlCommand(SQL_Query, con);

                cmd.Parameters.Add("@SQL_ID_Usuario", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_ID_Usuario"].Value = asp_UsuarioID.Text;
                Debug.WriteLine("SQL_ID_Usuario: "+ asp_UsuarioID.Text);

                cmd.Parameters.Add("@SQL_user_name", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_user_name"].Value = asp_UsuarioNombre.Text;
                Debug.WriteLine("SQL_user_name: "+ asp_UsuarioNombre.Text);

                cmd.Parameters.Add("@SQL_user_password", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_user_password"].Value = asp_UsuarioPassword.Text;
                Debug.WriteLine("SQL_user_password: "+ asp_UsuarioPassword.Text);

                Debug.WriteLine("Paso 2: Variables Registradas SQL_() ");
                try
                {
                    Debug.WriteLine("Paso 3: Preparando Update ");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Debug.WriteLine("Paso 4: Elemento Actualizado");
                    con.Close();
                    Response.Redirect("tabla_Usuarios.aspx");
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