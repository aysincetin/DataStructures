using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace HashTable
{
    class Node
    {
        int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
        public Node() { }
        public int getdata()
        {
            return data;
        }
    }
    class Hash
    {
        Node[] array;
        int max = 10;
        public Hash()
        {
            array = new Node[max];
        }
        public void Add(int data)
        {
            int mod = data % max;
            if (array[mod] == null)
            {
                array[mod] = new Node(data);
            }
            else
            {
                Node temp = array[mod];
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new Node(data);
            }
        }
        public void Delete(int data)
        {
            int mod = data % max;
            if (array[mod] == null)
            {
                Console.WriteLine("Null error  ");
            }
            else
            {
                Node temp = array[mod];
                if (temp.getdata() == data)
                {
                    array[mod] = temp.next;
                }
                else
                {
                    while (temp.next.getdata() != data)
                    {
                        temp = temp.next;
                    }
                    temp.next = temp.next.next;
                }
            }

        }
        public void SearchToMode(int i)
        {
            if (i < max)
            {
                Node temp = array[i];
                while (temp != null)
                {
                    Console.WriteLine(temp.getdata());
                }
            }
            else
            {
                Console.WriteLine("index>10");
            }
        }
    }
}
