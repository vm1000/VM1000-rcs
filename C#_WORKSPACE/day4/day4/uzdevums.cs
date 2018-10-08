using System;
namespace day4
{
    public class Uzdevums
    {

        private int a = 4;
        public int b = 6;




        public void Interfeiss()
        {
            a = 6;
            GarumParbaude();
        }

       private void GarumParbaude()
        {
            Console.WriteLine("Ievadiet simbolus!");
            String simboli = Console.ReadLine();


            if(simboli.Length > 1 && simboli.Length < 13)
            {
                Console.WriteLine("Viss ir ok!");
            }
            else
            {
                Console.WriteLine("Nepareiza izvade!");
            }

        }

        private void Izvelne()
        {
            String c = "11";

            switch(c)
            {
                case "0":
                    Console.WriteLine("vii");
                    break;
                case "1":
                    Console.WriteLine("vii2");
                    break;

                default:
                    Console.WriteLine("nee");
                    break;
            }
        }

        public void Menu()
        {
            
            String choise = "";


            while (choise != "iziet")
            {
                
                Console.WriteLine("Ievadiet simbolu 1, 2, 3, vai iziet");
                choise = Console.ReadLine();


                switch(choise)
                {
                    case "1":
                        Console.WriteLine("wii");
                        break;

                    case "2":
                        Console.WriteLine("wii2");
                        break;

                    case "3":
                        Console.WriteLine("wii3");
                        break;

                    case "iziet":
                        break;

                    default:
                        Console.WriteLine("nepareiza ievade!");
                        break;
                }

            }

            //cilvēks ievada simbolu virkni, un to jādara kamēr nav ievadijis vārdu iziet
        }



        public void Cikli()
        {
            String zvaigzne = "*";

            while (zvaigzne.Length < 5)
            {
                Console.WriteLine(zvaigzne);
                zvaigzne = zvaigzne + "*";
            }
        }





       
    }
}



//cilvēks ievada simbolu virkni un jāparbauda vai gaurums ir min.1 simb. max 12 simb.
// ja atbilst - viss ok
// ja nē - nepareiza ievade
//GarumParbaude paliek private


//String args = "";

//int garums = args.Length;

//int maxGarums = 12;
//int minGarums = 1;

//Console.WriteLine("Ievadiet simbolus!");

//Console.ReadLine();

//if (garums > maxGarums)
//{

//    Console.WriteLine("Nepareiza ievade!");


//} else if (garums < minGarums)
//{
//    Console.WriteLine("Nepareiza ievade!");
//}

//else {

//    Console.WriteLine("Viss ok!");
//}