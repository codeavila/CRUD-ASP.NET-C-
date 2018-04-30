using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO; // Para ver el directorio
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CRUD
{
    public partial class Login : System.Web.UI.Page 
    {
        string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=DB_users;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            //   string path = Directory.GetCurrentDirectory();
            //   Debug.WriteLine("El Path es: "+path);
        }
        protected void btn_LoginSwitchCase(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Comando_Ingresar":
                    Debug.WriteLine("Caso Ingresar");
                    Control_Errores_Campos();
                    break;

                case "Comando_Registrar":
                    Debug.WriteLine("Caso Registrar");
                    Server.Transfer("Create.aspx");
                    break;
            }
        }

        private void Control_Errores_Campos()
        {

            if (asp_UsuarioNombre.Text == "" && asp_UsuarioPassword.Text == "")
             {
               var Error_Message_UserName= "<div class='alert alert-danger' role='alert'>Llenar ambos campos</div>";
                 Response.Write(Error_Message_UserName);
            }
            else if (asp_UsuarioNombre.Text == "" || asp_UsuarioPassword.Text == "")
            {
                var Error_Message_UserPass = "<div class='alert alert-danger' role='alert'>Verificar si hace falta un campo</div>";
                Response.Write(Error_Message_UserPass);
            }
            else if (asp_UsuarioNombre.Text != "" && asp_UsuarioPassword.Text != "")
            {
                Control_Errores_UsuarioExistente(asp_UsuarioNombre.Text, asp_UsuarioPassword.Text);
            }
           

        }

        private void Control_Errores_UsuarioExistente(string userName, string userPass)
        {
            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                string SQL_Query = @"SELECT user_name, user_password FROM users WHERE user_name=@SQL_UserName AND user_password=@SQL_Password";
                SqlCommand cmd = new SqlCommand(SQL_Query, con);

                cmd.Parameters.Add("@SQL_UserName", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_UserName"].Value = userName;

                cmd.Parameters.Add("@SQL_Password", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_Password"].Value = userPass;
                try
                {
                    Debug.WriteLine("Paso 3: Dentro del Try");
                    con.Open();
                    object Result = cmd.ExecuteScalar();
                    if (Result != null)
                    {
                       
                        con.Close();
                        //Thread.Sleep(5000);  
                        Response.Redirect("tabla_Usuarios.aspx");
                    }
                    else
                    {
                       
                        var Error_Message_NoExist = "<div class='alert alert-danger' role='alert'>El <strong>Usuario</strong> y <strong>Contraseña</strong> no coinciden ó <strong>No existe el Usuario</strong></div>";
                        Response.Write(Error_Message_NoExist);
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
        /*
        private void Method_Ingresar()
        {
            Debug.WriteLine("Metodo Ingresar");
            /*
            string varC_UserName = asp_UsuarioNombre.Text;
            Debug.WriteLine("Nombre de Usuario: " + varC_UserName);
            string varC_Password = asp_UsuarioPassword.Text;
            Debug.WriteLine("Password: " + varC_Password);
            */
            
        /*
            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                Debug.WriteLine("Paso 1: Dentro de la Conexion ");
                string SQL_Query = @"SELECT user_name, user_password FROM users WHERE user_name=@SQL_UserName AND user_password=@SQL_Password";
                SqlCommand cmd = new SqlCommand(SQL_Query, con);
                
                cmd.Parameters.Add("@SQL_UserName", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_UserName"].Value = asp_UsuarioNombre.Text;

                cmd.Parameters.Add("@SQL_Password", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_Password"].Value = asp_UsuarioPassword.Text;
                /*
                cmd.Parameters.Add("@SQL_UserName", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_UserName"].Value = varC_UserName.ToString();

                cmd.Parameters.Add("@SQL_Password", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_Password"].Value = varC_UserName.ToString();
                */
                /*
                Debug.WriteLine("Paso 2: Variables Registradas SQL_() ");
                try
                {
                    Debug.WriteLine("Paso 3: Dentro del Try");
                    con.Open();
                    object Result = cmd.ExecuteScalar();
                    if (Result != null)
                    {
                        Debug.WriteLine("Paso Query: "+SQL_Query);
                        Debug.WriteLine("Paso 3: Dentro del IF - Si existe el Usuario");
                        con.Close();
                        Server.Transfer("tabla_Usuarios.aspx");
                    }
                    else
                    {
                        Debug.WriteLine("Paso Query: " + SQL_Query);
                        Debug.WriteLine("Paso 3: Dentro del ELSE - No existe el Usuario");
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
        }*/
    }
}