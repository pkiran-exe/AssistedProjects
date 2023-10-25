using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProject
{


    internal class DoublyLinkedList
    {
        private DoublyNode root = null;
        private DoublyNode current = null;
        private int length;

        public DoublyNode Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public int Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public void add(DoublyNode node)
        {
            node.Next = null;
            if (root == null)
            {
                root = node;
                length = 1;
                current = root;
                root.Prev = null;
            }
            else
            {
                current.Next = node;
                node.Prev = current;
                current = node;
                length++;
            }
        }

        public DoublyNode getCurrent()
        {
            return this.current;
        }

        public DoublyNode getRoot()
        {
            current = root;
            return this.root;
        }

        public DoublyNode getNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return current;
            }
            else
                return null;
        }

        public DoublyNode getPrev()
        {
            if (current.Prev != null)
            {
                current = current.Prev;
                return current;
            }
            else
                return null;
        }

        public int getLengthOfList()
        {
            return this.length;
        }
    }

}