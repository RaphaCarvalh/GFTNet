using System;
using Projetos.src.Entities;

namespace projetos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("ad", 1, "rcd");
         

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            
        }
    }
}