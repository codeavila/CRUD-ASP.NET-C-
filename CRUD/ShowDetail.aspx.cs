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
    public partial class ShowDetail : System.Web.UI.Page
    {
        string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=DB_users;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //show_Data_User();
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
                show_Data_User(varCookie);

            }
            else
            {
                Debug.WriteLine("Cookie Recibida :( Sin Datos");
            }
        }

        private void show_Data_User(int usuarioID_InnerJoin)
        {
            
            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                Debug.WriteLine("Paso 1: Dentro de show_Data_User");
                string SQL_I = "SELECT * FROM users INNER JOIN usersDetails ON users.id_usuario = usersDetails.id_usuario WHERE users.id_usuario = @SQL_id_usuario_INNER_JOIN";
                SqlCommand cmd = new SqlCommand(SQL_I, con);
                //cmd.CommandText = @"SELECT id_usuario, user_name, user_password FROM users WHERE id_usuario = @UsuarioID";
                //cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd.Parameters.AddWithValue("@SQL_id_usuario_INNER_JOIN", usuarioID_InnerJoin);



                try
                {
                    Debug.WriteLine("Paso 3: Preparando Datos ");
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        //Usuario Registro
                        asp_UsuarioID.Text = "" + dr.GetValue(dr.GetOrdinal("id_usuario"));
                        asp_UsuarioNombre.Text ="" + dr.GetValue(dr.GetOrdinal("user_name"));
                        asp_UsuarioPassword.Text ="" + dr.GetValue(dr.GetOrdinal("user_password"));
                        asp_RegisterDate.Text ="" + dr.GetValue(dr.GetOrdinal("user_create_date"));
                        asp_UpdateDate.Text = "" + dr.GetValue(dr.GetOrdinal("user_update_date"));

                        /* OBTENER DATOS POR MEDIO DEL NUMERO DE COLUMNA
                        asp_UsuarioID.Text = dr.GetValue(0).ToString();
                        asp_UsuarioNombre.Text = dr.GetValue(1).ToString();
                        asp_UsuarioPassword.Text = dr.GetValue(2).ToString();
                        asp_RegisterDate.Text = dr.GetValue(3).ToString();
                        asp_UpdateDate.Text = dr.GetValue(4).ToString();
                        */
                        //Usuario Detalles
                        aps_Detail_usuarioNombre.Text = "" + dr.GetOrdinal("usuario_Nombre").ToString();
                        asp_Detail_usuarioApellido.Text = "" + dr.GetOrdinal("usuario_Apellido").ToString();
                        asp_Detail_usuarioATelefono.Text = "" + dr.GetOrdinal("usuario_Telefono").ToString();
                        asp_Detail_usuarioEstado.Text = "" + dr.GetOrdinal("usuario_Estado").ToString();
                        asp_Detail_usuarioCiudad.Text = "" + dr.GetOrdinal("usuario_Ciudad").ToString();
                        asp_Detail_usuarioEmail.Text = "" + dr.GetOrdinal("usuario_Email").ToString();
                        /* OBTENER DATOS POR MEDIO DEL NUMERO DE COLUMNA
                        aps_Detail_usuarioNombre.Text = dr.GetValue(6).ToString();
                        asp_Detail_usuarioApellido.Text = dr.GetValue(7).ToString();
                        asp_Detail_usuarioATelefono.Text = dr.GetValue(8).ToString();
                        asp_Detail_usuarioEstado.Text = dr.GetValue(9).ToString();
                        asp_Detail_usuarioCiudad.Text = dr.GetValue(10).ToString();
                        asp_Detail_usuarioEmail.Text = dr.GetValue(11).ToString();
                        */
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

        protected void btn_Back_Click(object sender, EventArgs e)
        {
            Server.Transfer("tabla_Usuarios.aspx");
        }
    }
}