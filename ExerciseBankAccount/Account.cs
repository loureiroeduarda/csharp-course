using System.Globalization;

namespace ExerciseBankAccount
{
    public class Account
    {
        private int _accountNumber { get; }
        private string _name { get; set; }
        private double _balance = 0;

        public Account(int accountNumber, string name)
        {
            _accountNumber = accountNumber;
            _name = name;
        }

        public void FirstDeposit(string chooseDeposit)
        {
            if (chooseDeposit.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                _balance = double.Parse(Console.ReadLine());
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
            Console.Write("\n" + "\n Entre com um valor para depósito: ");
            double deposit = double.Parse(Console.ReadLine());
            _balance += deposit;
            Console.WriteLine();
            Console.Write("Dados atualizados da conta: \n" + ToString());
        }

        override public string ToString()
        {
            return "Conta nº.: " + _accountNumber + ", Titular: " + _name + ", Saldo: R$ " + _balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}