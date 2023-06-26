namespace ExerciseBankAccount
{
    public class Account
    {
        private int _accountNumber;
        public string Name;
        private double _balance;

        public Account(int accountNumber, string name, double balance)
        {
            _accountNumber = accountNumber;
            Name = name;
            _balance = balance;
        }

        
    }
}