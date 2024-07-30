using EmployeesInformation.Models;
using System.Data.SqlClient;

namespace EmployeesInformation
{
    public class EmployeesDataStore
    {
        public List<Employee> Employees { get; set; }
        public static EmployeesDataStore current { get; } = new EmployeesDataStore();

        public EmployeesDataStore() 
        {
            SqlConnection con = null;
            try
            {
                string connectionString = "Server=WSAMZN-FK6DHHFM;Database=EmployeesDatabase;User Id=sa;Password=Password@123;";
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                string sqlQuery = "SELECT * FROM Employee";
                SqlCommand command = new SqlCommand(sqlQuery, con);
                SqlDataReader reader = command.ExecuteReader();
                Employees = new List<Employee>();
                while (reader.Read())
                {
                    //Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3] + " " + reader[4] + " " + reader[5] + " " + reader[6] + " " + reader[7] + " " + reader[8] + " " + reader[9]);
                    Employees.Add(
                        new Employee(){Id=int.Parse(reader["Id"].ToString()),Name=reader["Name"].ToString(),JobTitle=reader["JobTitle"].ToString(),Salary=double.Parse(reader["Salary"].ToString()) }
                    );
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
            //Employees = new List<Employee>()
            //{

            //    new Employee(){Id=1,Name="Pavi",JobTitle="Software Engineer",Salary=35000.00 },
            //    new Employee(){Id=2,Name="Ravi",JobTitle="Software Engineer2",Salary=135000.00 },
            //    new Employee(){Id=3,Name="Prasanna",JobTitle="Firmware Engineer",Salary=105000.00 },
            //    new Employee(){Id=4,Name="Suresh",JobTitle="Accountant",Salary=235000.00 }

            //};
        }
    }
}
