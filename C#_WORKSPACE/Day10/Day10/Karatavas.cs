using System;
namespace Day10
{
    public class Karatavas
    {
        char[] jaunsMasivs = new char[13];

        char[] jaunsmasivs2 = new char[13];


        public void Izvelne()
        {
            Console.WriteLine("Lūdzu nospiediet 1 lai spēlētu, 0 - lai izietu");

            String choise = Console.ReadLine();

            switch (choise)
            {
                case "0":
                    break;

                case "1":
                    //CharMasivsProgrammesana();
                    CharMasivs();
                    break;
                default:
                    Console.WriteLine("Nepareiza ievade");
                    break;
            }

        }


        public void CharMasivs()
        {
            Console.WriteLine("Vārds sastāv no 13 burtiem, jums ir iespejas kļūdīties 5x!");

            String pareizaisVards = "programmesana";
            //char[] jaunsmasivs2 = new char[12];

            for (int i = 0; i < pareizaisVards.Length; i++)
            {

                //Console.Write(jaunsmasivs2[i] + " ");
            }
            jaunsmasivs2[0] = 'p';
            jaunsmasivs2[1] = 'r';
            jaunsmasivs2[2] = 'o';
            jaunsmasivs2[3] = 'g';
            jaunsmasivs2[4] = 'r';
            jaunsmasivs2[5] = 'a';
            jaunsmasivs2[6] = 'm';
            jaunsmasivs2[7] = 'm';
            jaunsmasivs2[8] = 'e';
            jaunsmasivs2[9] = 's';
            jaunsmasivs2[10] = 'a';
            jaunsmasivs2[11] = 'n';
            jaunsmasivs2[12] = 'a';



            //char[] jaunsMasivs = new char[12];

            String ievade = Console.ReadLine();

            char masivaVertiba = Convert.ToChar(ievade);




                for (int i = 0; i <= 12; i++)
                {
                    jaunsMasivs[i] = '-';
                    //Console.Write(jaunsMasivs[i] + " ");

                    if (masivaVertiba == jaunsmasivs2[0])
                    {
                        jaunsMasivs[0] = jaunsmasivs2[0];
                    }
                    else if (masivaVertiba == jaunsmasivs2[1])
                    {
                        jaunsMasivs[1] = jaunsmasivs2[1];
                        jaunsMasivs[4] = jaunsmasivs2[4];
                    }
                    else if (masivaVertiba == jaunsmasivs2[2])
                    {
                        jaunsMasivs[2] = jaunsmasivs2[2];
                    }
                    else if (masivaVertiba == jaunsmasivs2[3])
                    {
                        jaunsMasivs[3] = jaunsmasivs2[3];
                    }

                    else if (masivaVertiba == jaunsmasivs2[5])
                    {
                        jaunsMasivs[5] = jaunsmasivs2[5];
                        jaunsMasivs[10] = jaunsmasivs2[10];
                        jaunsMasivs[12] = jaunsmasivs2[12];
                    }
                    else if (masivaVertiba == jaunsmasivs2[6])
                    {
                        jaunsMasivs[6] = jaunsmasivs2[6];
                        jaunsMasivs[7] = jaunsmasivs2[7];
                    }
                    else if (masivaVertiba == jaunsmasivs2[8])
                    {
                        jaunsMasivs[8] = jaunsmasivs2[8];
                    }
                    else if (masivaVertiba == jaunsmasivs2[9])
                    {
                        jaunsMasivs[9] = jaunsmasivs2[9];
                    }
                    else if (masivaVertiba == jaunsmasivs2[11])
                    {
                        jaunsMasivs[11] = jaunsmasivs2[11];
                    }
                }
                Console.WriteLine(jaunsMasivs);
            ievade = Console.ReadLine();
            Console.WriteLine(jaunsMasivs ); 
            // JĀTURPINA!!!


            //Console.WriteLine(jaunsMasivs);

          
            //String ievade = Console.ReadLine();
        }

        public void CharMasivsProgrammesana()
        {
            

            //for (int i = 0; i < pareizaisVards.Length; i++)
            //{
                
            //    //Console.Write(jaunsmasivs2[i] + " ");
            //}


        }


    }
}
