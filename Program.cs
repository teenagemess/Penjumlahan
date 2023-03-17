using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Penjumlahan
{
    class Program
    {
        /// <summary>
        /// Program untuk operasi penjumlahan
        /// </summary>
        /// <param name="a">angka pertama dalam operasi penjumlahan yang akan diinputkan oleh user</param>
        /// <param name="b">angka kedua yang akan ditambahkan dengan angka pertama yang telah diinputkan oleh user</param>
        /// <param name="jum">sebuah variable hasil dari penjumlahan variable a + b</param>
        static void Main(string[] args)
        {
            System.Console.WriteLine("Program Untuk Penjumlahan \n");
            int a, b, jum;
            System.Console.Write("Masukan bilangan I  : ");
            a = int.Parse(System.Console.In.ReadLine());
            System.Console.Write("Masukan bilangan II : ");
            b = int.Parse(System.Console.In.ReadLine());
            jum = a + b;
            System.Console.WriteLine("Hasil penjumlahan " + jum);          
            System.Console.ReadLine();
        }
    }
}