using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class usesys : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Redirect("enter.aspx?id="+TextBox1.Text);
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        SqlCommand myc = new SqlCommand();
        myc.Connection = myCon;
        myc.CommandText = "SELECT UserId FROM Suspect";
        SqlDataAdapter a = new SqlDataAdapter(myc);
        DataSet ds = new DataSet();
        int x = 0;
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
        string s =TextBox1.Text;
        foreach (DataRow r in ds.Tables["Suspect"].Rows)
        {
            if (string.Equals(s, r["UserId"].ToString()))
            {
                Label2.Text = "Not allowed to enter the car park.";
                x = 1;
                break;
            }
            
        }
        if(x==0)
          Response.Redirect("Default6.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default3.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}