using Microsoft_sql_test_environment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace Microsoft_sql_test_environment.Repository
{
    public class UserRepository
    {
        string provider = ConfigurationManager.AppSettings["provider"];
        string connectionString = ConfigurationManager.AppSettings["connectionString"];
        string connectionStringTestDatabase = ConfigurationManager.AppSettings["connectionStringTestDatabase"];
        SqlConnection connection;
        public UserRepository()
        {
            connection = new SqlConnection(connectionStringTestDatabase);
        }
        public List<User> addUsers(List<User> users)
        {
            using (var connection = new SqlConnection(connectionStringTestDatabase))
            {
                connection.Open();
                foreach (User user in users)
                {
                    var sql = "INSERT INTO [User](UserId, FullName, Email, " +
                    " Country, CreatedAt, FirstNumber, SecondNumber) VALUES(@UserId, @FullName," +
                    "@Email, @Country, @CreatedAt, @FirstNumber, @SecondNumber)";
                    using (var cmd = new SqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserId", user.UserId);
                        cmd.Parameters.AddWithValue("@FullName", user.FullName);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@Country", user.Country);
                        cmd.Parameters.AddWithValue("@CreatedAt", user.CreatedAt);
                        cmd.Parameters.AddWithValue("@FirstNumber", user.FirstNumber);
                        cmd.Parameters.AddWithValue("@SecondNumber", user.SecondNumber);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            return users;
        }
        public async Task<List<User>> GetTop10000FromUsers()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<User> users = new List<User>();
            try
            {
                
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT TOP 50000 * FROM [User]", connection);
                
                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {
                    User user = new User();
                    user.UserId = Convert.ToInt64(reader["UserId"].ToString());
                    user.FullName = reader["FullName"].ToString();
                    user.Country = reader["Email"].ToString();
                    user.Email = reader["Country"].ToString();
                    user.CreatedAt = reader["CreatedAt"].ToString();
                    user.FirstNumber = Convert.ToInt32(reader["FirstNumber"].ToString());
                    user.SecondNumber = Convert.ToInt32(reader["SecondNumber"].ToString());
                    users.Add(user);
                }
                if (reader != null)
                {
                    reader.Close();
                }
            } catch(Exception e)
            {
                Console.WriteLine("unsuccesfull read");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Top 50000 lasted: " + elapsedMs +"ms");

            return users;
        }
        public async Task<List<User>> GetSetRowCount50000FromUsers()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<User> users = new List<User>();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand("SET ROWCOUNT 50000;  SELECT * FROM [User]" +
                "WHERE SecondNumber < 300; ", connection);

                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {
                    User user = new User();
                    user.UserId = Convert.ToInt64(reader["UserId"].ToString());
                    user.FullName = reader["FullName"].ToString();
                    user.Country = reader["Email"].ToString();
                    user.Email = reader["Country"].ToString();
                    user.CreatedAt = reader["CreatedAt"].ToString();
                    user.FirstNumber = Convert.ToInt32(reader["FirstNumber"].ToString());
                    user.SecondNumber = Convert.ToInt32(reader["SecondNumber"].ToString());
                    users.Add(user);
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("unsuccesfull read");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Set RowCount lasted: " + elapsedMs + "ms");

            return users;
        }
        public async Task<List<int>> GetDivisionResultFromUsers()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<int> results = new List<int>();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand("SELECT SecondNumber/5 AS 'result' FROM [User]", 
                    connection);

                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {
                  
                    results.Add(Convert.ToInt32(reader["result"].ToString()));
                    
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Get division results lasted: " + elapsedMs + "ms");

            return results;
        }
        public async Task<List<string>> GetConcatenationResultFromUsers()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<string> concatenationResults = new List<string>();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand("SELECT FullName + Email + Country AS 'result' FROM [User]",
                    connection);

                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {

                    concatenationResults.Add(reader["result"].ToString());

                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Get string concatenation lasted: " + elapsedMs + "ms");

            return concatenationResults;
        }
        public async Task<List<User>> GetExceptFromUsers()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<User> users = new List<User>();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * INTO #TemporaryTable FROM [User];"+
                                        "ALTER TABLE #TemporaryTable DROP COLUMN FullName;"+
                                        "SELECT * FROM #TemporaryTable;"+ 
                                        "DROP TABLE #TemporaryTable;  ", connection);

                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {
                    User user = new User();
                    user.UserId = Convert.ToInt64(reader["UserId"].ToString());
                    user.FullName = reader["FullName"].ToString();
                    user.Country = reader["Email"].ToString();
                    user.Email = reader["Country"].ToString();
                    user.CreatedAt = reader["CreatedAt"].ToString();
                    user.FirstNumber = Convert.ToInt32(reader["FirstNumber"].ToString());
                    user.SecondNumber = Convert.ToInt32(reader["SecondNumber"].ToString());
                    users.Add(user);
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Select Except lasted: " + elapsedMs + "ms");

            return users;
        }
        public async Task<List<User>> GetReplaceFromUsers()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            List<User> users = new List<User>();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * INTO TemporaryTable FROM [User];"+
                        "UPDATE TemporaryTable set FirstNumber = FirstNumber / 2"+
                        "SELECT * FROM TemporaryTable;"+
                        "DROP TABLE TemporaryTable; ", connection);

                SqlDataReader reader = await command.ExecuteReaderAsync();

                while (reader.Read())
                {
                    User user = new User();
                    user.UserId = Convert.ToInt64(reader["UserId"].ToString());
                    user.Country = reader["Email"].ToString();
                    user.Email = reader["Country"].ToString();
                    user.CreatedAt = reader["CreatedAt"].ToString();
                    user.FirstNumber = Convert.ToInt32(reader["FirstNumber"].ToString());
                    user.SecondNumber = Convert.ToInt32(reader["SecondNumber"].ToString());
                    users.Add(user);
                }
                if (reader != null)
                {
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Select Except lasted: " + elapsedMs + "ms");

            return users;
        }
    }
}
