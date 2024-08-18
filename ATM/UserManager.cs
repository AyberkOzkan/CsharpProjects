using System;
using System.Collections.Generic;
using System.IO;

namespace ATM
{
    public class UserManager
    {
        private List<User> _users;

        public UserManager()
        {
            _users = new List<User>();
        }

        public List<User> LoadUsers(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string username = parts[0];
                        string password = parts[1];
                        if (decimal.TryParse(parts[2], out decimal balance))
                        {
                            _users.Add(new User(username, password, balance));
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"Kullanıcı dosyası bulunamadı: {filePath}");
            }

            return _users;
        }

        public void SaveUsers(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var user in _users)
                {
                    writer.WriteLine($"{user.Username},{user.Password},{user.Balance}");
                }
            }
        }

        public User? FindUser(string username, string password) => _users.Find(u => u.Validate(username, password));

        public void UpdateUser(User user)
        {
            var existingUser = _users.Find(u => u.Username == user.Username);
            if (existingUser != null)
            {
                existingUser.Balance = user.Balance;
            }
        }
    }
}
