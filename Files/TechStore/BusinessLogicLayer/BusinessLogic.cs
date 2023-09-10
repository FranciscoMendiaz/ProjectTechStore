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

        public BusinessLogic() // delegates responsibility
        {   
            dataUser = new DataUser();
            dataUserRole = new DataUserRole();
            dataPaymentType = new DataPaymentType();
        }

        #region USER METHODS
        public User userLogin (string email, string password) // User logs in using email and password 
        {
            User user = new User();
            user = dataUser.getByEmailPassword(email, password);
            return user;
        }

        public User userSignUp(string email, string firstName, string lastName, string password, string address) // user creation
        {
            User user = new User();
            user.Email = email;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Password = password;
            user.Address = address;
            user.Role = dataUserRole.getOne(3);
            dataUser.create(user);
            return user;
        }

        public User getOneUser(string email) // searches a user by their email (PK), before signup 
        {
            User user = new User();
            user = dataUser.getOne(email);
            return user;
        }
        #endregion

        #region PAYMENT TYPES METHODS
        public void savePaymentType(PaymentType paymentType)
        {
            if (paymentType.Id == 0 ) { dataPaymentType.create(paymentType); }
            else { dataPaymentType.update(paymentType);}
        }

        public List<PaymentType> getAllPaymentTypes()
        {
            return dataPaymentType.getAll();
        }
        
        public void deletePaymentType(PaymentType paymentType)
        {
            dataPaymentType.delete(paymentType);
        }
    
        public List<PaymentType> filterPaymentTypes(string description)
        {
            return dataPaymentType.getByDescription(description);
        }
        #endregion

    }






}
