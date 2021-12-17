using System;
using System.Collections.Generic;

namespace Hanoi_Tornyai
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            HanoiProject test = new HanoiProject(new int[] {3,2,1 });
            test.Átmozgat();
            Console.ReadKey();
        }
        
    }
    public class HanoiProject
    {
        static Stack<int> f = new Stack<int>();
        static Stack<int> s = new Stack<int>();
        static Stack<int> c = new Stack<int>();

        public HanoiProject(int[] tomb)
        {
            foreach (int i in tomb)
            {
                f.Push(i);
            }
        }
        public void Átmozgat()
        {
            KiIr();
            Hanoi(f.Count,ref f, ref c, ref s);
        }
        public static void Hanoi(int N, ref Stack<int> forras, ref Stack<int> cel, ref Stack<int> seged)
        {
            if (N == 1)
            {
                cel.Push(forras.Pop());
                KiIr();
            }
            else
            {
                Hanoi(N - 1, ref forras, ref seged, ref cel);
                cel.Push(forras.Pop());
                KiIr();
                Hanoi(N - 1, ref seged, ref cel, ref forras);
            }
        }
        public static void KiIr()
        {
            int[] fArray = f.ToArray();

            Console.WriteLine("\nForrás: ");
            foreach (int i in fArray)
            {
                Console.Write(i);
            }

            int[] sArray = s.ToArray();

            Console.WriteLine("\nSegéd: ");
            foreach (int i in sArray)
            {
                Console.Write(i);
            }

            int[] cArray = c.ToArray();

            Console.WriteLine("\nCél: ");
            foreach (int i in cArray)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}