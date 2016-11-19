using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class Default5 : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            fillReport();
            fillReport2();
        }
    }
    private void fillReport()
    {
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        SqlCommand myc = new SqlCommand();
        myc.Connection = myCon;
        myc.CommandText = "SELECT UserId,Name FROM Suspect";
        SqlDataAdapter a = new SqlDataAdapter(myc);
        DataSet ds = new DataSet();
        StreamWriter w = File.CreateText(@"I:\myfile.txt");
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
           string x= row["UserId"].ToString() + "," + row["Name"].ToString() + "\n";
           TextBox1.Text += x;
           w.WriteLine(x);
        }
        w.Close();
    }
    private void fillReport2()
    {
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        SqlCommand myc = new SqlCommand();
        myc.Connection = myCon;
        int xe = 0;
        myc.CommandText = "SELECT UserId FROM LoginTable";
        SqlDataAdapter a = new SqlDataAdapter(myc);
        DataSet ds = new DataSet();
        StreamWriter w = File.CreateText(@"I:\myfile1.txt");
        try
        {
            myCon.Open();
            a.Fill(ds, "LoginTable");

        }
        catch (Exception ex)
        {

        }
        finally
        {
            myCon.Close();
        }
        foreach (DataRow row in ds.Tables["LoginTable"].Rows)
        {
           xe++;
          
        }
        w.Write("No. of members= ");
        w.Write(xe.ToString());
        w.Close();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("cms.aspx");
    }
}