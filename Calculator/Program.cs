using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator__FIX_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SELAMAT DATANG\n");
            Console.WriteLine("Masukkan nilai pertama");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Masukkan nilai kedua");
            int b = int.Parse(Console.ReadLine()); Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("-------PILIHAN MENU-------");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("Silahkan pilih menunya  : ");
            int pilih = int.Parse(System.Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            switch (pilih)
            {
                case 1:
                    Console.WriteLine("-----PENJUMLAHAN-----");
                    Console.WriteLine("Nilai pertama    : " + a);
                    Console.WriteLine("Nilai kedua      : " + b);
                    Console.WriteLine("Hasil penambahan " + a + " + " + b + " : " + Penambahan(a, b));
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("-----PENGURANGAN-----");
                    Console.WriteLine("Masukkan nilai pertama : ");
                    Console.WriteLine("Masukkan nilai kedua : ");
                    Console.WriteLine("Hasil pengurangan " + a + " - " + b + " = " + Pengurangan(a, b));
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("-----PERKALIAN-----");
                    Console.WriteLine("Nilai pertama    : " + a);
                    Console.WriteLine("Nilai kedua      : " + b);
                    Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + Perkalian(a, b));
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("-----PEMBAGIAN-----");
                    Console.WriteLine("Nilai pertama    : " + a);
                    Console.WriteLine("Nilai kedua      : " + b);
                    Console.WriteLine("Hasil pembagian " + a + " : " + b + " = " + Pembagian(a, b));
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Maaf, pilihan menu yang anda masukkan tidak ada.");
                    Console.WriteLine("Silahkan pilih kembali...");
                    break;
            }
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}