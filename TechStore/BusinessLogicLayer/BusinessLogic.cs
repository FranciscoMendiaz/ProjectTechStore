using DataAccessLayer;
using EntitiesLayer;

namespace BusinessLogicLayer
{
    public class BusinessLogic
    {
        private Data data;

        public BusinessLogic() { data = new Data(); }

        public User validateUser (string email, string password){
        
            User user = new User();
            user = data.getUser(email, password);
            return user;
        
        }





    }






}
