using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Treasure : Collectable
    {
        private String name;
        private int Score;

        public Treasure(string name, int score)
        {
            this.name = name;  
            Score = score;
        }


        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{name} Collected, Congrats!!!");
            UpdateTotalScore();
        }
    }
}
