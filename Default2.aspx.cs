using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            FillTheList();
        }
    }
    private void FillTheList()
    {
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        SqlCommand myc = new SqlCommand();
        myc.Connection = myCon;
        myc.CommandText = "SELECT UserId,Name FROM Suspect";
        SqlDataAdapter a = new SqlDataAdapter(myc);
        DataSet ds = new DataSet();
        try
        {
            myCon.Open();
            a.Fill(ds, "Suspect");
         
        }
        catch (Exception ex)
        {
            
        }
        finally
        {
            myCon.Close();
        }
        foreach (DataRow row in ds.Tables["Suspect"].Rows)
        {
            ListItem newItem = new ListItem();
            newItem.Text = (row["UserId"]).ToString();
            newItem.Value = row["UserId"].ToString();
            DropDownList1.Items.Add(newItem);
     
        }

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        SqlCommand myc = new SqlCommand();
        myc.Connection = myCon;
        myc.CommandText = "SELECT UserId,Name FROM Suspect where UserId=@UserId";
        myc.Parameters.AddWithValue("@UserId",DropDownList1.SelectedItem.Value);
        SqlDataReader reader;
        try
        {
            myCon.Open();
            reader = myc.ExecuteReader();
            reader.Read();
            StringBuilder sb = new StringBuilder();
            sb.Append("User Id: ");
            sb.Append(reader["UserId"]);
            sb.Append(", ");
            sb.Append("Name: ");
            sb.Append(reader["Name"]);
            sb.Append("\n");
            TextBox1.Text = sb.ToString();
            reader.Close();
        }
        catch (Exception err)
        {
            
        }
        finally
        {
            myCon.Close();
        }
        
     }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("cms.aspx");
    }
}