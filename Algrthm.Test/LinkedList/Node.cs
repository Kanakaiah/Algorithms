using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algrthm.LinkedList;

namespace Algrthm.Test.LinkedList
{
    [TestClass()]
    public class Node
    {
        [TestMethod()]
        public void AddNode()
        {
            Node<int> FirstNode = new Node<int>() {Value=10 };
            Node<int> MiddleNode = new Node<int>() { Value = 20 };
            Node<int> LastNode = new Node<int>() { Value = 30 };

            FirstNode.Next = MiddleNode;
            MiddleNode.Next = LastNode;
            int Total = 0;
            int Counter = 0;
            while (FirstNode != null)
            {
                Counter++;
                Total += FirstNode.Value;
                FirstNode = FirstNode.Next;
            }

            Assert.AreEqual(Total, 60);

            Assert.AreEqual(Counter, 3);
        }
    }
}
