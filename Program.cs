using System.Runtime.CompilerServices;

namespace eserciziFunzioni
{
    internal class Program
    {
        static bool verificaN(int n)
        {

            int r = n % 5;
            if (r == 0)
            {
                return true;
            }

            return false;


        }
        static int sommaN()
        {
            int s = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (verificaN(i) == true)
                {
                    s = s + i;
                }

            }
            return s;
        }
        static bool controlloA (string  n)
        {
            string a = "Marco", b = "Giacomo", c = "Luca", d = "Alessio";
            if (n = a || b || c || d)
            {
                return true;
            }

           return false;
        }
        static bool passwordS(int p)
        {
            p = 1234;
            if (p == 1234)
            {
                return true;
            }

            return false;
        }
        static void Main(string[] args)
        {
            int ris = sommaN();
            Console.WriteLine(ris);
            Console.WriteLine("dammi un nome:");
            string nome = Console.ReadLine();
            controlloA(nome);
            if (controlloA(nome) == true) {

                int p = 0;
                while (passwordS(p) == false)
                {
                    Console.WriteLine("dimmi la password per entrare(sono 4 numeri):");
                    p = Convert.ToInt32(Console.ReadLine());
                    passwordS(p);

                    if (passwordS(p) == true)
                    {
                        Console.WriteLine("sei entrato");
                    }
                    else
                    {
                        Console.WriteLine("non sei entrato, riprova");
                    }
                }

            
            }


        }
        
    }
}