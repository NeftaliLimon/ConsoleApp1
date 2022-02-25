using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
     class Node
    {
       public string data;
       public Node next;
       public Node previous;

        public Node(string data)
        {
            this.data = data;
        }
    }
}
