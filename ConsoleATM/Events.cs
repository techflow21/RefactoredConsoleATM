namespace ConsoleATM
{
    internal class Events
    {
        public delegate void SampleDelegate(int transferedAmount);

        public event SampleDelegate TransactionCompleted;

        public void StartTransaction(int transferedAmount)
        {
            Console.WriteLine("You are transferring ${0} ...", transferedAmount);
            Thread.Sleep(2000);

            OnTransactionCompleted(transferedAmount);
        }

        protected virtual void OnTransactionCompleted(int transferedAmount)
        {

            if (OnTransactionCompleted != null)
            {
                TransactionCompleted?.Invoke(transferedAmount);
            }
            else
            {
                Console.WriteLine("You are not subscribe to this event");
            }
        }

        public static void subTransactionCompleted(int transferedAmount)
        {
            Console.WriteLine("Transfer of ${0} was successful!", transferedAmount);
        }
    }
}
