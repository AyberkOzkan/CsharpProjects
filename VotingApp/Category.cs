using System.Collections.Generic;

namespace VotingApp
{
    public class Category
    {
        public string Name { get; set; }
        public List<Item> Items { get; set; }

        public Category(string name, List<string> items)
        {
            Name = name;
            Items = new List<Item>();
            foreach (var item in items)
            {
                Items.Add(new Item(item));
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Item(string name)
        {
            Name = name;
            Votes = 0;
        }

        public void AddVote() => Votes++;
    }
}
