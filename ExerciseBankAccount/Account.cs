using System.Globalization;

namespace ExerciseBankAccount
{
    public class Account
    {
        private int _accountNumber { get; set; }
        public string Name { get; set; }
        private double _balance { get; set; }

        public Account(int accountNumber, string name)
        {
            _accountNumber = accountNumber;
            Name = name;
        }

        public Account (int accountNumber, string name, double balance) : this(accountNumber, name)
        {
            _balance = balance;
        }

        public void FirstDeposit(string chooseDeposit, int accountNumber, string name)
        {
            if (chooseDeposit.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                _balance = double.Parse(Console.ReadLine());
                Account account = new Account(accountNumber, name, _balance);
                Console.WriteLine();
                Console.WriteLine("Dados da conta: \n" + ToString());

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Dados da conta: \n" + ToString());
            }
        }

        public void DepositValue()
        {
            Console.Write("\n" + "Entre com um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine());
            _balance += deposit;
            Console.WriteLine();
            Console.Write("Dados atualizados da conta: \n" + ToString() + "\n");
        }

        public void WithdrawValue()
        {
            Console.Write("\n" + "Entre com um valor para saque: ");
            double withdraw = double.Parse(Console.ReadLine());
            _balance -= withdraw + 5.00;
            Console.WriteLine();
            Console.Write("Dados atualizados da conta: \n" + ToString());
        }

        override public string ToString()
        {
            return "Conta nº.: " + _accountNumber + ", Titular: " + Name + ", Saldo: R$ " + _balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}