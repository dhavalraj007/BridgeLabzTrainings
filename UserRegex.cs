using System.Text.RegularExpressions;

namespace MyApp
{
    public class User
    {
        public string FirstName,LastName;
        public string Email;
        public string Password;
        public string PhoneNumber;
        public User()
        {
            FirstName = ""; LastName = "";
            Email = "";
            Password = "";
        }

        public void SetFirstName()
        {
            do
            {
                Console.WriteLine("Enter firstname with first character as capital and atleast 3 chars long");
                FirstName = Console.ReadLine();
            }
            while (!UserRegex.ValidName(FirstName));
        }

        public void SetLastName()
        {
            do
            {
                Console.WriteLine("Enter lastname with first character as capital and atleast 3 chars long");
                LastName = Console.ReadLine();
            }
            while (!UserRegex.ValidName(LastName));
        }

        public void SetPhoneNumber()
        {
            do
            {
                Console.WriteLine("Enter PhoneNumber with 2 digit country code and 10 digit number saperated by one space");
                PhoneNumber = Console.ReadLine();
            }
            while (!UserRegex.ValidPhoneNumber(PhoneNumber));
        }

        public void SetEmail()
        {
            do
            {
                Console.WriteLine("Enter Valid Email");
                Email = Console.ReadLine();
            }
            while (!UserRegex.ValidEmail(Email));
        }
        public void SetPassword()
        {
            do
            {
                Console.WriteLine("Enter Valid Password");
                Password= Console.ReadLine();
            }
            while (!UserRegex.ValidPassword(Password));
        }

    }
    public class UserRegex
    {
        
        public static bool ValidName(string fn) => Regex.IsMatch(fn, "^[A-Z][A-Za-z]{2,}");

        public static bool ValidPhoneNumber(string phoneNumber) => Regex.IsMatch(phoneNumber, "^[0-9]{2}\\s[0-9]{10}");
        
        public static bool ValidEmail(string email) => Regex.IsMatch(email, "^[A-Za-z0-9]+[.]?[A-Za-z0-9]+@bl.co[.]?[A-Za-z]*");
        
        public static bool ValidPassword(string password) => Regex.IsMatch(password, "^(?=.*[A-Z])(?=.*\\d)(?=[^\\W]*[\\W][^\\W]*$)(?=.{8,}$)");
        
    }
}
