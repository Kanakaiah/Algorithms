using Algrthm.LinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algrthm.Test.LinkedList
{
    [TestClass()]
    public class LinkedList
    {
        [TestMethod()]
        public void Add()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddNodeToFirst((new Node<int>() { Value = 10 }));
            linkedList.AddNodeToFirst((new Node<int>() { Value = 20 }));
            linkedList.AddNodeToFirst((new Node<int>() { Value = 30 }));
            linkedList.AddNodeToFirst((new Node<int>() { Value = 40 }));

            Node<int> node = linkedList.Head;
            string actualString = "40 30 20 10";
            string restultString = string.Empty;
            while (node!=null)
            {
                restultString += " "+node.Value.ToString();
                node = node.Next;
            }

            Assert.AreEqual(actualString, restultString.Trim());
        }
    }
}
