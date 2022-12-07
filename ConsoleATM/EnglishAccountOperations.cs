namespace ConsoleATM
{
    internal class EnglishAccountOperations
    {
        public static void EnglishAccountOperation(int operationOption)
        {
            Console.Clear();
            double accountBalance = 0;
            char cashType = '$';
            EnglishATMOperations englishAtmOperations = new();

            switch (operationOption)
            {
                case 1:
                    {
                        int transferedAmount;

                        Console.WriteLine("Enter the amount to transfer (Maximum transfer limit is 1000000):");
                        var amount = Console.ReadLine();
                        try
                        {
                            if (Convert.ToInt32(amount) > 0 && Convert.ToInt32(amount) <= 1000000)
                            {
                                transferedAmount = Convert.ToInt32(amount);
                                englishAtmOperations.transfer(transferedAmount, accountBalance);

                                Events transactions = new();
                                transactions.TransactionCompleted += Events.subTransactionCompleted;

                                transactions.StartTransaction(transferedAmount);
                            }
                        }
                        catch
                        {
                            Console.WriteLine($"{amount} is an invalid entry! try again ");
                        }
                        
                    }
                    break;

                case 2:
                    {
                        englishAtmOperations.checkBalance(accountBalance, cashType);
                    }
                    break;

                case 3:
                    {
                        double withdrawAmount;

                        Console.WriteLine("Enter the amount to withdraw:");
                        withdrawAmount = Convert.ToDouble(Console.ReadLine());

                        englishAtmOperations.withdraw(withdrawAmount, accountBalance, cashType);
                    }
                    break;

                case 4:
                    {
                        englishAtmOperations.cancel();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("You entered invalid operation option");
                    }
                    break;
            }
        }
    }
}
