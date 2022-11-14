using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PV1411
{
    public class MyStack<T>
    {
        Node<T>? head { get; set; }
        public int count { get; set; }
        public MyStack()
        {
            head = null;
            count = 0;
        }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.next = head;
            head = node;

        }
        public T? Pop()
        {
            if (this.IsEmpty)
            {
                throw new Exception();
            }
            Node<T> node = this.head;
            head = node.next;
            return node.value;

        }
        public bool IsEmpty
        {
            get{ return head == null;  }
        }


    }
}
