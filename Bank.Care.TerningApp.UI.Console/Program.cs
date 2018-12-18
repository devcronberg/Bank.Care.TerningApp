using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Care.TerningApp.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kerne.Terning t = new Kerne.Terning();
            ////System.Console.WriteLine(t);

            //List<Kerne.Terning> bæger = new List<Kerne.Terning>();
            //for (int i = 0; i < 5; i++)
            //{
            //    bæger.Add(new Kerne.Terning());
            //}
            //bæger.Sort();

            //foreach (var item in bæger)
            //{
            //    System.Console.WriteLine(item);
            //}

            System.Console.WriteLine("-----");

            for (int i = 0; i < 10; i++)
            {
                Kerne.LudoTerning l = new Kerne.LudoTerning();
                System.Console.WriteLine(l);

            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
