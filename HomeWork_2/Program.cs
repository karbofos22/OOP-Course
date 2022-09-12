using System;

namespace HomeWork_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount mrJonesAccount = new(4000, AccountType.current);
            
            BankAccount mrSmithAccount = new(15000, AccountType.savings);

            mrJonesAccount = mrSmithAccount;
            Console.WriteLine(mrSmithAccount == mrJonesAccount);
            Console.WriteLine(mrSmithAccount != mrJonesAccount);
            Console.WriteLine(mrSmithAccount.Equals(mrJonesAccount));
            Console.WriteLine(mrJonesAccount.GetHashCode() == mrSmithAccount.GetHashCode());
            Console.WriteLine(mrJonesAccount.ToString());
        }
    }
}
