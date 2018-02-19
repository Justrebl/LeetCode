using LeetCode.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            var result = solution.PreorderTraversal(solution.BuildExampleTree());

            string resultString = result.PrepareResult();
            
            Console.WriteLine("{0}", resultString);
            Console.ReadLine();
        }
    }

    

    public class TreeNode
    {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public TreeNode BuildExampleTree()
        {
            /*
             * Exemple Binary Tree
             * ----1
             * ---/-\
             * --2---3
             * -----/
             * ----4
             */
             
            TreeNode node_4 = new TreeNode(4);
            TreeNode node_3 = new TreeNode(3) {
                left = node_4
            };
            TreeNode node_2 = new TreeNode(2)
            { };

            TreeNode node_1 = new TreeNode(1)
            {
                left = node_2,
                right = node_3
            };

            return node_1;
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            if (root == null)
                return result;

            var currentTree = new Stack<TreeNode>();
            var currentNode = root;
            var visitedNodes = new List<TreeNode>();

            currentTree.Push(currentNode);

            while (currentTree.Count > 0)
            {
                currentNode = currentTree.Peek();

                if (!visitedNodes.Contains(currentNode))
                {                    
                    visitedNodes.Add(currentNode);
                    result.Add(currentNode.val);
                }

                if (currentNode.left != null && !visitedNodes.Contains(currentNode.left))
                {
                    currentNode = currentNode.left;
                    currentTree.Push(currentNode);
                }
                else if (currentNode.right != null && !visitedNodes.Contains(currentNode.right))
                {
                    currentNode = currentNode.right;
                    currentTree.Push(currentNode);
                }
                else
                    currentTree.Pop();
            } 
            return result;
        }
    }


}
