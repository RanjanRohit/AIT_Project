using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Data.SqlClient;

public partial class change : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        string ins = "Insert into LoginTable(UserId,UserPw)values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
        SqlCommand myc = new SqlCommand(ins, myCon);
        int added = 0;
        try
        {
            myCon.Open();
            added = myc.ExecuteNonQuery();
            Label3.Text = added.ToString() + " records inserted.";
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
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        string upd = "Update LoginTable SET UserId =@UserId,UserPw=@UserPw WHERE UserId=@UserIdOriginal";
        SqlCommand myc = new SqlCommand(upd, myCon);
        myc.Parameters.AddWithValue("@UserId", TextBox3.Text);
        myc.Parameters.AddWithValue("@UserPw", TextBox4.Text);
        myc.Parameters.AddWithValue("@UserIdOriginal", TextBox5.Text);
        int updated = 0;
        try
        {
            myCon.Open();
            updated = myc.ExecuteNonQuery();
            Label6.Text = updated.ToString() + " records updated.";
        }
        catch (Exception err)
        {
        }
        finally
        {
            myCon.Close();
        }
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("cms.aspx");
    }
}