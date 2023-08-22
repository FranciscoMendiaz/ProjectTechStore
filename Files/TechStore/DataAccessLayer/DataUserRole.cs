using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataUserRole
    {
        #region GET ROLE
        public UserRole getRole(int idRole)
        {
            UserRole role = new UserRole();
            try
            {
               
                string query = @"SELECT id, description FROM user_roles
                                WHERE (user_roles.id = @Id)";

                SqlParameter anId = new SqlParameter("@Id", idRole);

                using (SqlCommand command = new SqlCommand(query, Data.getInstance().getMyConn()))
                {
                    command.Parameters.Add(anId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
                }
            }
            
            catch (Exception) { throw; }

            finally { Data.getInstance().releaseMyConn(); }

            return role;

        }
        #endregion
    }
}
