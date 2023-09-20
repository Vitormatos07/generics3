using System;

namespace generics3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int userNumber = int.Parse(Console.ReadLine());
                courseA.Add(userNumber);
            }

            Console.Write("How many students for course? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int userNumber = int.Parse(Console.ReadLine());
                courseB.Add(userNumber);
            }

            Console.Write("How many students for course? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int userNumber = int.Parse(Console.ReadLine());
                courseC.Add(userNumber);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}