using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            var root = new TreeNode(1);
            root.Right = new TreeNode(3);
            root.Left = new TreeNode(2);
            root.Right.Left = new TreeNode(4);
            root.Right.Right = new TreeNode(5);
            root.Left.Left = new TreeNode(6);
            SerializeTree(root);
            Console.ReadKey();
        }

        public static void SerializeTree(TreeNode root)
        {
            var list = ReturnTree(root, new List<int?>());
            TreeNode root2 = FormTree(root, list, 0);
            Console.WriteLine();
        }

        public static TreeNode FormTree(TreeNode root, List<int?> allValues, int counter)
        {
            if (counter == allValues.Count) return root;
            if (root == null) return null;
            root = allValues.ElementAt(counter) == null ? null : new TreeNode((int)allValues.ElementAt(counter));
            counter = counter + 1;
            root.Left = FormTree(root, allValues, counter);
            root.Right = FormTree(root, allValues, counter);
            return root;
        }

        //PreOrder Traversal
        public static List<int?> ReturnTree(TreeNode root, List<int?> allValues)
        {
            //if (root != null && root.Left == null && root.Right == null)
            //{
            //    allValues.Add(root.Data);
            //    return allValues;
            //}
            if (root == null)
            {
                allValues.Add(root?.Data);
                return allValues;
            }
            allValues.Add(root.Data);
            ReturnTree(root.Left, allValues);
            ReturnTree(root.Right, allValues);
            return allValues;
        }
    }
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode(int data)
        {
            this.Data = data;
        }
    }
}
