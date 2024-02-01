using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Collectable : Displayable
    {
        public CollectionBoard Board = new CollectionBoard();
        public virtual void AddMe(List<Collectable> list)
        { 

        }


        public virtual void Display()
        { 

        }
    }
}
