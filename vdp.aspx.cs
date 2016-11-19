using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Text;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class vdp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            FillTheList();
    }
    private void FillTheList()
    {
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        SqlCommand myc = new SqlCommand();
        myc.Connection = myCon;
        myc.CommandText = "SELECT * FROM dpr";
        SqlDataAdapter a = new SqlDataAdapter(myc);
        DataSet ds = new DataSet();
        try
        {
            myCon.Open();
            a.Fill(ds,"dpr");

        }
        catch (Exception ex)
        {

        }
        finally
        {
            myCon.Close();
        }
        foreach (DataRow row1 in ds.Tables["dpr"].Rows)
        {
            ListItem newItem = new ListItem();
            newItem.Text = (row1["Date"]).ToString();
            newItem.Value = row1["CarId"].ToString();
            DropDownList1.Items.Add(newItem);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("cms.aspx");
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection myCon = new SqlConnection();
        myCon.ConnectionString = @"Data Source=MIT-DEPT-C03032\SQLEXPRESS;Initial Catalog = Coolio;Integrated Security = True";
        SqlCommand myc = new SqlCommand();
        myc.Connection = myCon;
        myc.CommandText = "SELECT CarId,VName,UserId FROM dpr where CarId=@CarId";
        myc.Parameters.AddWithValue("@CarId", DropDownList1.SelectedItem.Value);
        SqlDataReader reader;
        try
        {
            myCon.Open();
            reader = myc.ExecuteReader();
            reader.Read();
            StringBuilder sb = new StringBuilder();
            sb.Append("Car Id: ");
            sb.Append(reader["CarId"]);
            sb.Append(", ");
            sb.Append("VName: ");
            sb.Append(reader["VName"]);
            sb.Append(", ");
            sb.Append("UserId: ");
            sb.Append(reader["UserId"]);
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
}