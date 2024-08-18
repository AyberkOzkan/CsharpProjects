using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VotingApp
{
    public class VotingManager
    {
        private List<Category> _categories;
        private int totalVoteCount;

        public VotingManager()
        {
            _categories = new List<Category>
            {
                new Category("Film Kategorileri", new List<string> { "Film 1", "Film 2", "Film 3" }),
                new Category("Tech Stack Kategorileri", new List<string> { "JavaScript", "Python", "C#" }),
                new Category("Spor Kategorileri", new List<string> { "Futbol", "Basketbol", "Tenis" })
            };

            LoadPreviousResults("voting_results.txt");
        }

        public void DisplayCategories()
        {
            Console.WriteLine("Oy verebileceğiniz kategoriler:");
            for (int i = 0; i < _categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {_categories[i].Name}");
            }
        }

        public void DisplayItems(int categoryIndex)
        {
            if (categoryIndex >= 0 && categoryIndex < _categories.Count)
            {
                var items = _categories[categoryIndex].Items;
                Console.WriteLine($"\n{_categories[categoryIndex].Name} içerisindeki öğeler:");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {items[i].Name}");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz kategori seçimi.");
            }
        }

        public void AddVote(int categoryIndex, int itemIndex)
        {
            if (categoryIndex >= 0 && categoryIndex < _categories.Count)
            {
                var items = _categories[categoryIndex].Items;
                if (itemIndex >= 0 && itemIndex < items.Count)
                {
                    items[itemIndex].AddVote();
                    Console.WriteLine($"'{items[itemIndex].Name}' öğesine başarıyla oy verildi!");
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

        public void DisplayResults()
        {
            Console.WriteLine("\nOylama Sonuçları:");
            foreach (var category in _categories)
            {
                Console.WriteLine($"\n{category.Name}:");
                int totalVotes = category.Items.Sum(item => item.Votes);

                foreach (var item in category.Items)
                {
                    double percentage = totalVotes > 0 ? (double)item.Votes / totalVotes * 100 : 0;
                    Console.WriteLine($"{item.Name}: {item.Votes} oy (%{percentage:F2})");
                }
            }
        }

        public void SaveResultsToFile(string filePath)
        {
            var existingResults = new Dictionary<string, Dictionary<string, int>>();

            // Önceki sonuçları yükle
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                string currentCategory = null;

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line) || line.Contains("Oylama Sonuçları") || line.Contains("Toplam Oy Kullanım Sayısı"))
                        continue;

                    if (_categories.Exists(c => c.Name == line.Trim(':')))
                    {
                        currentCategory = line.Trim(':');
                        existingResults[currentCategory] = new Dictionary<string, int>();
                    }
                    else if (currentCategory != null && line.Contains("oy"))
                    {
                        string[] parts = line.Split(new[] { ':', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length > 1 && int.TryParse(parts[1].Split(' ')[0].Trim(), out int votes))
                        {
                            string itemName = parts[0].Trim();
                            existingResults[currentCategory][itemName] = votes;
                        }
                    }
                }
            }

            // Yeni sonuçları ekle
            foreach (var category in _categories)
            {
                if (!existingResults.ContainsKey(category.Name))
                {
                    existingResults[category.Name] = new Dictionary<string, int>();
                }

                foreach (var item in category.Items)
                {
                    if (existingResults[category.Name].ContainsKey(item.Name))
                    {
                        existingResults[category.Name][item.Name] += item.Votes;
                    }
                    else
                    {
                        existingResults[category.Name][item.Name] = item.Votes;
                    }
                }
            }

            // Sonuçları dosyaya yaz
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Toplam Oy Kullanım Sayısı: {totalVoteCount}");
                writer.WriteLine("Oylama Sonuçları:");
                foreach (var category in existingResults)
                {
                    writer.WriteLine($"\n{category.Key}:");

                    int totalVotes = category.Value.Values.Sum();

                    foreach (var item in category.Value)
                    {
                        double percentage = totalVotes > 0 ? (double)item.Value / totalVotes * 100 : 0;
                        writer.WriteLine($"{item.Key}: {item.Value} oy (%{percentage:F2})");
                    }
                }
            }

            Console.WriteLine($"Oylama sonuçları {filePath} dosyasına kaydedildi.");
        }

        private void LoadPreviousResults(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);
            Category currentCategory = null;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.Contains("Oylama Sonuçları"))
                    continue;

                if (line.StartsWith("Toplam Oy Kullanım Sayısı:"))
                {
                    if (int.TryParse(line.Split(':')[1].Trim(), out int totalVotes))
                    {
                        totalVoteCount = totalVotes;
                    }
                }
                else if (line.EndsWith("Kategorileri:"))
                {
                    string categoryName = line.Replace(":", "").Trim();
                    currentCategory = _categories.Find(c => c.Name == categoryName);
                }
                else if (currentCategory != null && line.Contains("oy"))
                {
                    string[] parts = line.Split(new[] { ':', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length > 1 && int.TryParse(parts[1].Split(' ')[0].Trim(), out int votes))
                    {
                        string itemName = parts[0].Trim();
                        var item = currentCategory.Items.Find(i => i.Name == itemName);
                        if (item != null)
                        {
                            item.Votes += votes;
                        }
                    }
                }
            }
        }

        public void IncrementVoteCount() => totalVoteCount++;
    }
}
