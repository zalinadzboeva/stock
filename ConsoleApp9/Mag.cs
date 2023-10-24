using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Magazin
    {
        private string namemag;
        private string vladelec;
        public string nametovar;
        static protected int colvovs = 10;
        public string Articul;
        public Magazin(string articul)
        {
            Articul = articul;
        }
    }
    class Ton:Magazin
    {
        List<string> firms = new List<string> { "vs", "lv", "catris" };
        public string Firma { get; set; }
        public Ton():base("Ton")
        {

        }
        public Ton( string firma):base("Ton")
        {
            Firma = firma;
        }
        public void Nalichie()
        {
            foreach(string s in firms)
            {
                if(s==Firma)
                {
                    Console.WriteLine("есть в асортименте");
                }
                else
                {
                    Console.WriteLine("нет товара этой фирмы");
                }
            }
        }
        public void Pocupka(string what , int count)
        {

        }
    }
}
