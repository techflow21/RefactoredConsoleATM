namespace ConsoleATM
{
    internal class PidginAccountOperations
    {
        public static void PidginAccountOperation(int operationOption)
        {
            Console.Clear();
            double accountBalance = 0;
            char cashType = '$';
            PidginATMOperations pidginAtmOperations = new();

            switch (operationOption)
            {
                case 1:
                    {
                        int transferedAmount;
                        Console.WriteLine("Enta Moni to Transfa:");
                        transferedAmount = Convert.ToInt32(Console.ReadLine());
                        pidginAtmOperations.transfer(transferedAmount, accountBalance);
                    }
                    break;

                case 2:
                    {
                        pidginAtmOperations.checkBalance(accountBalance, cashType);
                    }
                    break;

                case 3:
                    {
                        double withdrawAmount;
                        Console.WriteLine("Enter Moni to Comot:");
                        withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        pidginAtmOperations.withdraw(withdrawAmount, accountBalance, cashType);
                    }
                    break;

                case 4:
                    {
                        pidginAtmOperations.cancel();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Wetin you enta no koret");
                    }
                    break;
            }
        }
    }
}
