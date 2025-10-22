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
        static string versioneS(int n)
        {
        }

        static void Main(string[] args)
        {
            int ris = sommaN();
            Console.WriteLine(ris);

        }
        fdkjshgytgfvdasfwedabs
    }
}