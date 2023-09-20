
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Model;
using System.Data.SqlClient;
namespace PointOfSale.Databaselayer
{
    public class CustomerRepository
    {
        public bool Insert(Customer obj)
        {
            string query = @" insert into Customer(Firstname,Lastname,DBO,Emailaddress,Phone,House_no,Street,City)";
            query += @"values('"+ obj.Firstname +"','"+ obj.Lastname +"','"+ obj.Dateofbirth +"','"+ obj.Email +"',''"+ obj.House_no +",'"+ obj.Street +"','"+ obj.City +"')";
            string connectionstring = "Data source = SHERALI\\SQLEXPRESS; intial catelog = PointOfSale; integrated security SSPI";
            SqlConnection myconnection = new SqlConnection(connectionstring);
            myconnection.Open();
            SqlCommand mycommand = new SqlCommand();
            mycommand.Connection = myconnection;
            mycommand.CommandType = System.Data.CommandType.Text;
            mycommand.CommandText = query;
            mycommand.ExecuteNonQuery();
            myconnection.Close();
            return true;
        }



    }
}
