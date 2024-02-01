using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab3App
{
    public class Coin : Treasure
    {
        private int Value;
        private int Score;
        private String Name;

        public Coin(String name, int score, int value) : base(name, score)
        { 
            Name = name;
            Score = score;
            Value = value;
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Name} Collected, Congrats!!!");
            UpdateTotalScore();
            UpdateTotalValue();
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Name} is displayed");
        }

    }
}
