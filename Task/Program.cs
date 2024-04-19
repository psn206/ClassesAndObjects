using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Task;


namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите градусы: ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Corner corner = new Corner();
            corner.Gradus = gradus;
            corner.Min = min;
            corner.Sec = sec;

            Console.WriteLine($"{corner.Gradus} {corner.Min} {corner.Sec} ");
            Console.WriteLine($"Рыдианы = {corner.GetRadians()}");
            Console.ReadKey();
        }
    }


}
