// See https://aka.ms/new-console-template for more information
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
class program
{
    //string conString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

    static void Main(String[] args)
    {
        try
        {
            DataTable dataTable = new DataTable("Student2");
            DataColumn Id = new DataColumn()
            {
                DataType = System.Type.GetType("System.Int32"),
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1,
            };
            dataTable.Columns.Add(Id);
            DataColumn Name = new DataColumn("Name");
            Name.DataType = typeof(string);
            Name.MaxLength = 100;
            Name.AllowDBNull = false;
            dataTable.Columns.Add(Name);
            DataColumn Email = new DataColumn("Email");
            Email.DataType = typeof(string);
            Email.MaxLength = 100;
            Email.AllowDBNull = true;
            dataTable.Columns.Add(Email);
            dataTable.PrimaryKey = new DataColumn[] {Id };
            //Insert data 
            DataRow row1 = dataTable.NewRow();
            
            dataTable.Rows.Add(null, "Lucy", "lucy202@mail.com");
            foreach (DataRow r1 in dataTable.Rows)
            {
                Console.WriteLine(r1["Id"] + " " + r1["Name"] + " " + r1["Email"]);
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Something went wrong {ex}");
        }
        

    }
}  

