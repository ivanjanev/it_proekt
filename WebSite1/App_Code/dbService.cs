using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;

/// <summary>
/// Summary description for dbService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class dbService : System.Web.Services.WebService
{

    public dbService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld(string keyword)
    {
        return keyword;
    }

    [WebMethod]
    public string GetOglasi()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=DESKTOP-9HFTRQR"+"\\"+"SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        SqlCommand command = new SqlCommand();
        command.CommandText = "SELECT * FROM Oglasi";
        command.Connection = con;

        var details = new List<Dictionary<string, object>>();

        try
        {
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                var dict = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dict.Add(reader.GetName(i), reader.IsDBNull(i) ? null : reader.GetValue(i));
                }

                details.Add(dict);
            }
            reader.Close();
            
        }
        catch (Exception err)
        {
            return err.Message;
        }
        finally
        {
            con.Close();
        }
        JavaScriptSerializer jss = new JavaScriptSerializer();
        string jsonDoc = jss.Serialize(details);
        return jsonDoc;
    }

    [WebMethod]
    public string getAdvertById(int id)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=DESKTOP-9HFTRQR" + "\\" + "SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        SqlCommand command = new SqlCommand();
        command.CommandText = "SELECT * FROM Oglasi WHERE id='"+id+"'";
        command.Connection = con;

        var details = new List<Dictionary<string, object>>();

        try
        {
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                var dict = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dict.Add(reader.GetName(i), reader.IsDBNull(i) ? null : reader.GetValue(i));
                }

                details.Add(dict);
            }
            reader.Close();

        }
        catch (Exception err)
        {
            return err.Message;
        }
        finally
        {
            con.Close();
        }
        JavaScriptSerializer jss = new JavaScriptSerializer();
        string jsonDoc = jss.Serialize(details);
        return jsonDoc;
    }

    [WebMethod]
    public string getAdvertByCategory(string category)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=DESKTOP-9HFTRQR" + "\\" + "SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        SqlCommand command = new SqlCommand();
        command.CommandText = "SELECT * FROM Oglasi WHERE category LIKE '%"+category+"%'";
        command.Connection = con;

        var details = new List<Dictionary<string, object>>();

        try
        {
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                var dict = new Dictionary<string, object>();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dict.Add(reader.GetName(i), reader.IsDBNull(i) ? null : reader.GetValue(i));
                }

                details.Add(dict);
            }
            reader.Close();

        }
        catch (Exception err)
        {
            return "this is the error--> " +  err.Message;
        }
        finally
        {
            con.Close();
        }
        JavaScriptSerializer jss = new JavaScriptSerializer();
        string jsonDoc = jss.Serialize(details);
        return jsonDoc;
    }

    [WebMethod]
    public string addAdvert(string company,string title,string category,string description,string fromDate,string toDate)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=DESKTOP-9HFTRQR" + "\\" + "SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        SqlCommand command = new SqlCommand();
        command.CommandText = "INSERT INTO Oglasi (company,title,description,category,fromDate,toDate) VALUES (@company,@title,@description,@category,@fromDate,@toDate)";
        command.Connection = con;

        command.Parameters.AddWithValue("@company", company);
        command.Parameters.AddWithValue("@title", title);
        command.Parameters.AddWithValue("@description", description);
        command.Parameters.AddWithValue("@category", category);
        command.Parameters.AddWithValue("@fromDate", fromDate);
        command.Parameters.AddWithValue("@toDate", toDate);

        try
        {
            con.Open();
            command.ExecuteNonQuery();

        }
        catch (Exception err)
        {
            return err.Message;
        }
        finally
        {
            con.Close();
        }

        return "Success";
    }

}
