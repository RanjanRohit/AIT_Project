using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        SqlCommand myc = new SqlCommand();
        myc.Connection = myCon;
        myc.CommandText = "SELECT * FROM LoginTable";
        SqlDataAdapter a = new SqlDataAdapter(myc);
        DataSet ds = new DataSet();
        try
        {
            myCon.Open();
            a.Fill(ds, "LoginTable");

        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
        finally
        {
            myCon.Close();
        }
        string un = (TextBox1.Text).ToString();
        int i = TextBox2.Text.Length;
        for (int j = 0; j < 10 - i; j++)
            TextBox2.Text += " ";
        foreach (DataRow r in ds.Tables["LoginTable"].Rows)
        {
            if (string.Equals(un, r["UserId"].ToString()))
            {
                if (string.Equals(TextBox2.Text, r["UserPw"]))
                Response.Redirect("changepw.aspx?ui="+r["UserId"].ToString());
            }
            else
            Label1.Text = "Invalid login.";

        }

    }
}