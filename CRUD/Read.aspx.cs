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
                Method_Fill_DropDownUser();
            }
        }

        private void Method_Fill_DropDownUser() 
        {
            DataTable subjects = new DataTable();
            string connectionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT id_usuario,user_name FROM users", con);
                    adapter.Fill(subjects);

                    ddlSubject.DataSource = subjects;
                    ddlSubject.DataTextField = "user_name";
                    ddlSubject.DataValueField = "id_usuario";
                    ddlSubject.DataBind();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Error: " +ex);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Valor: "+ ddlSubject.SelectedValue.ToString());
            
        }
    }
}