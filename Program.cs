namespace MyApp
{

      
 
    class Program
    {

        static void Main(string[] args)
        {
            User user = new User();
            user.SetFirstName();
            user.SetLastName();
            user.SetEmail();
            user.SetPhoneNumber();
            user.SetPassword();

            // TestLambda.test();
            // FileOperations.test();
        }

    }
}
