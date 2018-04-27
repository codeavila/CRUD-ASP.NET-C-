using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class Read : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                Fill_Usuarios();
            }
        }

        private void Fill_Usuarios()
        {
            string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                Debug.WriteLine("Paso 1: Dentro de Fill_Usuarios ");
                string SQL_Query = @"SELECT id_usuario, user_name, user_password FROM users";
                SqlCommand cmd = new SqlCommand(SQL_Query, con);

                DataSet objDs = new DataSet();
                SqlDataAdapter dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = cmd;
                con.Open();
                dAdapter.Fill(objDs);
                con.Close();
                if (objDs.Tables[0].Rows.Count > 0)
                {
                    DropDown_Usuarios.DataSource = objDs.Tables[0];
                    DropDown_Usuarios.DataTextField = "user_name";
                    DropDown_Usuarios.DataValueField = "id_usuario";
                    DropDown_Usuarios.DataBind();
                    DropDown_Usuarios.Items.Insert(0, "--Select--");
                }

            }
        }

        protected void DropDown_Usuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int usuarioID = Convert.ToInt32(DropDown_Usuarios.SelectedValue.ToString());
            //Fill_Password(usuarioID);
            show_Data_User(usuarioID);
           
        }

        private void show_Data_User(int usuarioID_InnerJoin)
        {
            string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";

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
                        asp_UsuarioID.Text = dr.GetValue(0).ToString();
                        asp_UsuarioNombre.Text = dr.GetValue(1).ToString();
                        asp_UsuarioPassword.Text = dr.GetValue(2).ToString();
                        asp_RegisterDate.Text = dr.GetValue(3).ToString();
                        asp_UpdateDate.Text = dr.GetValue(4).ToString();
                        //Usuario Detalles
                        aps_Detail_usuarioNombre.Text = dr.GetValue(6).ToString();
                        asp_Detail_usuarioApellido.Text = dr.GetValue(7).ToString();
                        asp_Detail_usuarioATelefono.Text = dr.GetValue(8).ToString();
                        asp_Detail_usuarioEstado.Text = dr.GetValue(9).ToString();
                        asp_Detail_usuarioCiudad.Text = dr.GetValue(10).ToString();
                        asp_Detail_usuarioEmail.Text = dr.GetValue(11).ToString();

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

        /*
        private void Fill_Password(int usuarioID)
        {
            string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                Debug.WriteLine("Paso 1: Dentro de Fill_Password ");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT id_usuario, user_name, user_password FROM users WHERE id_usuario = @UsuarioID";
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);

                DataSet objDs = new DataSet();
                SqlDataAdapter dAdapter = new SqlDataAdapter();
                dAdapter.SelectCommand = cmd;
                con.Open();
                dAdapter.Fill(objDs);
                con.Close();
                if (objDs.Tables[0].Rows.Count > 0)
                {
                    DropDown_Passwords.DataSource = objDs.Tables[0];
                    DropDown_Passwords.DataTextField = "user_password";
                    DropDown_Passwords.DataValueField = "id_usuario";
                    DropDown_Passwords.DataBind();
                    DropDown_Passwords.Items.Insert(0, "--Select--");
                }

            }
        }

       */
    }
}