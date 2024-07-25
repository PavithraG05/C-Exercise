using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
    }
}
