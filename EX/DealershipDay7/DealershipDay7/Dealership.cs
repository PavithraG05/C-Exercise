using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace DealershipDay7
{
    public class Dealership
    {
        public void displayCars()
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = "SELECT * FROM Cars";
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]+" "+ reader[1]+" "+ reader[2]+" "+ reader[3]+" "+ reader[4]+" "+ reader[5]+" "+ reader[6]+" "+ reader[7]+" "+ reader[8]+" "+ reader[9]);
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

        public void getCarsbasedonOdometer(int x)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = $"select inventory_number,make,model,odometer_reading from Cars where odometer_reading < {x}";
                Console.WriteLine(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]+" " + reader[3]);
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

        public void showCarMake()
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = "SELECT Distinct(make) FROM Cars";
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

        public void showCarModel(string make)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = $"SELECT Distinct(model) FROM Cars where make='{make}'";
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

        public void getCarsbasedonmodelmake(string make, string model)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = $"select inventory_number,make,model,odometer_reading from Cars where make = '{make}' and model ='{model}'";
                Console.WriteLine(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3]);
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

        public void getCarsbasedonPrice(double x, double y)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = $"select inventory_number,make,model, price from Cars where price > {x} and price < {y}";
                Console.WriteLine(sqlQuery);
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2]+" " + reader[3]);
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

        public void showCardata(string iv)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = $"SELECT * FROM Cars where inventory_number = '{iv}'";
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

        public void insertCar(string iv, DateOnly sale_date, string name, string number, string payment, double amnt)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";

                // Creating Connection  
                con = new SqlConnection(connectionString);
                // writing sql query  
                string sqlQuery = $"insert into Sales (inventory_number, sales_date, customer_name, customer_phone, payment_method, payment_amount) VALUES    ('{iv}', '{sale_date}', '{name}', '{number}', '{payment}', {amnt});";
                SqlCommand cm = new SqlCommand(sqlQuery, con);
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
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

        public void updateStatus(string iv)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";

                // Creating Connection  
                con = new SqlConnection(connectionString);
                // writing sql query  
                string sqlQuery = $"update Cars set status = 'sold' where inventory_number = '{iv}'";
                SqlCommand cm = new SqlCommand(sqlQuery, con);
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record updated Successfully");
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

        public void updatePrice(string iv, double pr)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";

                // Creating Connection  
                con = new SqlConnection(connectionString);
                // writing sql query  
                string sqlQuery = $"update Cars set price = {pr} where inventory_number = '{iv}'";
                SqlCommand cm = new SqlCommand(sqlQuery, con);
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record updated Successfully");
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

        public void deletecar(string ivn)
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=Dealership;User Id=sa;Password=Password@123;";

                // Creating Connection  
                con = new SqlConnection(connectionString);
                // writing sql query  
                string sqlQuery = $"delete from Cars where inventory_number = '{ivn}'";
                SqlCommand cm = new SqlCommand(sqlQuery, con);
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record deleted Successfully");
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
