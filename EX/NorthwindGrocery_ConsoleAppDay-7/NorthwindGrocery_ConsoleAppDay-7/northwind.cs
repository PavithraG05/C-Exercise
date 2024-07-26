using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace NorthwindGrocery_ConsoleAppDay_7
{
    public class northwind
    {   
        public void getCategories()
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=demo;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = "SELECT * FROM Categories";
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["CategoryID"] + " " + reader["CategoryName"] + " " + reader["Description"]+" "+ reader["Picture"]);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
        
        public void displayCategories()
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=demo;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = "SELECT CategoryName FROM Categories";
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine( reader["CategoryName"]);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        public bool CategoryExists(string category)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=demo;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = "SELECT Count(*) as Count FROM Categories where CategoryName ="+ $"'{category}'";
                Console.WriteLine(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                int rowCount = (int)command.ExecuteScalar();
                if (rowCount > 0)
                {
                    return true;
                }
                    
                else
                {
                    return false;
                }
               
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
                return false;
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        public void getCategoryProduct(string category)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=demo;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = "Select * from Products where CategoryID in (SELECT CategoryID FROM Categories where CategoryName =" + $"'{category}')";
                Console.WriteLine(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]+" " + reader[1]+" " + reader[2]+" " + reader[3]+" " + reader[4]+" " + reader[5]+" " + reader[6]+" " + reader[7]+" " + reader[8]+" "+reader[9]);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
               
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        public void getProductsbasedonPrice(double x, double y)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=demo;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = $"select ProductID, ProductName, UnitPrice from Products where UnitPrice > {x} and UnitPrice < {y}";
                Console.WriteLine(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);

            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        public void getSuppliers()
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=demo;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = $"select CompanyName from Suppliers";
                Console.WriteLine(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);

            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        public bool SupplierExists(string supplier)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=demo;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = "SELECT Count(*) as Count FROM Suppliers where CompanyName =" + $"'{supplier}'";
                Console.WriteLine(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                int rowCount = (int)command.ExecuteScalar();
                if (rowCount > 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
                return false;
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }

        public void getSupplierProduct(string supplier)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=demo;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = "Select * from Products where SupplierID in (SELECT SupplierID FROM Suppliers where CompanyName =" + $"'{supplier}')";
                Console.WriteLine(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3] + " " + reader[4] + " " + reader[5] + " " + reader[6] + " " + reader[7] + " " + reader[8] + " " + reader[9]);
                }
                reader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);

            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
