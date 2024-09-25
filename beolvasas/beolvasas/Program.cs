using beolvasas;
using System;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            StreamReader sr = new StreamReader("people.csv");
            string sor;
            string kerNev;
            string vezNev, ID1, ID2;
            int eletKor;

            int legfiatalabb = 100, atlagKor = 0, seged = 0;
            while ((sor = sr.ReadLine()) != null)
            {
                sor = sr.ReadLine();
                list.Add(sor);
                kerNev = sor.Split(";")[0];
                vezNev = sor.Split(";")[1];
                ID1 = sor.Split(";")[2].Split('-')[0];
                ID2 = sor.Split(";")[2].Split('-')[2];
                eletKor = int.Parse(sor.Split(';')[2].Split('-')[1]);
                atlagKor += eletKor;
                seged++;
            }
            Console.WriteLine(atlagKor / seged);
            Console.WriteLine(atlagKor);
            Console.WriteLine(seged);
            int eletkor = 0;
            foreach (var item in list)
            {

            }
            //Console.WriteLine(legfiatalabb);
        }
    }
}