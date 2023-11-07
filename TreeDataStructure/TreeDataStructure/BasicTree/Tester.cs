using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataStructure.BasicTree
{
    public class Tester
    {
        static void Main(string[] args)
        {
            Tree<Employee> companyTree = new Tree<Employee>(new(100, "Jamro", "CEO"))
                .CreateBranch(new(110, "John", "HOD"))
                    .CreateBranch(new(111, "Chris", "Snr. Dev"))
                        .Add(new(1111, "Eric", "Jnr. Dev"))
                        .CreateBranch(new(1112, "Ashley", "Jnr. Dev"))
                            .Add(new(111121, "Emily", "Dev. Intern"))
                        .CloseBranch()
                    .CloseBranch()
                .CloseBranch()
                .CreateBranch(new(120, "Mary", "HOR"))
                    .Add(new(121, "Jimmy", "Snr. Res"))
                    .Add(new(122, "Andy", "Snr. Res"))
                .CloseBranch()
                .CreateBranch(new(130, "Lily", "HOS"))
                    .CreateBranch(new(131, "Anthony", "Snr. Sales"))
                        .Add(new(1311, "Paula", "Jnr. Sales"))
                        .Add(new(1312, "Sarah", "Jnr. Sales"))
                    .CloseBranch()
                     .Add(new(132, "Angela", "Snr. Sales"))
                     .Add(new(133, "Tommy", "Snr. Sales"))
                .CloseBranch();

           //Display the company hierarchy
            foreach (Node<Employee> n in companyTree.Nodes)
            {
                Print(companyTree.Root, 0);
            }
        }
        static void Print(Node<Employee> node, int level)
        {
            Console.WriteLine($"{new string(' ',level * 4)}{node.Data.Name} ({node.Data.Role})");
            level++;
            foreach (Node<Employee> n in node.Children)
            {
                Print(n, level);
            }
        }
    }
}
