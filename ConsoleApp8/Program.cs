using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up adjacency matrix
            Dictionary<string, List<string>> adj = new Dictionary<string, List<string>>();



            List<string> AsList = new List<string>();
            AsList.Add("B");
            AsList.Add("C");

            List<string> BsList = new List<string>();

            BsList.Add("A");
            BsList.Add("D");
            BsList.Add("E");

            List<string> CsList = new List<string>();
            BsList.Add("A");
            CsList.Add("F");
            CsList.Add("G");

            List<string> DsList = new List<string>();
            DsList.Add("B");

            List<string> EsList = new List<string>();
            EsList.Add("B");


            List<string> FsList = new List<string>();
            FsList.Add("C");

            List<string> GsList = new List<string>();
            GsList.Add("C");

            adj.Add("A", AsList);
            adj.Add("B", BsList);
            adj.Add("C", CsList);
            adj.Add("D", DsList);
            adj.Add("E", EsList);
            adj.Add("F", FsList);
            adj.Add("G", GsList);

            Queue<string> toVisit = new Queue<string>();
            Queue<string> visited = new Queue<string>();
            
            
            
            // Actual algorithm

            toVisit.Enqueue("A");

            string currentNode;
            while (toVisit.Count() != 0)
            {
                currentNode = toVisit.Dequeue();
                visited.Enqueue(currentNode);
                foreach (string n in adj[currentNode])
                {
                    if (!visited.Contains(n) && !toVisit.Contains(n))
                    {
                        toVisit.Enqueue(n);
                    }
                }
            }

            // printing out visited.
            Console.WriteLine("Depth First");
            foreach (string n in visited)
            {
                Console.WriteLine(n);
            }



            Stack<string> st = new Stack<string>();
            Queue<string> q = new Queue<string>();

            string v = "A";
            
            st.Push(v);
            while(st.Count!=0)
            {
                v = st.Pop();
                if (!q.Contains(v))
                {
                    q.Enqueue(v);
                    foreach(string x in adj[v])
                    {
                        if (!q.Contains(x))
                        {
                            st.Push(x);
                        }
                    }
                }

            }
            Console.WriteLine("Depth First");
            foreach(string x in q)
            {
                Console.WriteLine(x);
            }

        }
    }
}
