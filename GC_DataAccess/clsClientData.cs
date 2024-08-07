using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace CarsManagement_DataAccess
{
    public class clsClientData
    {
        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT * FROM Clients_View  Order By ClientID Desc;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        // Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return dt;
        }

        public static bool GetClientInfoClientID(int ClientID, ref string CarName, ref string ChassisNumber, ref string OwnerName,
            ref string CarColor, ref string Description, ref DateTime StartDate, ref DateTime EndDate, ref string CardValidityPeriod)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "SELECT * FROM Clients_View WHERE ClientID = @ClientID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // The record was found
                                isFound = true;

                                CarName = (string)reader["CarName"];
                                ChassisNumber = (string)reader["ChassisNumber"];
                                OwnerName = (string)reader["OwnerName"];
                                CarColor = (string)reader["CarColor"];
                                Description = (string)reader["Description"];
                                StartDate = (DateTime)reader.GetSqlDateTime(reader.GetOrdinal("StartDate"));
                                EndDate = (DateTime)reader.GetSqlDateTime(reader.GetOrdinal("EndDate"));
                                CardValidityPeriod = (string)reader["CardValidityPeriod"];

                                TimeSpan ts = DateTime.Now - EndDate;
                                int Days = ts.Days;
                            }
                            else
                            {
                                // The record was not found
                                isFound = false;
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine("Error: " + ex.Message);
                        isFound = false;
                    }

                    return isFound;
                }
            }
        }

        public static int AddNewClient(string OwnerName, string CarName, string ChassisNumber, string CarColor, string Description, DateTime StartDate, DateTime EndDate)
        {
            // this function will return the new ClientID id if succeeded and -1 if not.
            int ClientID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"INSERT INTO Clients (OwnerName, CarName, ChassisNumber, CarColor, Description, StartDate, EndDate)
                         VALUES (@OwnerName, @CarName, @ChassisNumber, @CarColor, @Description, @StartDate, @EndDate);
                         SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OwnerName", OwnerName);
                    command.Parameters.AddWithValue("@CarName", CarName);
                    command.Parameters.AddWithValue("@ChassisNumber", ChassisNumber);
                    command.Parameters.AddWithValue("@CarColor", CarColor);
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);

                    try
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            ClientID = insertedID;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception (e.g., log it)
                        // Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return ClientID;
        }

        public static bool DeleteClientByID(int ClientID)
        {
            int RowAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = "delete from Clients where ClientID = @ClientID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    connection.Open();
                    RowAffected = command.ExecuteNonQuery();
                }

            }

            return (RowAffected > 0);
        }

        public static bool UpdateClient(int ClientID, string CarName, string ChassisNumber, string OwnerName,
            string CarColor, string Description, DateTime StartDate, DateTime EndDate)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string sql = "UPDATE Clients SET " +
                             "CarName = @CarName, " +
                             "ChassisNumber = @ChassisNumber, " +
                             "OwnerName = @OwnerName, " +
                             "CarColor = @CarColor, " +
                             "Description = @Description, " +
                             "StartDate = @StartDate, " +
                             "EndDate = @EndDate " +
                             "WHERE ClientID = @ClientID";
                
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ClientID", ClientID);
                    command.Parameters.AddWithValue("@CarName", CarName);
                    command.Parameters.AddWithValue("@ChassisNumber", ChassisNumber);
                    command.Parameters.AddWithValue("@OwnerName", OwnerName);
                    command.Parameters.AddWithValue("@CarColor", CarColor);
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@StartDate", StartDate);
                    command.Parameters.AddWithValue("@EndDate", EndDate);

                    try
                    {
                        connection.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine("Error updating data: " + ex.Message);
                    }
                }
            }

            return (rowsAffected > 0);
        }
    }
}
