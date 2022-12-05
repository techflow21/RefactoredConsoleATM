namespace ConsoleATM
{
    // General Interface Methods common to all Languages.
    interface IOperationInterface
    {
        void transfer(int transferedAmount, double accountBalance);
        void checkBalance(double accountBalance, char cashType);
        void withdraw(double withdrawAmount, double accountBalance, char cashType);
        void cancel();
    }

    // English Language ATM Operations
    class EnglishATMOperations : IOperationInterface
    {
        public void transfer(int transferedAmount, double accountBalance)
        {
            accountBalance += AccountBalance.AccountBlcTransfer(transferedAmount);
        }


        public void checkBalance(double accountBalance, char cashType)
        {
            accountBalance = AccountBalance.AccountBlcTransfer(accountBalance);
            Console.WriteLine("Your Account Balance is: {0}{1}", cashType, accountBalance);
        }


        public void withdraw(double withdrawAmount, double accountBalance, char cashType)
        {
            double accountBalanceW = AccountBalance.AccountBlcTransfer(accountBalance);
            if (withdrawAmount >= 10 && accountBalanceW >= withdrawAmount)
            {
                accountBalance = AccountBalance.AccountBlcWithdraw(withdrawAmount);
                Console.WriteLine("{0}{1} withdrawal was successfully!", cashType, withdrawAmount);
                Console.WriteLine("Your Account Balance is: {0}{1}", cashType, accountBalance);
            }
            else if (withdrawAmount < 10)
            {
                Console.WriteLine("You can't withdraw less than {0}10", cashType);
            }
            else if (withdrawAmount > accountBalance)
            {
                Console.WriteLine("Insufficient Account Balance");
            }
            else
            {
                Console.WriteLine("Your entry is invalid");
            }
        }


        public void cancel()
        {
            Console.WriteLine("Operation Cancelled");
        }
    }


    // Pidgin Language ATM Operations
    class PidginATMOperations : IOperationInterface
    {
        public void transfer(int transferedAmount, double accountBalance)
        {
            if (transferedAmount > 0)
            {
                accountBalance += AccountBalance.AccountBlcTransfer(transferedAmount);
                Console.WriteLine("Moni wey you transfa go wella!");
                //Console.WriteLine("Your Moni wey remain na: {0}{1}", cashType, accountBalance);
            }
            else if (transferedAmount > 1000000)
            {
                Console.WriteLine("Moni wey you wan send tu much, na thief thief behaviour be this!");
            }
            else
            {
                Console.WriteLine("Wetin you enta no make make sense");
            }
        }


        public void checkBalance(double accountBalance, char cashType)
        {
            accountBalance = AccountBalance.AccountBlcTransfer(accountBalance);
            Console.WriteLine("Your Moni wey remain na: {0}{1}", cashType, accountBalance);
        }


        public void withdraw(double withdrawAmount, double accountBalance, char cashType)
        {
            double accountBalanceW = AccountBalance.AccountBlcTransfer(accountBalance);
            if (withdrawAmount >= 10 && accountBalanceW >= withdrawAmount)
            {
                accountBalance = AccountBalance.AccountBlcWithdraw(withdrawAmount);
                Console.WriteLine("{0}{1} Moni commot from your akant well!", cashType, withdrawAmount);
                Console.WriteLine("Your Moni wey remain na: {0}{1}", cashType, accountBalance);
            }
            else if (withdrawAmount < 10)
            {
                Console.WriteLine("The Moni wey you wan commot no fit small pass {0}10", cashType);
            }
            else if (withdrawAmount > accountBalance)
            {
                Console.WriteLine("Your Moni wey remain too dey small");
            }
            else
            {
                Console.WriteLine("Wetin you enta no make sense");
            }
        }


        public void cancel()
        {
            Console.WriteLine("We no dey do anything again");
        }
    }


    // Yoruba Language ATM Operations
    class YorubaATMOperations : IOperationInterface
    {
        public void transfer(int transferedAmount, double accountBalance)
        {
            if (transferedAmount > 0)
            {
                accountBalance += AccountBalance.AccountBlcTransfer(transferedAmount);
                Console.WriteLine("Ifowo pamo yi yege!");
            }
            else if (transferedAmount > 1000000)
            {
                Console.WriteLine("Kosi igba laye lati san owo pupo bi eyi, Iwa ole re!");
            }
            else
            {
                Console.WriteLine("Eye owo ti o fe san si akanti re kere");
            }
        }


        public void checkBalance(double accountBalance, char cashType)
        {
            accountBalance = AccountBalance.AccountBlcTransfer(accountBalance);
            Console.WriteLine("Eye Owo re toku je: {0}{1}", cashType, accountBalance);
        }


        public void withdraw(double withdrawAmount, double accountBalance, char cashType)
        {
            double accountBalanceW = AccountBalance.AccountBlcTransfer(accountBalance);
            if (withdrawAmount >= 10 && accountBalanceW >= withdrawAmount)
            {
                accountBalance = AccountBalance.AccountBlcWithdraw(withdrawAmount);

                Console.WriteLine("{0}{1} Owo ti ofe gba yege!", cashType, withdrawAmount);
                Console.WriteLine("Eye owo re toku je: {0}{1}", cashType, accountBalance);
            }
            else if (withdrawAmount < 10)
            {
                Console.WriteLine("Eye owo ti ofe gba ogbo do din ni {0}10", cashType);
            }
            else if (withdrawAmount > accountBalance)
            {
                Console.WriteLine("Eye Owo inu Akanti re oto nkan");
            }
            else
            {
                Console.WriteLine("Ounte re o yege");
            }
        }

        public void cancel()
        {
            Console.WriteLine("Adawo ise ATM duro");
        }
    }
}
