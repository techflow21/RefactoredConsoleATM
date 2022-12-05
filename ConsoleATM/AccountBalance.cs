
namespace ConsoleATM
{

    static class AccountBalance
    {
        static double accountBalance = 0;
        public static double AccountBlcTransfer(double amount) => accountBalance += amount;
        public static double AccountBlcWithdraw(double amount) => accountBalance -= amount;

    }
}
