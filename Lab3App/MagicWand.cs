using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class MagicWand : Tool
    {
        private String name;
        public MagicWand(String name) : base(name)
        {
            this.name = name;
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {name} is displayed");
        }
    }
}
