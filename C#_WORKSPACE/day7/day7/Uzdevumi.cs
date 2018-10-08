using System;
namespace day7
{
    public class Uzdevumi
    {
        public void Izvelne()
        {
            Viendimensiju();
            Ievade();
        }

        private void Viendimensiju()
        {
            //Console.WriteLine("Ievadiet masīva garumu!");
            //String vertiba = Console.ReadLine();
            //int masivaVertiba = Convert.ToInt16(vertiba);

            //if (masivaVertiba < 9 && masivaVertiba >= 0)
            //{
            //    Console.WriteLine("Masīva garums pareizs");
            //    String[] janusMasivs = new string[masivaVertiba];

            //    Console.WriteLine("Lūdzu ievadiet masīva vērtības");
            //    String vertiba2 = Console.ReadLine();
            //    int masivaVertiba2 = Convert.ToInt16(vertiba2);


            //    if (masivaVertiba2 > 6 )
            //    {
            //        Console.WriteLine("!ERROR!");
            //        Viendimensiju();
            //    } 
            //    else
            //    {                              
            //        Console.WriteLine("Jūsu masīvs sastāv no " + masivaVertiba2 + " elementiem");
            //        Viendimensiju();
            //    }

            //    for (int i = 0; i < masivaVertiba2; i++)
            //    {
            //        Console.WriteLine(vertiba2[i]);
            //    }

            //} else 
            //{
            //    Console.WriteLine("Masīva garums nepareizs");
            //    Viendimensiju();
            //}


            int garums = 0;

            while(garums < 1 || garums > 9)
            {
                garums = Ievade();
            }



            String[] daudzasVirknes = new string[garums];

            for (int i = 0; i < daudzasVirknes.Length; i++)
            {
                Console.WriteLine("Ievadiet masīva vērtību");
                daudzasVirknes[i] = Console.ReadLine();
                if(daudzasVirknes[i].Length > 6)
                {
                    daudzasVirknes[i] = "ERROR!";
                }

            }

            for (int i = 0; i < daudzasVirknes.Length; i++)
            {
                Console.WriteLine(daudzasVirknes[i]);
            }

        }
        



        private int Ievade()
        {
            int result = 0;
            try
            {
                Console.WriteLine("Ievadiet masiva garumu!");
                String input = Console.ReadLine();
                result = Convert.ToInt16(input);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Nepareiza ievade masīvam garums 5");
                Console.WriteLine(ex.Message);
                result = 5;
            }
            return result;

        }

        private void Divdimensiju()
        {

        }
    }
}

