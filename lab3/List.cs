using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class List
    {
        public Node? head;
        public Node? tail;
        public int count;
        public List() {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        public void AddLast(int liczba)
        {
            Node addedNode = new Node(liczba);
            if (this.tail == null)
            {
                this.head = addedNode;
                this.tail = addedNode;
            }
            else 
            { 
                addedNode.prev = this.tail;
                this.tail.next = addedNode;
                this.tail = addedNode;
            }
            this.count++;
        }
        public void AddFirst(int liczba)
        {
            Node addedNode = new Node(liczba);

            if (this.head == null)
            {
                this.head = addedNode;
                this.tail = addedNode;
            }
            else
            {
                addedNode.next = this.head;
                this.head.prev = addedNode;
                this.head = addedNode;
            }
            this.count++;

        }
        //RemoveFirst()
        /*public void RemoveFirst() 
        {
            if(this.head != null)
            {
                if (this.head == this.tail)
                {
                    this.head = null;
                    this.tail = null;
                }
                else
                {
                    this.head = this.head.next;
                    this.head.prev = null;
                }
                count--;
            }
        }*/

        public Node RemoveFirstDiff()
        {
            if (this.head == null)
                return null;
            Node? wynik;
            if (this.head == this.tail)
            {
                wynik = this.head;
                this.head = this.tail = null;
                this.count = 0;
                return wynik;
            }
            wynik = this.head;
            this.head = this.head.next;
            this.head.prev = null;
            wynik.next = null;
            this.count--;
            return wynik;
        }

        /*public void RemoveLast()
        {
            if (this.tail != null)
            {
                if (this.tail == this.head)
                {
                    this.head = null;
                    this.tail = null;
                }
                else
                {
                    this.tail = this.tail.prev;
                    this.tail.next = null;
                }
                count--;
            }
        }*/
        //na lekcji robione
        public Node RemoveLastDiff()
        {
            if (this.head == null)
                return null;
            Node? wynik;
            if(this.head==this.tail)
            {
                wynik = this.head;
                this.head = this.tail = null;
                this.count = 0;
                return wynik;
            }
            wynik =this.tail;
            this.tail = this.tail.prev;
            this.tail.next = null;
            wynik.prev = null;
            this.count--;
            return wynik;
        }


        public string LListToString()
        {
            Node? obecny = head;
            string wynik = "";

            while (obecny != null)
            {
                wynik += (obecny.data + ", ");
                obecny = obecny.next;
            }

            return wynik.TrimEnd();
        }
        public override string ToString()
        {
            Node? obecny = head;
            string wynik = "";

            while (obecny != null)
            {
                wynik += (obecny.data + ", ");
                obecny = obecny.next;
            }

            return wynik.Trim();
        }



    }
}
