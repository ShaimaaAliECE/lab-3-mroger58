using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Axe : Tool
    {
        private String name;

        public Axe(string name) : base(name)
        {
            this.name = name;
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is used");
        }

        public override void Display()
        {
            Console.WriteLine($"Axe {name} is displayed");
        }
    }
}
