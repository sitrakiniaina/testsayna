using System;

namespace TestSAYNA
{
    class Program
    {
        public static int Somme (int nb1, int nb2)
        {
            return nb1 + nb2;
        }

        public static int Fact(int n)
        {
            var rep = 1;
            for (int i=1;i<=n;i++)
            {
                rep = rep * i;
            }
            return rep;
        }
        
        public static Boolean Divise(int A, int B)
        {
            return A % B == 0;
        }

        public static Boolean Voyelle(Char caractere)
        {
            Char[] tab = { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i=0;i<tab.Length;i++)
            {
                if (caractere == tab[i])
                {
                    return true;                   
                }
            }
            return false;
        }

        public static void Permute(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        public static int Vabs(int a)
        {
            return (a < 0) ? -a : a;
        }
        static void Main(string[] args)
        {
            int a = 3;
            int b = 3;
            Console.WriteLine(Vabs(a) + "Vabs" + Vabs(b));
            Console.WriteLine("Hello World!" + Math.Abs(a) + "Vabs" + Math.Abs(b));
        }
    }
}
