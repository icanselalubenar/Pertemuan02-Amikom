using System;

namespace CalculatorConsole
{
    class Program
    {
        static int Penambahan(int A, int B)
        {
            return A + B;
        }
        static int Pengurangan(int A, int B)
        {
            return A - B;
        }
        static int Perkalian(int A, int B)
        {
            return A * B;
        }
        static int Pembagian(int A, int B)
        {
            return A / B;
        }

        static void Main(string[] args)
        {
            Console.Title = "Calculator Aplication using C#";

            Console.WriteLine("Pilih menu kalkulator:");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.Write("\nInput nomor menu [1..4]: ");
            int inputMenu = int.Parse(Console.ReadLine());

            int A = 0, B = 0;
            if (inputMenu == 1&&2)
            {
                Console.WriteLine();
                Console.Write("Input Nilai A : ");
                A = int.Parse(Console.ReadLine());

                Console.Write("Input Nilai B : ");
                B = Convert.ToInt32(Console.ReadLine());
            }

            switch (inputMenu)
            {
                case 1:
                    Console.WriteLine();

                    Console.WriteLine("Hasil Penambahan " + A + " + " + B + " = " + Penambahan(A, B));
                    Console.WriteLine("\nPress random Key to exit.");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", A, B, Pengurangan(A, B));
                    break;

                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", A, B, Perkalian(A, B));
                    break;

                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", A, B, Pembagian(A, B));
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia.");
                    break;
            }

            Console.WriteLine("\nPress random Key to exit.");
            Console.ReadKey();
        }
    }
}
