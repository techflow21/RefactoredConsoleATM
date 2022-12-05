
namespace ConsoleATM
{
    internal class YorubaAccountOperations
    {
        public static void YorubaAccountOperation(int operationOption)
        {
            Console.Clear();
            double accountBalance = 0;
            char cashType = '$';
            YorubaATMOperations yorubaAtmOperations = new();

            switch (operationOption)
            {
                case 1:
                    {
                        int transferedAmount;
                        Console.WriteLine("Te eye owo ti o fefi pamo:");
                        transferedAmount = Convert.ToInt32(Console.ReadLine());
                        yorubaAtmOperations.transfer(transferedAmount, accountBalance);
                    }
                    break;

                case 2:
                    {
                        yorubaAtmOperations.checkBalance(accountBalance, cashType);
                    }
                    break;

                case 3:
                    {
                        double withdrawAmount;
                        Console.WriteLine("Te eye owo ti ofe gba jade:");
                        withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        yorubaAtmOperations.withdraw(withdrawAmount, accountBalance, cashType);
                    }
                    break;

                case 4:
                    {
                        yorubaAtmOperations.cancel();
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Ounte re o yege");
                    }
                    break;
            }
        }
    }
}
