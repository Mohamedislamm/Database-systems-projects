using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace DataBase
{
    public static class Session
    {
        public static User CurrentUser { get; private set; }

        public static bool Login(string username, string password)
        {
            // Authenticate user and get user information
            User authenticatedUser = AuthenticateUser(username, password);

            if (authenticatedUser != null)
            {
                CurrentUser = authenticatedUser;
                return true;
            }
            return false;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }

        private static User AuthenticateUser(string username, string password)
        {
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                // Check if user exists
                string checkUserQuery = "SELECT COUNT(*) FROM [USER] WHERE USERNAME = @USERNAME OR EMAIL = @EMAIL AND PASSWORD = @PASSWORD";
                SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, conn);
                checkUserCommand.Parameters.AddWithValue("@USERNAME", username);
                checkUserCommand.Parameters.AddWithValue("@EMAIL", username);
                checkUserCommand.Parameters.AddWithValue("@PASSWORD", password);
                int existingUserCount = (int)checkUserCommand.ExecuteScalar();
                Console.WriteLine(existingUserCount);

                if (existingUserCount > 0)
                {
                    // User exists, get user information
                    string getUserQuery = "SELECT [USER].USERID, FIRSTNAME, LASTNAME, USERNAME, EMAIL, USERTYPE, GENDER, ADDRESS, AGE, PHONENUM FROM [USER] INNER JOIN USER_PHONE ON USER_PHONE.USERID=[USER].USERID WHERE USERNAME = @USERNAME OR EMAIL = @EMAIL";
                    SqlCommand getUserCommand = new SqlCommand(getUserQuery, conn);
                    getUserCommand.Parameters.AddWithValue("@USERNAME", username);
                    getUserCommand.Parameters.AddWithValue("@EMAIL", username);
                    User usr = new User();
                    using (SqlDataReader reader = getUserCommand.ExecuteReader())
                    {
                        
                        if (reader.Read())
                        {
                            int userId = reader.GetInt32(reader.GetOrdinal("USERID"));
                            string firstname = reader.GetString(reader.GetOrdinal("FIRSTNAME"));
                            string lastname = reader.GetString(reader.GetOrdinal("LASTNAME"));
                            username = reader.GetString(reader.GetOrdinal("USERNAME"));
                            string email = reader.GetString(reader.GetOrdinal("EMAIL"));
                            string role = reader.GetString(reader.GetOrdinal("USERTYPE"));
                            string gender = reader.GetString(reader.GetOrdinal("GENDER"));
                            string address = reader.GetString(reader.GetOrdinal("ADDRESS"));
                            int age = reader.GetInt32(reader.GetOrdinal("AGE"));
                            string phonenumber = reader.GetString(reader.GetOrdinal("PHONENUM"));
                            
                            usr.Username = username;
                            usr.Password = password;
                            usr.FirstName = firstname;
                            usr.LastName = lastname;
                            usr.UserID = userId;
                            usr.Gender = gender;
                            usr.Email = email;
                            usr.Address = address;
                            usr.Role = role;
                            usr.Age = age;
                            usr.Phone = phonenumber;
                        }
                    }
                    return usr;
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }
    }   
}
