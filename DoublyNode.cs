using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProject
{
    internal class DoublyNode
    {
        private string data;
        private DoublyNode next = null;
        private DoublyNode prev = null;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public DoublyNode Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public DoublyNode Prev
        {
            get { return this.prev; }
            set { this.prev = value; }
        }
    }
}