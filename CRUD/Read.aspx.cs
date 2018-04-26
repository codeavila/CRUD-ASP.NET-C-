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
            Method_Fill_DropDownUser();
        }

        private void Method_Fill_DropDownUser() 
        {
            DataTable dropDown_Content = new DataTable();
            string connectionString = "Data Source=WEB-USER;Initial Catalog=usuarios;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT user_name FROM users", con);
                    adapter.Fill(dropDown_Content);


                    DropDown_UserName.DataSource = dropDown_Content;
                    DropDown_UserName.DataTextField = "user_name";
                    
                    DropDown_UserName.DataBind();
                }
                catch (Exception ex)
                {
                    // Handle the error
                }
            }
        }

        protected void DropDown_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("A El valor selecionado fue: "+ DropDown_UserName.DataTextField.ToString());
            Debug.WriteLine("B El valor selecionado fue: " + DropDown_UserName.DataValueField.ToString());
            Debug.WriteLine("C El valor selecionado fue: " + DropDown_UserName.SelectedIndex.ToString());
            Debug.WriteLine("D El valor selecionado fue: " + DropDown_UserName.SelectedItem.ToString());
            Debug.WriteLine("E El valor selecionado fue: " + DropDown_UserName.SelectedValue.ToString());
            Debug.WriteLine("E El valor selecionado fue: " + DropDown_UserName.Text);
        }
    }
}