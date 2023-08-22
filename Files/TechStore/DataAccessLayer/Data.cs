using EntitiesLayer;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Data
    {
        private SqlConnection myConn=null;
        private static Data instance;
        private int connected = 0;

        // Singleton pattern implementation:

        public static Data getInstance()
        {
            if (instance == null)
            {
                instance = new Data();
            }
            return instance;
        }

        private Data()
        {
            myConn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Tech-Store;Data Source=DESKTOP-SLFI33K\\SQLEXPRESS;MultipleActiveResultSets=true");
        }

        public SqlConnection getMyConn()
        {
            try
            {
                if (myConn == null || myConn.State == ConnectionState.Closed)
                {
                    myConn.Open();
                    connected = 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            connected++; ;
            return myConn;
        }

        public void releaseMyConn()
        {
            connected--;
            try
            {
                if (connected <= 0)
                {
                    myConn.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}