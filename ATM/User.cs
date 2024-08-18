namespace ATM
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; }

        public User(string username, string password, decimal balance)
        {
            Username = username;
            Password = password;
            Balance = balance;
        }

        public bool Validate(string username, string password) => Username == username && Password == password;

    }
}
