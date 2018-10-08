using System;
namespace day5
{
    public class Daudzsturi
    {

        public int maluSkaits = 0;
        public int maluGarums = 0;


        public void Interfeiss()
        {
            
            String choise = "";

            Console.WriteLine("1. Pārbaudīt malu skaitu");
            Console.WriteLine("2. Pārbaudīt malu garumu");
            Console.WriteLine("3. Pārbaudīt malu garumu, skaitu un kas par figūru");
            Console.WriteLine("4. Noskaidrot objekta perimetru");
            Console.WriteLine("5. iziet");
            choise = Console.ReadLine();

            switch (choise)
            {
                case "1":
                    MaluSkaits();
                    Interfeiss();
                    break;

                case "2":
                    MaluGarums();
                    Interfeiss();
                    break;

                case "3":
                    MaluSkaits();
                    MaluGarums();
                    Interfeiss();
                    break;

                case "4":
                    Perimetrs();
                    Interfeiss();
                    break;

                case "5":

                    break;

                default:
                    Console.WriteLine("Nepareiza ievade");
                    break;
            }
        }


        private void MaluSkaits()
        {
            String malas = "";
            Console.WriteLine("Lūdzu ievadiet malu skaitu!");
            malas = Console.ReadLine();


            switch (malas)
            {
                case "0":
                    Console.WriteLine("Nepareiza ievade!!");
                    break;

                case "1":
                    Console.WriteLine("objeks nevar sastāvēt tikai no 1 malas!!");
                    break;

                case "2":
                    Console.WriteLine("objeks nevar sastāvēt tikai no 2 malām!!");
                    break;

                case "3":
                    Console.WriteLine("trīsstūris");
                    break;

                case "4":
                    Console.WriteLine("četrstūris");
                    break;

                case "5":
                    Console.WriteLine("piecstūris");
                    break;
                default:
                    Console.WriteLine("Jūsu ievadītajam objektam ir pārak daudz malu!!");
                    break;
            }
            maluSkaits = Convert.ToInt32(malas);
        }


        private int MaluGarumsUzglaba()
        {
            Console.WriteLine("Ievadiet malu garumu!");
            String maluGarums = Console.ReadLine();

            int jaunaisSkaitlis = Convert.ToInt16(maluGarums);
            this.maluGarums = jaunaisSkaitlis;
            return jaunaisSkaitlis;
        }

        private void MaluGarums()
        {

            Console.WriteLine("Jūsu malu garums ir " + MaluGarumsUzglaba() + " vienības");
            Console.WriteLine("Nospiediet 1 ja vēlaties pārbaudīt objekta perimetu, jebko citu --> izvēlne");

            String izvele = "";
            izvele = Console.ReadLine();

            if (izvele == "1")
            {
                Perimetrs();
            }
        }

        private int MalasUnGarumiUnDaudzumi()
        {
            Console.WriteLine("Lūdzu ievadiet malu daudzumu!");
            String maluDaudzums = Console.ReadLine();
            int jaunaisSkaitlis2 = Convert.ToInt16(maluDaudzums);

            return jaunaisSkaitlis2;
        }

        private void Perimetrs()
        {
            int maluSkaits = 0;
            int maluGarums = 0;

            if (this.maluGarums == 0 && this.maluSkaits == 0)
                Console.WriteLine("Lai aprēķinātu objekta perimetru, lūdzu ievadiet malu daudzumu un garumu");
            else if (this.maluGarums == 0)
                Console.WriteLine("Lai aprēķinātu objekta perimetru, lūdzu ievadiet malu garumu");
            else if (this.maluSkaits == 0)
                Console.WriteLine("Lai aprēķinātu objekta perimetru, lūdzu ievadiet malu daudzumu");


            if (this.maluSkaits > 0)
            {
                Console.WriteLine($"Ieprieks ievadits malu skaits {this.maluSkaits}");
                maluSkaits = this.maluSkaits;
            }
            else
            {
                maluSkaits = MalasUnGarumiUnDaudzumi();
            }
            if (this.maluGarums > 0)
            {
                Console.WriteLine($"Ieprieks ievadits malu garums {this.maluGarums}");
                maluGarums = this.maluGarums;
            }
            else
            {
                maluGarums = MaluGarumsUzglaba();
            }


            int perimetrs = maluGarums * maluSkaits;

            Console.WriteLine("Jūsu objekta perimetrs ir: " + perimetrs + " vienības");
        }
    }
}