namespace ConsoleATM
{
    internal class Language
    {
        public static void languageClass()
        {
            Console.Clear();
            Console.WriteLine("Choose Your Preferred Language\nEnter 1 for English\nEnter 2 for Pigin\nEnter 3 for Yoruba");

            int languageOption = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (languageOption)
            {
                case 1:
                    {
                        Console.WriteLine("Enter 1 for Cash Deposit \nEnter 2 for Check Account Balance \nEnter 3 for Cash Withdrawal \nEnter 4 for Cancel");
                        int operationOption = Convert.ToInt32(Console.ReadLine());
                        EnglishAccountOperations.EnglishAccountOperation(operationOption);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enta 1 to put Moni for Accant \nEnta 2 to See Moni wey dey Accant \nEnta 3 to Comot Moni from your Accant \nEnta 4 to Kansu");
                        int operationOption = Convert.ToInt32(Console.ReadLine());
                        PidginAccountOperations.PidginAccountOperation(operationOption);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Te 1 fun Ifowo Pamo \nTe 2 lati ri Owo Toku \nTe 3 lati gba Owo \nTe 4 lati Kansu");
                        int operationOption = Convert.ToInt32(Console.ReadLine());
                        YorubaAccountOperations.YorubaAccountOperation(operationOption);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("You entered an invalid Language Option");
                    }
                    break;
            }
        }
    }
}
