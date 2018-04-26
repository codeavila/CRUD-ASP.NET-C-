using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class PopulateDropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillCountry();
            }
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CountryID = Convert.ToInt32(ddlCountry.SelectedValue.ToString());
            FillStates(CountryID);
            ddlCity.SelectedIndex = 0;
        }

        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int StateID = Convert.ToInt32(ddlState.SelectedValue.ToString());
            FillCities(StateID);
        }

        private void FillCountry()
        {
            string strConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CountryID, CountryName FROM Country";

            DataSet objDs = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(objDs);
            con.Close();
            if (objDs.Tables[0].Rows.Count > 0)
            {
                ddlCountry.DataSource = objDs.Tables[0];
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryID";
                ddlCountry.DataBind();
                ddlCountry.Items.Insert(0, "--Select--");
            }
            else
            {
                lblMsg.Text = "No Countries found";
            }
        }

        private void FillStates(int countryID)
        {
            string strConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT StateID, StateName FROM State WHERE CountryID =@CountryID";
            cmd.Parameters.AddWithValue("@CountryID", countryID);
            DataSet objDs = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(objDs);
            con.Close();
            if (objDs.Tables[0].Rows.Count > 0)
            {
                ddlState.DataSource = objDs.Tables[0];
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "StateID";
                ddlState.DataBind();
                ddlState.Items.Insert(0, "--Select--");
            }
            else
            {
                lblMsg.Text = "No states found";
            }
        }

        private void FillCities(int stateID)
        {
            string strConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT CityID, CityName FROM City WHERE StateID =@StateID";
            cmd.Parameters.AddWithValue("@StateID", stateID);
            DataSet objDs = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(objDs);
            con.Close();
            if (objDs.Tables[0].Rows.Count > 0)
            {
                ddlCity.DataSource = objDs.Tables[0];
                ddlCity.DataTextField = "CityName";
                ddlCity.DataValueField = "CItyID";
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, "--Select--");
            }
            else
            {
                lblMsg.Text = "No Cities found";
            }

        }
    }
}