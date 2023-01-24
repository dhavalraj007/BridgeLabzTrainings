namespace MyApp
{
    public class MoodAnalyser
    {
        public class MoodAnalyserException:Exception
        {

            public enum Types
            {
                EMPTY,
                NULL
            }

            Types type;
            public MoodAnalyserException(Types t,string message):base(message)
            { type = t; }

        }
        public static string analyseMood(string sentence)
        {
            try
            {
                if (sentence is null)
                    throw new MoodAnalyserException(MoodAnalyserException.Types.NULL, "sentence should not be null!");
                if(sentence.Equals(string.Empty))
                    throw new MoodAnalyserException(MoodAnalyserException.Types.EMPTY, "sentence should not be empty!");

                if (sentence.ToLower().Contains("sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception handled: "+e.Message); 
                return "Happy";
            }
            
        } 
    }
 
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

            //TestLambda.test();
        }
    }
}
