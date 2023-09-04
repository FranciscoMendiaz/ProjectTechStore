using DataAccessLayer;
using EntitiesLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BusinessLogic
    {
        private DataUser dataUser;
        private DataUserRole dataUserRole;
        private DataPaymentType dataPaymentType;

        public BusinessLogic() 
        {   
            dataUser = new DataUser();
            dataUserRole = new DataUserRole();
            dataPaymentType = new DataPaymentType();
        }

        public User validateUser (string email, string password)
        {
            User user = new User();
            user = dataUser.validateUser(email, password);
            return user;
        }

        public User getOne(string email)
        {
            User user = new User();
            user = dataUser.getOne(email);
            return user;
        }

        public void createUser(User user)
        {
            dataUser.createUser(user);
        }

        public void SavePaymentType(PaymentType paymentType)
        {
            if (paymentType.Id ==0 ) { dataPaymentType.createPaymentType(paymentType); }
        }

        public List<PaymentType> getAllPaymentTypes()
        {
            return dataPaymentType.getAllPaymentTypes();
        }






    }






}
