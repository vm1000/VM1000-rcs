using System;
namespace Day8
{
    public class PirmaisPiemers
    {
        public void DarbibaArMasivu()
        {
            //viendimensiju masīvs, ta lai cilvēks ievada
            //masīva garums 4 vērtības
            //vērtības jāievada, kamēr izvēlas ka vairs negrib
            //ievadam vienu vērtību un katras ievades beigās izvadās viss masīvs
            //pārrakstam vērtības 
            MasivaIzveide();
        }

        private void MasivaIzveide()
        {
            String izvele = "";

            while (izvele != "0")
            {
                Console.WriteLine("Nospiediet 1,lai ievadītu vērtības, 2 lai atjaunotu, 0 - iziet");
                izvele = Console.ReadLine();
                switch (izvele)
                {
                    case "1":
                        MasivaVertibas();
                        break;
                    case "2":
                        Stripas();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("nepareiza ievade");
                        break;
                }
            }
        }

        private void MasivaVertibas()
        {
            Console.WriteLine("Ievadiet masīva vērtības");

            String[] daudzasVirknes = new String[4];

            String izvele2 = "";

            //izvele2 = Console.ReadLine();

            while (izvele2 != "2")
            {
                //MasivaVertibas();
                for (int i = 0; i < daudzasVirknes.Length; i++)
                {
                    Console.WriteLine("Ievadiet masīva vērtibu");
                    daudzasVirknes[i] = Console.ReadLine();

                    for (int j = 0; j < daudzasVirknes.Length; j++)
                    {
                        Console.Write(daudzasVirknes[j] + " ");
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Vai vēlaties turpināt? 1 - Jā, 2 - uz izvēlni");


                izvele2 = Console.ReadLine();
            }

            Console.WriteLine();

        }

        private void Stripas()
        {
            String[] stripinas = new string[4];
            for (int i = 0; i < 4; i++)
            {
                stripinas[i] = "-";
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("-");
            }


            //int garums = 0;
            //Console.WriteLine("Ievadiet strīpiņas daudzumu!");
            //String stripina = "-";
            //stripina = Console.ReadLine();
            //String[] daudzasVirknes = new String[garums];

            //for (int i = 0; i < daudzasVirknes.Length; i++)
            //{
            //    Console.WriteLine(daudzasVirknes[i]);
            //}


        }

    }
}
