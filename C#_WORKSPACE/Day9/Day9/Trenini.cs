using System;
namespace Day9
{
    public class Trenini
    {
       public void Menu()
        {
            //Switch case ar while


            //Restite4();
            ZvaigzniteVaiRestite();
          
        }

        private void Restite()
        {
            try
            {
                int skaitlis = Ievade();

                String reste = "";
                for (int i = 0; i < skaitlis; i++)
                {
                    reste = reste + "#";
                }

                Console.WriteLine(reste);
            }
            catch
            {
                Console.WriteLine("Nepreiza darbība");
            }
          
            //int mainigais = 0;
           
            //String restite = "#";

            //Console.WriteLine("Lūdzu ievadiet vērtību!");

            //restite = Console.ReadLine();
            //mainigais = Convert.ToInt16(restite);


            //for (int i = 0; i < mainigais; i++)
            //{
            //    Console.WriteLine(restite[i]);
            //    //restite = restite + "#";

            //}
            ////Console.WriteLine(restite + "#");
        }

        private int Ievade()
        {
            Console.WriteLine("ievadiet skaitli");
            String simboli = Console.ReadLine();
            int result = Convert.ToInt16(simboli);

            return result;
        }


        private void Restite3()
        {
            int skaitlis = Ievade();

            char[] restites = new char[skaitlis];

            for (int i = 0; i < skaitlis; i++)
            {
                restites[i] = '#';
                Console.Write(restites[i]);
            }

        }

        private void Restite4()
        {
            String[] reste = new string[5] { "#", "##", "###", "####", "#####" };

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(reste[i]);
            }
        }


        private void SkaitlaIevade()
        {
            int skaitlis = Ievade();

            int fak = 0;


            for (int i = 1; i < skaitlis; i++)
            {
                fak = i + fak;
                //jaunsSkaitlis = jaunsSkaitlis + skaitlis;
            }
                
            Console.WriteLine("rezultāts ir: " + fak);
        }

        private void ZvaigzniteVaiRestite()
        {
            //%

            String[] vii = new string[8];

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("*");
                }
                else 
                {
                    Console.WriteLine("#");
                }

            }
        }
    }
}

