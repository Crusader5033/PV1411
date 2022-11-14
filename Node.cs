using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV1411
{
    public class Node<T>
    {

        public T? value { get; set; }
        public Node<T>? next { get; set; }
        public Node(T? value)
        {
            this.value = value;
            this.next = null;
        }
        public Node (T? value,Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
    }
}
