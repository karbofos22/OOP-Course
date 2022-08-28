using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_2
{
    internal class BankAccount
    {
        //        Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
        //банковского счета(использовать перечислимый тип). Предусмотреть методы для
        //доступа к данным – заполнения и чтения.Создать объект класса, заполнить его
        //поля и вывести информацию об объекте класса на печать

        private string AccountNum { get; set; }
        private decimal Balance{get; set;}
        private bool OverDraft { get; set;}
        private AccountType AccountType{get; set;}

        public BankAccount(AccountType _AccountType)
        {
            AccountNum = AccountNumGenerator();
            AccountType = _AccountType;
        }
        public BankAccount(int money, AccountType _AccountType)
        {
            AccountNum = AccountNumGenerator();
            Balance = money;
            AccountType = _AccountType;
        }
        
        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {Balance} у.е.");
        }
        public void ShowAccountInfo()
        {
            Console.WriteLine($"Account number: {AccountNum}\n" +
                              $"Account type: {AccountType}");
        }
        public void AddMoney(decimal moneyAmount)
        {
            Balance += moneyAmount;
            if (OverDraft)
            {
                Console.WriteLine($"Внесенная сумма {moneyAmount} у.е. принята для погашения задолженности");
            }
            else
            {
                Console.WriteLine($"Внесена сумма {moneyAmount}");
            }
        }
        public void WidthdrawMoney(decimal moneyAmount)
        {
            if (Balance > moneyAmount)
            {
                Balance -= moneyAmount;
                Console.WriteLine($"Выданы средства, {moneyAmount} у.е.");
            }
            else//if (Balance < moneyAmount)
            {
                OverDraft = true;
                Balance -= moneyAmount;
                Console.WriteLine($"Выданы кредитные средства, текущая задолженность {Balance} у.е.");
            }
        }
        private string AccountNumGenerator()
        {
            Random random = new();
            return AccountNum = $"{random.Next(1000, 5001)}-{random.Next(10001, 40001)}-{random.Next(5001, 10001)}";
        }





    }
}
