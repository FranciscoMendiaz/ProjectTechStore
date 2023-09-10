using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace DataAccessLayer
{
    public class DataPaymentType
    {
        #region CREATE  
        public void create(PaymentType paymentType)
        {
            try
            {
                string query = @"INSERT INTO payment_types (description)
                                VALUES(@Description)";


                SqlParameter description = new SqlParameter("@Description", paymentType.Description);
              
                using (SqlCommand command = new SqlCommand(query, Data.getInstance().getMyConn()))
                {
                    command.Parameters.Add(description);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception) { throw; }

            finally { Data.getInstance().releaseMyConn(); }

        }
        #endregion

        #region UPDATE
        public void update(PaymentType paymentType)
        {
            try
            {
                string query = @"UPDATE payment_types 
                                SET payment_types.description = @Description
                                WHERE payment_types.id = @Id";

                SqlParameter description = new SqlParameter("@Description", paymentType.Description);
                SqlParameter id = new SqlParameter("@Id", paymentType.Id);

                using (SqlCommand command = new SqlCommand(query, Data.getInstance().getMyConn()))
                {
                    command.Parameters.Add(description);
                    command.Parameters.Add(id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception) { throw; }

            finally { Data.getInstance().releaseMyConn(); }
        }
        #endregion

        #region DELETE
        public void delete (PaymentType paymentType)
        {
            try
            {
                string query = @"DELETE FROM payment_types
                                WHERE payment_types.id = @Id";

                SqlParameter id = new SqlParameter("@Id", paymentType.Id);

                using (SqlCommand command = new SqlCommand(query, Data.getInstance().getMyConn()))
                {
                    command.Parameters.Add(id);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception) { throw; }

            finally { Data.getInstance().releaseMyConn(); }
        }
        #endregion

        #region GET ALL
        public List<PaymentType> getAll()
        {
            List<PaymentType> paymentTypes = new List<PaymentType>();
            try
            {
                string query = @"SELECT payment_types.id, payment_types.description FROM payment_types";

                using (SqlCommand command = new SqlCommand(query, Data.getInstance().getMyConn()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            paymentTypes.Add(new PaymentType
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Description = reader["description"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception) { throw; }

            finally { Data.getInstance().releaseMyConn(); }

            return paymentTypes;
        }
        #endregion

        #region GET BY DESCRIPTION
        public List<PaymentType> getByDescription(string description)
        {
            List<PaymentType> paymentTypes = new List<PaymentType>();
            try
            {
                string query = @"SELECT payment_types.id, payment_types.description 
                                FROM payment_types
                                WHERE payment_types.description LIKE @Description";

                using (SqlCommand command = new SqlCommand(query, Data.getInstance().getMyConn()))
                {
                    command.Parameters.Add(new SqlParameter ("@Description",$"{description}%"));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            paymentTypes.Add(new PaymentType
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Description = reader["description"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception) { throw; }

            finally { Data.getInstance().releaseMyConn(); }

            return paymentTypes;
        }
        #endregion
    }
}
