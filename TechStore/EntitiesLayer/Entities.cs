namespace EntitiesLayer
{
    public class User
    {
        public string Email { get; set; }
       
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public UserRole Role { get; set; }




    }


    public class UserRole
    {
        public int Id { get; set; }

        public string Description { get; set; }

    }




}