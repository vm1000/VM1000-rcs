using System;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Piemers();
            //Piemers2(3, 5);
            //Piemers2(32, 15);

            //int skaitlis = Piemers3();

            //Console.WriteLine(skaitlis);


            Console.WriteLine("Ievadiet skaitli!");
            String simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            Console.WriteLine("Ievadiet skaitli 2!");
            simboluVirkne = Console.ReadLine();
            int jaunaisSkaitlis2 = Convert.ToInt16(simboluVirkne);

            int summa = Saskaitisana(jaunaisSkaitlis, jaunaisSkaitlis2);
            Console.WriteLine(summa);



            Zvaigzne(3);

            Console.ReadLine();
        }

        static void Piemers() 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 4; i > 0; i--)
            {
                Console.WriteLine(i);
            }


            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }

            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 5);



            string Zvaigzne = "*";
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Zvaigzne);
                Zvaigzne = Zvaigzne + "*";
            }

        }
        static void Piemers2(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int Piemers3()
        {
            int rezultats = 6 + 8;

            return rezultats;
        }

        static int Saskaitisana(int skaitlis, int skaitlis2)
        {
            int rezultats = skaitlis + skaitlis2;
            return rezultats;
        }


        static void Zvaigzne(int robeza)
        {
            string zvaigzne = "*";
            for (int i = 0; i < robeza; i++)
            {
                Console.WriteLine(zvaigzne);
                zvaigzne = zvaigzne + "*";
            }
        }
    }
}
        
