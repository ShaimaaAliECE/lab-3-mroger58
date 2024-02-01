using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Diamond : Treasure
    {
        private int Score;
        private String Name;

        public Diamond(String name, int score)  : base(name, score) 
        {
            this.Score = score;
            this.Name = name;
        }

        public override void Display()
        {
            Console.WriteLine($"Diamond{Name} is displayed");
        }

    }
}
