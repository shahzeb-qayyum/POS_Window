using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Models;
using System.Data.SqlClient;
namespace PointOfSale
{
    public class Customer_Repository
    {
        public bool Insert (Customers obj)
        {

            string query = @"insert into Customer(Firstname,Lastname,DateOfBirth,
                             Email,Pone,House_no,Street,City)";
            query += @"values('" + obj.Firstname + "','" + obj.Lastname + "','" + obj.DateOfBirth +"','" +obj.Email + "','"+obj.Phone + "','"+obj.House_no + "','"+ obj.Street + "','"+obj.City + "')";
            string connectionString = "";
        }
    }
}
