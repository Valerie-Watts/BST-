using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBTS
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BTS tree = new BTS();

            int numb;
            int opt;

            do
            {
                Console.WriteLine("\nBinary Search Tree!");
                Console.WriteLine("Enter a number for the action you want to realize \n");

                Console.WriteLine("1.Insert a node\n2.Search for a node\n3.Print Preorder\n4.Print Inorder\n5.Print Postorder\n6.Delete a Node\n7.Exit");
                opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine("What number do you want to insert?");
                        numb = Convert.ToInt32(Console.ReadLine());
                        tree.Insert(numb);

                        break;
                    case 2:
                        Console.WriteLine("What number are you looking for?");
                        numb = Convert.ToInt32(Console.ReadLine());
                        tree.Search(numb);

                        break;
                    case 3:
                        tree.PreOrder();

                        break;
                    case 4:
                        tree.Inorder();

                        break;
                    case 5:
                        tree.PostOrder();

                        break;
                    case 6:
                        Console.WriteLine("What number do you want to delete?"); 
                        numb = Convert.ToInt32(Console.ReadLine());
                        tree.deleteNode(numb); 
                        break;
                    case 7:
                        Console.WriteLine("Goodbye!");
                        return; 
                }
            } while (opt != 7); 
            

        }
    }
}
