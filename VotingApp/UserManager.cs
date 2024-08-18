using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
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
                    if (parts.Length == 2)
                    {
                        _users.Add(new User(parts[0], parts[1]));
                    }
                }
            }
            return _users;
        }

        public void SaveUsers(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var user in _users)
                {
                    writer.WriteLine($"{user.Username},{user.Password}");
                }
            }
        }

        public User? FindUser(string username) => _users.Find(u => u.Username == username);

        public void AddUser(User user) => _users.Add(user);
    }
}
