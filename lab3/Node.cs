﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Node
    {
        public Node? next;
        public Node? prev;
        public int data;

        public Node(int liczba) { 
            this.data = liczba;
        }
    }
}
