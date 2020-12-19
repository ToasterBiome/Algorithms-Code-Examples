using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsCodeExamples
{

    class Node
    {
        public char? word;
        public List<Node> children = new List<Node>();

        public Node Add(char val)
        {
            for(int i = 0; i < children.Count; i++)
            {
                //if it is one of the children already??

                if (children[i].word == val)
                {
                    return children[i];
                }
            }

            //doesn't exist, need to make

            Node newNode = new Node();
            newNode.word = val;
            children.Add(newNode);
            return newNode;
        }

        public Node Get(char val)
        {
            //looks to be the same as add but returns null if it cant find anything??
            for (int i = 0; i < children.Count; i++)
            {
                //if it is one of the children already??

                if (children[i].word == val)
                {
                    return children[i];
                }
            }

            return null;
        }
    }

    class RootNode
    {
        public Node root = new Node();

        public void AddChildren(string childWord)
        {
            Node currentNode = root;
            for (int i = 0; i < childWord.Length;i++)
            {
                //recursively add the children nodes if they don't exist, return them if they DO exist!
                currentNode = currentNode.Add(childWord[i]);
            }
        }

        public bool ContainsChildren(string childWord)
        {
            //a lot like add children
            Node currentNode = root;
            for (int i = 0; i < childWord.Length; i++)
            {
                //recursively find the children nodes
                currentNode = currentNode.Get(childWord[i]);
                if(currentNode == null)
                {
                    return false;
                }
            }

            //if we ran to the end of the line

            if (currentNode == null)
            {
                return false;
            }

            //if the last child is null

            if(currentNode.word == null)
            {
                return false;
            }

            //it contains the word!!

            return true;
        }
    }

    class Program
    {

        
        static void Main()
        {

            RootNode tree = new RootNode();

            tree.AddChildren("joemama");
            tree.AddChildren("joepapa");
            tree.AddChildren("creeperawman");
            tree.AddChildren("sowebackinthemines");

            Console.WriteLine(tree.ContainsChildren("joemama")); //should be true
            Console.WriteLine(tree.ContainsChildren("creeperawman")); //should be true
            Console.WriteLine(tree.ContainsChildren("bingusforlyfe")); //should be false

            Console.ReadLine();
        }

        
    }
}
