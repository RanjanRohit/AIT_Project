using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class changepw : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        string upd = "Update LoginTable SET UserPw=@UserPw WHERE UserId=@UserIdO";
        SqlCommand myc = new SqlCommand(upd, myCon);
        myc.Parameters.AddWithValue("@UserIdO", Request.QueryString["ui"]);
        myc.Parameters.AddWithValue("@UserPw", TextBox1.Text);
        int updated = 0;
        try
        {
            myCon.Open();
            updated = myc.ExecuteNonQuery();
            Label1.Text = updated.ToString()+" Record is uodated";
        }
        catch (Exception err)
        {
        }
        finally
        {
            myCon.Close();
        }
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("cms.aspx");
    }
}