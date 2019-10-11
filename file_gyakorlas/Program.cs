using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            string filenev="";
            try
            {
                double[] szamok = new double[10];
                for (int i = 0; i < 10; i++)
                {
                    string beir;
                    
                    do
                    {
                        Console.WriteLine("Adjon meg 10 számot: ");
                        beir = Console.ReadLine();
                        if (double.TryParse(beir, out szamok[i])) 
                        {
                            Console.WriteLine("Ez nem egy szám");
                        }
                    } while (!double.TryParse(beir,out szamok[i]));
                    szamok[i] = double.Parse(beir);
                }
                Console.WriteLine("Add meg a fájl nevét: ");
                filenev = Console.ReadLine();
                }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                
            }
            using (var sw = new StreamWriter(filenev + ".txt"))
            {

            }
            
        }
    }
}
