using System.Globalization;

namespace ExerciseBankAccount
{
    public class Account
    {
        private int _accountNumber { get; }
        public string Name;
        private double _balance = 0;

        public Account(int accountNumber, string name)
        {
            _accountNumber = accountNumber;
            Name = name;
        }

        public void FirstDeposit(string chooseDeposit)
        {
            if (chooseDeposit.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                _balance = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(ToString());

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(ToString());
            }
        }

        override public string ToString()
        {
            return "Dados da conta:" + "\n" + "Conta nº. : " + _accountNumber + ", Titular: " + Name + ", Saldo: R$ " + _balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}