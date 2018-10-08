using System;
namespace Day6
{
    public class Piemeri
    {
        
        public void Interfeiss()
        {
            DiviDee();
        }

        private void PirmaisPiemers()
        {
            int mainigais = 4;
            int[] pirmaisMasivs = new int[mainigais];


            for (int i = 0; i < pirmaisMasivs.Length; i++)
            {

                Console.WriteLine("ievadiet masīva vērtības");
                String vertiba = Console.ReadLine();

                int masivaVertiba = Convert.ToInt16(vertiba);

                pirmaisMasivs[i] = masivaVertiba;
            }

            pirmaisMasivs[0] = 1;
            pirmaisMasivs[1] = 2;
            pirmaisMasivs[2] = 3;
            pirmaisMasivs[3] = 4;
            pirmaisMasivs[4] = 3;


            for (int i = 0; i < pirmaisMasivs.Length; i++)
            {
                Console.WriteLine(pirmaisMasivs[i]);
            }

        }
        private void ZvaigznesArray()
        {
            String[] zvaigznes = new string[4] { "*", "**", "***", "****" };
            for (int i = 0; i < zvaigznes.Length; i++)
            {
                Console.WriteLine(zvaigznes[i]);
            }
        }

        private void ZvaigznesDivi()
        {
            String[] zvaigznes = new string[4] { "*", "*", "*", "*" };

            for (int i = 0; i < zvaigznes.Length; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(zvaigznes[j]);
                }
                Console.WriteLine();
            }
        }

        private void DiviDee()
        {
            int[,] otraisMasivs = new int[2,2];

            otraisMasivs[0, 0] = 5;
            otraisMasivs[0, 1] = 1;
            otraisMasivs[1, 0] = 6;
            otraisMasivs[1, 1] = 9;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(otraisMasivs[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}


