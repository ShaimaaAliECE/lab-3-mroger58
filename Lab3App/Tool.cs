using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Tool : Collectable
    {
        private String name;

        public Tool(String name)
        { 
            this.name = name;
        }
        public virtual void DoAction()
        {
            
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{name} Collected, Congrats!!!");
            DoAction();
        }


    }
}
