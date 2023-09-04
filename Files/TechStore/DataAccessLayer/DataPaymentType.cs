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
        List<PaymentType> paymentTypes = new List<PaymentType>();

        #region CREATE PAYMENT TYPE    
        public void createPaymentType (PaymentType paymentType)
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

        public List<PaymentType> getAllPaymentTypes () 
        {
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











    }
}
