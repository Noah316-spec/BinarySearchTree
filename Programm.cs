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
            // Hier können Sie Instanzen von BinarySearchTree erstellen und Methoden aufrufen
        }
    }

    // Klasse für die Knoten des Baums
    class Node
    {
        public int data; // Der Wert, den der Knoten speichert
        public Node leftChild; // Linker knoten 
        public Node rightChild; // Rechter knoten 
    }

    
    class BinarySearchTree
    {
        Node root; // Wurzelknoten des Baums

       //Einfügen der Werte
        public void Insert(int index, Node node) 
        { 
            node.data = index; // Setzen des Werts des Knotens

            // Wenn der Baum leer ist, wird der neue Knoten zur Wurzel
            if(root == null)
            {
                root = new Node();
            }
            else
            {
                Node current = root; 
                Node parent;

                //richtigen Platz für den neuen Knoten finden
                while(true)
                {
                    parent = current;
                    if(index < current.data) // Gehe nach links wenn der neue Wert kleiner ist
                    {
                        current = current.leftChild;
                        if(current == null) // Wenn es keinen linken Kindknoten gibt, füge den neuen Knoten hinzu
                        {
                            parent.leftChild = node;
                            return;
                        }
                    }
                    else // Gehe nach rechts, wenn der neue Wert größer ist
                    {
                        current = current.rightChild;
                        if(current == null) // Wenn es keinen rechten Kindknoten gibt, füge den neuen Knoten hinzu
                        {
                            parent.rightChild = node;
                            return;
                        }
                    }
                }
            }
        }

        // Suchen
        public bool Search(int index)
        {
            Node current = root;

            // Durchlaufen bis der Wert gefunden wird oder alle Knoten durchsucht wurden
            while(current != null)
            {
                if(index == current.data) // Wenn der Wert gefunden wird, geben Sie true zurück
                {
                    return true;
                }
                else if(index < current.data) // Wenn der gesuchte Wert kleiner ist, gehe nach links
                {
                    current = current.leftChild;
                }
                else // Wenn der gesuchte Wert größer ist, gehe nach rechts
                {
                    current = current.rightChild;
                }
            }

            return false; // Nicht gefunden false zurückgegeben
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
