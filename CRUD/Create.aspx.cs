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
        
        
        // Metodo Para Insertar solo a la tabla USERS 
        
            private void Method_Create()
        {
            Debug.WriteLine("Metodo Create");
            string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                Debug.WriteLine("Paso 1: Dentro de la Conexion ");
                string SQL_Query = @"INSERT INTO users (user_name,user_password,user_create_date,user_update_date) 
                                        VALUES  (@SQL_user_name, @SQL_user_password,CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)";

                SqlCommand cmd = new SqlCommand(SQL_Query, con);

                cmd.Parameters.Add("@SQL_user_name", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_user_name"].Value = asp_UsuarioNombre.Text;
                Debug.WriteLine("SQL_user_name: " + asp_UsuarioNombre.Text);

                cmd.Parameters.Add("@SQL_user_password", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_user_password"].Value = asp_UsuarioPassword.Text;
                Debug.WriteLine("SQL_user_password: " + asp_UsuarioPassword.Text);

                Debug.WriteLine("Paso 2: Variables Registradas SQL_()");
                try
                {
                    Debug.WriteLine("Paso 3: Preparando INSERT ");
                    con.Open();

                    //SQL_INSERT USUARIO 
                    cmd.ExecuteNonQuery();
                    Debug.WriteLine("Los Datos de Usuario y Password Insertados con exito");
                    //

                    // SQL RETURN LAST ID INSERTED
                    SqlCommand cmd_ID = new SqlCommand("SELECT IDENT_CURRENT('users')", con);
                    int newId = Convert.ToInt32(cmd_ID.ExecuteScalar());
                    Debug.WriteLine("El Ultimo ID es: " + newId);
                    // ///////////////////// //



                    //SQL INSERT NEXT 
                    string SQL_Query_B = @"INSERT INTO usersDetails (usuario_Nombre, usuario_Apellido, usuario_Telefono, usuario_Estado, usuario_Ciudad, usuario_Email, id_usuario)
                                     VALUES  (@SQL_usuario_Nombre, @SQL_usuario_Apellido, @SQL_usuario_Telefono, @SQL_usuario_Estado, @SQL_usuario_Ciudad, @SQL_usuario_Email, @SQL_Last_ID )";

                    SqlCommand cmd_B = new SqlCommand(SQL_Query_B, con);

                    cmd_B.Parameters.Add("@SQL_Last_ID", System.Data.SqlDbType.VarChar);
                    cmd_B.Parameters["@SQL_Last_ID"].Value = newId;
                    Debug.WriteLine("SQL_Last_ID: " + newId);

                    cmd_B.Parameters.Add("@SQL_usuario_Nombre", System.Data.SqlDbType.VarChar);
                    cmd_B.Parameters["@SQL_usuario_Nombre"].Value = aps_Detail_usuarioNombre.Text;
                    Debug.WriteLine("SQL_usuario_Nombre: " + aps_Detail_usuarioNombre.Text);

                    cmd_B.Parameters.Add("@SQL_usuario_Apellido", System.Data.SqlDbType.VarChar);
                    cmd_B.Parameters["@SQL_usuario_Apellido"].Value = asp_Detail_usuarioApellido.Text;
                    Debug.WriteLine("SQL_usuario_Apellido: " + asp_Detail_usuarioApellido.Text);

                    cmd_B.Parameters.Add("@SQL_usuario_Telefono", System.Data.SqlDbType.VarChar);
                    cmd_B.Parameters["@SQL_usuario_Telefono"].Value = asp_Detail_usuarioATelefono.Text;
                    Debug.WriteLine("SQL_usuario_Telefono: " + asp_Detail_usuarioATelefono.Text);

                    cmd_B.Parameters.Add("@SQL_usuario_Estado", System.Data.SqlDbType.VarChar);
                    cmd_B.Parameters["@SQL_usuario_Estado"].Value = asp_Detail_usuarioEstado.Text;
                    Debug.WriteLine("SQL_usuario_Estado: " + asp_Detail_usuarioEstado.Text);

                    cmd_B.Parameters.Add("@SQL_usuario_Ciudad", System.Data.SqlDbType.VarChar);
                    cmd_B.Parameters["@SQL_usuario_Ciudad"].Value = asp_Detail_usuarioCiudad.Text;
                    Debug.WriteLine("SQL_usuario_Ciudad: " + asp_Detail_usuarioCiudad.Text);

                    cmd_B.Parameters.Add("@SQL_usuario_Email", System.Data.SqlDbType.VarChar);
                    cmd_B.Parameters["@SQL_usuario_Email"].Value = asp_Detail_usuarioEmail.Text;
                    Debug.WriteLine("SQL_usuario_Email: " + asp_Detail_usuarioEmail.Text);

                    
                   
                    cmd_B.ExecuteNonQuery();

                    Debug.WriteLine("Los Datos de Details han sido Insertados con exito");
                    /////



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

        /*
        private void Method_Create()
        {
            Debug.WriteLine("Metodo Create");
            string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                Debug.WriteLine("Paso 1: Dentro de la Conexion ");

                string SQL_Query_A = @"INSERT INTO users (user_name,user_password,user_create_date,user_update_date) VALUES  (@SQL_user_name, @SQL_user_password,CURRENT_TIMESTAMP,CURRENT_TIMESTAMP)";
                SqlCommand cmd_A = new SqlCommand(SQL_Query_A, con);

                cmd_A.Parameters.Add("@SQL_user_name", System.Data.SqlDbType.VarChar);
                cmd_A.Parameters["@SQL_user_name"].Value = asp_UsuarioNombre.Text;
                Debug.WriteLine("SQL_user_name: " + asp_UsuarioNombre.Text);

                cmd_A.Parameters.Add("@SQL_user_password", System.Data.SqlDbType.VarChar);
                cmd_A.Parameters["@SQL_user_password"].Value = asp_UsuarioPassword.Text;
                Debug.WriteLine("SQL_user_password: " + asp_UsuarioPassword.Text);

                string SQL_Query_B = @"INSERT INTO usersDetails (usuario_Nombre, usuario_Apellido, usuario_Telefono, usuario_Estado, usuario_Ciudad, usuario_Email)
                                     VALUES  (@SQL_usuario_Nombre, @SQL_usuario_Apellido, @SQL_usuario_Telefono, @SQL_usuario_Estado, @SQL_usuario_Ciudad, @SQL_usuario_Email)";
                SqlCommand cmd_B = new SqlCommand(SQL_Query_B, con);

                cmd_B.Parameters.Add("@SQL_usuario_Nombre", System.Data.SqlDbType.VarChar);
                cmd_B.Parameters["@SQL_usuario_Nombre"].Value = aps_Detail_usuarioNombre.Text;
                Debug.WriteLine("SQL_usuario_Nombre: " + aps_Detail_usuarioNombre.Text);

                cmd_B.Parameters.Add("@SQL_usuario_Apellido", System.Data.SqlDbType.VarChar);
                cmd_B.Parameters["@SQL_usuario_Apellido"].Value = asp_Detail_usuarioApellido.Text;
                Debug.WriteLine("SQL_usuario_Apellido: " + asp_Detail_usuarioApellido.Text);

                cmd_B.Parameters.Add("@SQL_usuario_Telefono", System.Data.SqlDbType.VarChar);
                cmd_B.Parameters["@SQL_usuario_Telefono"].Value = asp_Detail_usuarioATelefono.Text;
                Debug.WriteLine("SQL_usuario_Telefono: " + asp_Detail_usuarioATelefono.Text);

                cmd_B.Parameters.Add("@SQL_usuario_Estado", System.Data.SqlDbType.VarChar);
                cmd_B.Parameters["@SQL_usuario_Estado"].Value = asp_Detail_usuarioEstado.Text;
                Debug.WriteLine("SQL_usuario_Estado: " + asp_Detail_usuarioEstado.Text);

                cmd_B.Parameters.Add("@SQL_usuario_Ciudad", System.Data.SqlDbType.VarChar);
                cmd_B.Parameters["@SQL_usuario_Ciudad"].Value = asp_Detail_usuarioCiudad.Text;
                Debug.WriteLine("SQL_usuario_Ciudad: " + asp_Detail_usuarioCiudad.Text);

                cmd_B.Parameters.Add("@SQL_usuario_Email", System.Data.SqlDbType.VarChar);
                cmd_B.Parameters["@SQL_usuario_Email"].Value = asp_Detail_usuarioEmail.Text;
                Debug.WriteLine("SQL_usuario_Email: " + asp_Detail_usuarioEmail.Text);


                Debug.WriteLine("Paso 2: Variables Registradas SQL_() ");
                try
                {
                    Debug.WriteLine("Paso 3: Preparando INSERT ");
                    con.Open();
                    cmd_A.ExecuteNonQuery();

                    cmd_B.ExecuteNonQuery();
                    Debug.WriteLine("Paso 4: Elementos INSERTADOS");
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
        }*/
    }
}