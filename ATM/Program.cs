using System;
using System.Collections.Generic;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            List<User> users = userManager.LoadUsers("users.txt");
            LogHandler logHandler = new LogHandler();

            Console.WriteLine("Lütfen kullanıcı adınızı girin:");
            string? username = Console.ReadLine();
            Console.WriteLine("Lütfen şifrenizi girin:");
            string? password = Console.ReadLine();

            User? user = userManager.FindUser(username ?? "", password ?? "");

            if (user == null)
            {
                Console.WriteLine("Geçersiz kullanıcı adı veya şifre.");
                logHandler.AddLog("Hatalı giriş denemesi.");
                return;
            }

            ATM atm = new ATM(user);

            while (true)
            {
                Console.WriteLine("1: Para Yatırma");
                Console.WriteLine("2: Para Çekme");
                Console.WriteLine("3: Bakiye Görüntüleme");
                Console.WriteLine("4: Gün Sonu");
                Console.WriteLine("5: Çıkış");
                Console.Write("Yapmak istediğiniz işlemi seçin: ");
                string? choice = Console.ReadLine();
                choice = choice ?? string.Empty;  // Null kontrolü

                switch (choice)
                {
                    case "1":
                        Console.Write("Yatırılacak tutarı girin: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            atm.Deposit(depositAmount);
                            userManager.UpdateUser(user);  // Kullanıcıyı güncelle
                            userManager.SaveUsers("users.txt");  // Dosyaya kaydet
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz tutar.");
                        }
                        break;
                    case "2":
                        Console.Write("Çekilecek tutarı girin: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                        {
                            atm.Withdraw(withdrawAmount);
                            userManager.UpdateUser(user);  
                            userManager.SaveUsers("users.txt"); 
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz tutar.");
                        }
                        break;
                    case "3":
                        atm.ShowBalance();
                        break;
                    case "4":
                        logHandler.SaveEndOfDayReport(atm.GetTransactions());
                        break;
                    case "5":
                        Console.WriteLine("Çıkış yapılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
            }
        }
    }
}
