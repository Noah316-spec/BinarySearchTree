using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Xml.Linq;

namespace MeinProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
        }
    }
    class Node
    {
        public int data;
        public Node leftChild;
        public Node rightChild;
    }
    class BinarySearchTree
    {
        Node root;
        public void Insert(int index, Node node) 
        { 
            
            node.data = index;
            if(root == null)
            {
                root = new Node();
            }
            else
            {
                Node current = root;
                Node parent;

                while(true)
                {
                    parent = current;
                    if(index < current.data)
                    {
                        current = current.leftChild;
                        if(current == null) 
                        {
                            parent.leftChild = node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if(current == null)
                        {
                            parent.rightChild = node;
                            return;
                        }
                    }
                }
            }

        }
        public bool Search(int index)
        {
            Node current = root;
            while(current != null)
            {
                if(index == current.data)
                {
                    return true;
                }
                else if(index < current.data)
                {
                    current = current.leftChild;
                }
                else
                {
                    current = current.rightChild;
                }
            }
            return false; // Platzhalter
        }
        public void InOrderTraversal(Node node)
        {
            if (node != null)
            {
                InOrderTraversal(node.leftChild);
                Console.Write(node.data + " ");
                InOrderTraversal(node.rightChild);
            }
        }
    }
}
