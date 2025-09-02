using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Player
    {
        public string Name { get; set; }
        public int Attempts { get; set; }
        public bool Winner { get; set; }

        public Player(string name)
        {
            Name = name;
            Attempts = 0;
            Winner = false;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}, attempts: {Attempts}, winner: {Winner}");
        }

    }
}
