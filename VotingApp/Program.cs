using System;
using System.Collections.Generic;

namespace VotingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager();
            userManager.LoadUsers("users.txt");
            VotingManager votingManager = new VotingManager();

            Console.WriteLine("Lütfen kullanıcı adınızı girin:");
            string? username = Console.ReadLine();

            User? user = userManager.FindUser(username ?? "");
            if (user == null)
            {
                Console.WriteLine("Kullanıcı bulunamadı. Kayıt olmak ister misiniz? (E/H)");
                string? choice = Console.ReadLine();
                if (choice?.ToUpper() == "E")
                {
                    Console.WriteLine("Şifrenizi girin:");
                    string? password = Console.ReadLine();
                    user = new User(username ?? "", password ?? "");
                    userManager.AddUser(user);
                    userManager.SaveUsers("users.txt");
                }
                else
                {
                    Console.WriteLine("Kayıt işlemi iptal edildi. Çıkılıyor...");
                    return;
                }
            }

            Console.WriteLine("Oylama başlıyor!");

            int totalCategories = 3; // Toplam kategori sayısı
            HashSet<int> votedCategories = new HashSet<int>(); // Oy kullanılan kategorilerin takibi

            while (votedCategories.Count < totalCategories)
            {
                votingManager.DisplayCategories();
                Console.WriteLine("Lütfen oy vermek istediğiniz kategoriyi seçin (1, 2, 3...):");

                if (int.TryParse(Console.ReadLine(), out int categoryIndex))
                {
                    if (votedCategories.Contains(categoryIndex - 1))
                    {
                        Console.WriteLine("Bu kategoriye zaten oy verdiniz. Lütfen başka bir kategori seçin.");
                        continue;
                    }

                    votingManager.DisplayItems(categoryIndex - 1);
                    Console.WriteLine("Lütfen oy vermek istediğiniz öğeyi seçin (1, 2, 3...):");
                    if (int.TryParse(Console.ReadLine(), out int itemIndex))
                    {
                        votingManager.AddVote(categoryIndex - 1, itemIndex - 1);
                        votedCategories.Add(categoryIndex - 1); // Bu kategoriye oy verildiğini kaydedin
                        Console.WriteLine($"Oylanan kategori sayısı: {votedCategories.Count}/{totalCategories}");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz öğe seçimi.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz kategori seçimi.");
                }
            }

            Console.WriteLine("Tüm kategorilere oy verildi. Oylama tamamlandı.");
            votingManager.DisplayResults();
            votingManager.SaveResultsToFile("voting_results.txt");
        }
    }
}
