using System.Text.RegularExpressions;

namespace ConsoleATM
{
    public class Registration
    {
        private string customerName;
        private string atmPin;
        bool stillActive = true;

        string patternText = @"[a-zA-Z]{2,40}";
        string patternPin = @"[0-9]{4}";

        Dictionary<string, int> user = new Dictionary<string, int>();
        public void RegisterUser()
        {
            Regex regexText = new Regex(patternText);
            Regex regexPin = new Regex(patternPin);

            Console.WriteLine("*** Register for an Account ***\nEnter your username: ");
            customerName = Console.ReadLine();

            Console.WriteLine("Enter any 4 digits as your Atm pin: ");
            atmPin = Console.ReadLine();

            if (regexText.IsMatch(customerName) && regexPin.IsMatch(atmPin))
            {
                int savedPin = Convert.ToInt32(atmPin);
                user.Add(customerName, savedPin);

                Console.WriteLine("Hi {0}! Account Registration was Successful!", customerName);
            }

            else
            {
                Console.Clear();
                Console.WriteLine("Your entered username/Atm pin is invalid, try again!");
                RegisterUser();
            }

        }

        public void LoginWithPin(string enteredPin)
        {
            string option = "N";

            while (stillActive || option == "Y")
            {
                try
                {
                    if (!string.IsNullOrEmpty(enteredPin) && enteredPin == atmPin)
                    {
                        Console.Clear();
                        Language.languageClass();

                        Console.WriteLine("Want to carry out another operation, enter (Y/N) ?");
                        option = Console.ReadLine().ToUpper();

                        if (option == "N")
                        {
                            stillActive = false;
                            Console.WriteLine("Thank you for using SOB-ATM Service");
                        }
                        else if (option == "Y")
                        {
                            stillActive = true;
                        }
                        else
                        {
                            stillActive = false;
                            Console.WriteLine("You entered an Invalid Character, Try Again!");
                            LoginWithPin(enteredPin);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You entered a wrong pin, try again");
                        stillActive = false;
                        LoginWithPin(enteredPin);
                    }
                }
                catch
                {
                    stillActive = false;
                    Console.WriteLine("Wrong ATM Pin entered, try again!");
                    LoginWithPin(enteredPin);
                }
            }
        }
    }
}
