using System;
namespace day4
{
    public class Matematika
    {


        public void Izvelne()
        {


        
            
            String choise = "";


            while (choise != "iziet")
            {

                Console.WriteLine("Izvēlaties kādas darbības jūs vēlaties veikt:" +
                              " saskaitīt,atņemt vai kāpināt vai arī iziet");
                choise = Console.ReadLine();


                switch (choise)
                {
                    case "saskaitīt":
                        Saskaitit();
                        break;

                    case "atņemt":
                        Atnemsana();
                        break;

                    case "kāpināt":
                        Kapinasana();
                        break;

                    case "iziet":
                        break;

                    default:
                        Console.WriteLine("nepareiza ievade!");
                        break;
                }
            }
        }


        private void Saskaitit()

        {
            int a, b;
            Console.WriteLine("Ievadiet Skaitli!");
            String virkne = Console.ReadLine();
            a = Convert.ToUInt16(virkne);

            Console.WriteLine("Ievadiet Skaitli!");
            virkne = Console.ReadLine();
            b = Convert.ToUInt16(virkne);


            int rezultats = a + b;

            Console.WriteLine(rezultats);
               
        }


        private void Atnemsana()
        {
            int a, b;


            a = Parveidosana();
            b = Parveidosana();

            Console.WriteLine("Ievadiet 1 lai saskaitītu, 2 lai atņemtu");
            String izvele = Console.ReadLine();

            if(izvele == "1")
            {
                Console.WriteLine(a + b);
            }

            else if(izvele == "2")
            {
                Console.WriteLine(a - b);
            } else
            {
                Console.WriteLine("Ievade nav pareiza!");
            }

            //int rezultats = a - b;

            //Console.WriteLine(rezultats);

            //Console.WriteLine("Ievadiet skaitli!");
            //String simboluVirkne = Console.ReadLine();
            //int jaunaisSkaitlis = Convert.ToInt16(simboluVirkne);

            //Console.WriteLine("Ievadiet skaitli 2!");
            //simboluVirkne = Console.ReadLine();
            //int jaunaisSkaitlis2 = Convert.ToInt16(simboluVirkne);
            //Console.WriteLine(jaunaisSkaitlis - jaunaisSkaitlis2); 
            
        }

        private int Parveidosana()
        {
            Console.WriteLine("Ievadiet Skaitli!");
            String virkne = Console.ReadLine();
            int result = Convert.ToUInt16(virkne);
            return result;

        }

        //5 reizes prasa ievadīt kādu vārdu un beigās to visu izvadam
        //public void Vardi()
        //{
        //    String vardi = "";
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine("Ievadiet vārdu!");
        //        String pasreizejais = Console.ReadLine();
        //        vardi = vardi + " " + pasreizejais;

        //    }
        //    Console.WriteLine(vardi);
        //}

        //// cilvēks ievada skaitli un pakāpi, un tiek izvadīts rezultāts

        private void Kapinasana()
        {
            int skaitlis = Parveidosana();
            int pakape = Parveidosana();
            int rezultats = 1;


            for (int i = 0; i < pakape; i++) 

            {
                rezultats = rezultats * skaitlis;
            }
            Console.WriteLine(rezultats);
        }


    }
}
