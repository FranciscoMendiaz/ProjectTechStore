﻿using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class DataUser
    {
        #region GET BY EMAIL & PASSWORD
        public User getByEmailPassword(string email, string password)
        {
            User user = new User();
            DataUserRole role = new DataUserRole();
            int idUserRole = 0;
            
            try
            {
                string query = @"SELECT users.email, users.password, users.first_name, users.last_name, users.address, users.id_user_role FROM users 
                                WHERE (users.email = @Email AND users.password = @Password )";

                SqlParameter mail = new SqlParameter("@Email", email);
                SqlParameter pass = new SqlParameter("@Password", password);

                using (SqlCommand command = new SqlCommand(query, Data.getInstance().getMyConn()))
                {
                    command.Parameters.Add(mail);
                    command.Parameters.Add(pass);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
                }
            }
            catch (Exception) { throw; }
            
            finally 
            { 
                Data.getInstance().releaseMyConn();
                if (user != null) { user.Role = role.getOne(idUserRole); }
            }
            return user;
        }
        #endregion

        #region GET ONE
        public User getOne(string email)
        {
            User user = new User();
            DataUserRole role = new DataUserRole();
            int idUserRole = 0;

            try
            {
                string query = @"SELECT email, password, first_name, last_name, address, id_user_role FROM users 
                                WHERE users.email = @Email";

                SqlParameter mail = new SqlParameter("@Email", email);
                
                using (SqlCommand command = new SqlCommand(query, Data.getInstance().getMyConn()))
                {
                    command.Parameters.Add(mail);
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
                }
            }
            catch (Exception) { throw; }

            finally 
            { 
                Data.getInstance().releaseMyConn();
                if (user != null) { user.Role = role.getOne(idUserRole);}
            }
            return user;
        }
        #endregion

        #region CREATE 
        public void create(User user)
        {

            try
            {
                string query = @"INSERT INTO users (email, first_name, last_name, password, address, id_user_role)
                                VALUES(@Email, @First_name, @Last_name, @Password, @Address, @Id_User_Role)";


                SqlParameter mail = new SqlParameter("@Email", user.Email);
                SqlParameter firstName = new SqlParameter("@First_name", user.FirstName);
                SqlParameter lastName = new SqlParameter("@Last_name", user.LastName);
                SqlParameter pass = new SqlParameter("@Password", user.Password);
                SqlParameter address = new SqlParameter("@Address", user.Address);
                SqlParameter idUserRole = new SqlParameter("@Id_User_Role", user.Role.Id);


                using (SqlCommand command = new SqlCommand(query, Data.getInstance().getMyConn()))
                {
                    command.Parameters.Add(mail);
                    command.Parameters.Add(firstName);
                    command.Parameters.Add(lastName);
                    command.Parameters.Add(pass);
                    command.Parameters.Add(address);
                    command.Parameters.Add(idUserRole);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception) { throw; }

            finally { Data.getInstance().releaseMyConn(); }

        }
        #endregion 

    }
}



