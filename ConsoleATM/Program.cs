namespace ConsoleATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    S.O.B-ATM Service    \n**************************\n");
            
            Registration registration = new();
            registration.RegisterUser();

            Console.WriteLine("Enter your Atm pin");
            var enteredPin = Console.ReadLine();

            registration.LoginWithPin(enteredPin);
            
            Console.ReadLine();
        }
    }
}
