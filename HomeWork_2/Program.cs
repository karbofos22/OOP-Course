using System;

namespace HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount mrJonesAccount = new(4000, AccountType.current);
            mrJonesAccount.ShowAccountInfo();
            mrJonesAccount.ShowBalance();

            Console.WriteLine();

            mrJonesAccount.WidthdrawMoney(1000);
            mrJonesAccount.ShowBalance();

            mrJonesAccount.WidthdrawMoney(5000);
            mrJonesAccount.WidthdrawMoney(3000);
            mrJonesAccount.AddMoney(2000);
            mrJonesAccount.ShowBalance();

            Console.WriteLine();

            BankAccount mrSmithAccount = new(AccountType.savings);
            mrSmithAccount.ShowAccountInfo();
            mrSmithAccount.ShowBalance();


        }
    }
}
