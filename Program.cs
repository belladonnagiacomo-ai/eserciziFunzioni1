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
        static bool ControlloA (string n, int p)
        {
            string a = "Marco", b = "Giacomo", c = "Luca", d = "Alessio";
            
            if (n == a || n== b || n == c || n == d )
            {
                if (p == 1234)
                {
                    return true;
                }
                
               
            }

            return false;
        }
       
        static double calcolaS( string c, double prezzo)
        {
            
            double sconto=0;
            if (c == "elettronica")
            {
                if (prezzo > 400)
                {
                    sconto = (prezzo * 15) / 100;
                    double prezzoF = prezzo - sconto;
                }

            }
            else if (c == "abbigliamento")
            {
                if(prezzo >= 350)
                {
                    sconto = (prezzo * 25) / 100;
                    double prezzoF = prezzo - sconto;
                }

            }


                return sconto;
        }
        static void Main(string[] args)
        {
            int ris = sommaN();
            Console.WriteLine(ris);
            Console.WriteLine("dammi un nome:");
            string n= Console.ReadLine();
            Console.WriteLine("dammi la password(4 cifre):");
            int p = Convert.ToInt32(Console.ReadLine());
            
            if (ControlloA(n, p) == true) {
                Console.WriteLine("sei entrato");
            }
            else
            {
                Console.WriteLine("non sei entrato");
            }
            Console.WriteLine("Quale categoria di prodotto vuoi scegliere(elettronica, alimentari, abbigliamento):");
            string c = Console.ReadLine();
            Console.WriteLine("dimmi il prezzo del prodotto scelto:");
            double prezzo = Convert.ToDouble(Console.ReadLine());
           if (c == "alimentari")
            {
                Console.WriteLine("non c e uno sconto sui alimentari");
            }
           else if(c == "elettronica")
            {
                
                Console.WriteLine("lo sconto e di:" + calcolaS( c, prezzo));
            }


        }
        
    }
}