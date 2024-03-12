// See https://aka.ms/new-console-template for more information
/*
Aufgabe: Implementieren Sie einen binären Suchbaum in C#. 

Anforderungen:
1. Erstellen Sie eine Klasse "Node" mit den Eigenschaften "data", "leftChild" und "rightChild".
2. Erstellen Sie eine Klasse "BinarySearchTree" mit den Methoden "Insert", "Search" und "InOrderTraversal".
3. Die Methode "Insert" sollte einen neuen Knoten in den Baum einfügen.
4. Die Methode "Search" sollte einen bestimmten Wert im Baum suchen und true zurückgeben, wenn der Wert gefunden wird, sonst false.
5. Die Methode "InOrderTraversal" sollte den Baum in aufsteigender Reihenfolge durchlaufen und die Werte ausgeben.

Hinweis: Sie können davon ausgehen, dass die Eingabewerte für "Insert" und "Search" Ganzzahlen sind.
*/

// Ihre Lösung hier

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
