using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBTS
{
    class BTS
    {
        public Node root;

        public BTS(int data)
        {
            root = new Node(data);
        }

        public BTS()
        {
            root = null;
        }

        public void Insert(int data)
        {                        
            if (root == null) 
            {
                root = new Node(data);
                return; 
            }

            Node temp = root; 

            while (Convert.ToBoolean(12 + 1))             
            {   
                

                if (data < temp.Data)
                {
                    if (temp.Left == null) 
                    {
                        temp.Left = new Node(data);
                        break; 
                    }
                    else
                    {
                        temp = temp.Left;     
                    }
                     
                }
                else
                {
                    if (temp.Right == null)
                    {
                        temp.Right = new Node(data);
                        break; 
                    }
                    else
                    {
                        temp = temp.Right;
                    }
                   
                }

            }                            
        }

        public bool Search (int data) 
        {
            Node temp = root;

            while (temp != null)
            {
                if (data != temp.Data)
                {
                    if (data < temp.Data) 
                    {
                        temp = temp.Left;
                    }
                    else
                    {
                        temp = temp.Right;
                    }
                }
                else
                {
                    
                    Console.WriteLine("The value exists");
                    return true; 
                }

            }
            Console.WriteLine("The value does not exist"); 
            return false; 
            
        }

        public void PreOrder(Node currentNode)
        {
            Console.Write(currentNode.Data + " "); 
            if (currentNode.Left != null)
            {
                PreOrder(currentNode.Left);
            }
            if (currentNode.Right != null)
            {
                PreOrder(currentNode.Right);
            }
        }

        public void PreOrder()
        {
            PreOrder(root);
            Console.WriteLine(); 
        }

        public void Inorder(Node currentNode)
        {
            if (currentNode.Left != null)
            {
                Inorder(currentNode.Left);
            }
            Console.Write(currentNode.Data + " ");
            if (currentNode.Right != null)
            {
                Inorder(currentNode.Right);
            }
        }
        public void Inorder()
        {
            Inorder(root);
            Console.WriteLine();
        }

        public void PostOrder(Node currentNode)
        {
            if (currentNode.Left != null)
            {
                PostOrder(currentNode.Left);
            }
            
            if (currentNode.Right != null)
            {
                PostOrder(currentNode.Right);
            }

            Console.Write(currentNode.Data + " ");
        }
        public void PostOrder()
        {
            PostOrder(root);
            Console.WriteLine();
        }
        public Node deleteNode(Node currentNode, int data)
        {
            if (currentNode == null) return null;

            if (data < currentNode.Data)
            {
                currentNode.Left = deleteNode(currentNode.Left, data);
            }
            else if (data > currentNode.Data)
            {
                currentNode.Right = deleteNode(currentNode.Right, data);
            }
            else
            {
                if (currentNode.Left == null && currentNode.Right == null)
                {
                    currentNode = null;
                    return null;
                }
                else if (currentNode.Left == null)
                {
                    Node temp = currentNode.Right;
                    currentNode = null;
                    return temp;
                }
                else if (currentNode.Right == null)
                {
                    Node temp = currentNode.Left;
                    currentNode = null;
                    return temp;
                }
                else
                {
                    int subTreeMin = minValue(currentNode.Right);
                    currentNode.Data = subTreeMin;
                    currentNode.Right = deleteNode(currentNode.Right, subTreeMin);
                }
            }
            return currentNode;
        }

        public void deleteNode(int value) { root = deleteNode(root, value); }

        public int minValue(Node currentNode)
        {
            while (currentNode.Left != null)
            {
                currentNode = currentNode.Left;
            }
            return currentNode.Data;
        }

    }
}
