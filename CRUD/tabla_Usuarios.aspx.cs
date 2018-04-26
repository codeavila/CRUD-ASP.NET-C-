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
    public partial class tabla_Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Fill_Table();
            }
        }

        private void Fill_Table()
        {
            string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                string SQL_Query = @"SELECT* FROM users";
                SqlCommand cmd = new SqlCommand(SQL_Query, con);
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    rptTable.DataSource = ds;
                    rptTable.DataBind();
                    con.Close();
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

        protected void btn_DoSwitchCase(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Comando_Delete":
                    Debug.WriteLine("Caso Delete");
                    int C_ID_Delete = Convert.ToInt32(e.CommandArgument);
                        Method_Delete(C_ID_Delete);
                    break;
                case "Comando_Read":
                    Debug.WriteLine("Caso Read");
                        Response.Redirect("Read.aspx");
                    break;
                case "Comando_Update":
                    Debug.WriteLine("Caso Update");
                    int C_ID_Update = Convert.ToInt32(e.CommandArgument);
                        Method_Update(C_ID_Update);
                    break;
                case "Comando_Back":
                        Response.Redirect("Login.aspx");
                    break;
            }
        }

        private void Method_Delete(int get_ID)
        {
            Debug.WriteLine("Metodo Delete");

            string ChainConexionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(ChainConexionString))
            {
                Debug.WriteLine("Paso 1: Dentro de la Conexion ");
                string SQL_Query = @"DELETE FROM users WHERE id_usuario = @SQL_ID";
                SqlCommand cmd = new SqlCommand(SQL_Query, con);

                cmd.Parameters.Add("@SQL_ID", System.Data.SqlDbType.VarChar);
                cmd.Parameters["@SQL_ID"].Value = get_ID;
                Debug.WriteLine("Paso 2: Variables Registradas SQL_() ");
                try
                {
                    Debug.WriteLine("Paso 3: Preparando Eliminacion ");
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Response.Redirect("tabla_Usuarios.aspx");
                    Debug.WriteLine("Paso 4: Elemento Eliminado con Exito ");
                    con.Close();
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

        private void Method_Read(int get_ID)
        {
            

            
        }

        private void Method_Update(int get_ID)
        {
            Debug.WriteLine("Paso 1: Datos que se integran en la Cookie: " + get_ID);
            HttpCookie Own_Cookie = new HttpCookie("EUABApp");
            Own_Cookie.Value = get_ID.ToString();
            Own_Cookie.Expires = DateTime.Now.AddHours(1);
            Own_Cookie.Path = "EUAB_App";
            Response.Cookies.Add(Own_Cookie);
            Debug.WriteLine("Paso 2: Datos Cookie: " + Own_Cookie.Value);
            Response.Redirect("Update.aspx");
        }
    }
}