using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATM
    {
        private User _user;
        private List<Transaction> _transactions;

        public ATM(User user) 
        { 
            _user = user; 
            _transactions = new List<Transaction>();
        }

        public void Deposit(decimal amount)
        {
            _user.Balance += amount;
            _transactions.Add(new Transaction("Para Yatırma", amount));
            Console.WriteLine($"{amount:C} başarıyla yatırıldı. Yeni bakiyeniz: {_user.Balance:C}");
        }
        public void Withdraw(decimal amount)
        {
            if (amount > _user.Balance) 
            {
                Console.WriteLine("Yetersiz bakiye.");
                return;
            }

            _user.Balance -= amount;
            _transactions.Add(new Transaction("Para Çekme", amount));
            Console.WriteLine($"{amount:C} başarıyla çekildi. Yeni bakiyeniz: {_user.Balance:C}");
        }

        public void ShowBalance() => Console.WriteLine($"Mevcut bakiyeniz: {_user.Balance:C}");

        public List<Transaction> GetTransactions() => _transactions;
    }
}
