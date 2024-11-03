using static SOLID_principles.SingleResponsibilityPattern.Email;

namespace SOLID_principles.SingleResponsibilityPattern
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public string Age { get; set; }

        public User()
        {
            Id = 0;
            Name = string.Empty;
            UserEmail = string.Empty;
            Password = string.Empty;
            Age = string.Empty;
        }

        public User getUser()
        {
            return new User();
        }

        public User getName()
        {
            return Name;
        }

        public bool isAdult()
        {
            /*
             * we want if user is adult then an email is sent to user.
             * Email itself is a seperate concern and functionality so here single Responsibility play its part.
             */
            Email.sentEmail();
        }

        //public void sentEmail()
        //{
        //    /*
        //     * voilate SRP as User shoud handle only user related functionality.
        //     */
        //}
    }
}
