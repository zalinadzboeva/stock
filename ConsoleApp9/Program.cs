using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] at = new string[] { "Ton",""," "};
            Magazin a = new Magazin("Ton");
            if (a.Articul==at[0])
            {
                Ton ton = new Ton();
                ton.Firma = Console.ReadLine();
                ton.Nalichie();
            }
        }
    }
}
