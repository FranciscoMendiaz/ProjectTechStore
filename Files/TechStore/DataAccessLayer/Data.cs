using EntitiesLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Data
    {
       
        private SqlConnection myConn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Tech-Store;Data Source=DESKTOP-SLFI33K\\SQLEXPRESS");

        #region GET USER
        public User getUser(string email, string password)
        {
            int idUserRole =0;
            User user = new User();
            try { 
                myConn.Open();

                string query = @"SELECT email, password, first_name, last_name, address, id_user_role FROM users 
                                WHERE (users.email = @Email AND users.password = @Password )";

                

                SqlParameter mail = new SqlParameter("@Email", email);
                SqlParameter pass = new SqlParameter("@Password", password);

                SqlCommand command = new SqlCommand(query, myConn);

                command.Parameters.Add( mail );
                command.Parameters.Add( pass );

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    user.Email = reader["email"].ToString();
                    user.Password = reader["password"].ToString();
                    user.LastName = reader["last_name"].ToString();
                    user.FirstName = reader["first_name"].ToString();
                    user.Address = reader["address"].ToString();
                    idUserRole = int.Parse(reader["id_user_role"].ToString());
                    

                }
                
                else
                {
                    user = null;
                }

            }
            catch (Exception) { throw; }
            
            finally { myConn.Close();}

            if (user != null) { user.Role = this.getRole(idUserRole); }
            
            return user;

        }

        #endregion

        #region GET ROLE
        public UserRole getRole(int idRole)
        {
            UserRole role = new UserRole();
            try
            {
                myConn.Open();

                string query = @"SELECT id, description FROM user_roles
                                WHERE (user_roles.id = @Id)";

                SqlParameter anId = new SqlParameter("@Id", idRole);
                

                SqlCommand command = new SqlCommand(query, myConn);

                command.Parameters.Add(anId);
                

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    role.Id = int.Parse(reader["id"].ToString());
                    role.Description = reader["description"].ToString();
                    
                }

                else
                {
                    role = null;
                }

            }
            catch (Exception) { throw; }

            finally { myConn.Close(); }

            return role;

        }

        #endregion








    }
}