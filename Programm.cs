using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Xml.Linq;

namespace MeinProgramm
{
    class Program
    {
        // Hauptmethode des Programms
        static void Main(string[] args)
        {
            // Hier können Sie Instanzen von BinarySearchTree erstellen und Methoden aufrufen
        }
    }

    // Klasse für die Knoten des Baums
    class Node
    {
        public int data; // Der Wert, den der Knoten speichert
        public Node leftChild; // Linker Kindknoten dieses Knotens
        public Node rightChild; // Rechter Kindknoten dieses Knotens
    }

    // Klasse für den binären Suchbaum
    class BinarySearchTree
    {
        Node root; // Wurzelknoten des Baums

        // Methode zum Einfügen eines neuen Knotens in den Baum
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
                Node current = root; // Beginnen Sie mit der Wurzel
                Node parent;

                // Durchlaufen Sie den Baum, um den richtigen Platz für den neuen Knoten zu finden
                while(true)
                {
                    parent = current;
                    if(index < current.data) // Gehe nach links, wenn der neue Wert kleiner ist
                    {
                        current = current.leftChild;
                        if(current == null) // Wenn es keinen linken Kindknoten gibt, füge den neuen Knoten hier ein
                        {
                            parent.leftChild = node;
                            return;
                        }
                    }
                    else // Gehe nach rechts, wenn der neue Wert größer ist
                    {
                        current = current.rightChild;
                        if(current == null) // Wenn es keinen rechten Kindknoten gibt, füge den neuen Knoten hier ein
                        {
                            parent.rightChild = node;
                            return;
                        }
                    }
                }
            }
        }

        // Methode zum Suchen eines Werts im Baum
        public bool Search(int index)
        {
            Node current = root; // Beginnen Sie mit der Wurzel

            // Durchlaufen Sie den Baum, bis der Wert gefunden wird oder alle Knoten durchsucht wurden
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

            return false; // Wenn der Wert nicht gefunden wird, geben Sie false zurück
        }

        // Methode zum Durchlaufen des Baums in aufsteigender Reihenfolge
        public void InOrderTraversal(Node node)
        {
            if (node != null)
            {
                InOrderTraversal(node.leftChild); // Besuchen Sie zuerst den linken Unterbaum
                Console.Write(node.data + " "); // Dann drucken Sie den Wert des Knotens
                InOrderTraversal(node.rightChild); // Zuletzt besuchen Sie den rechten Unterbaum
            }
        }
    }
}
