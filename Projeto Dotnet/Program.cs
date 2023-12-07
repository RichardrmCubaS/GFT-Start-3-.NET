using System;
using  Projeto_Dotnet.entities;

namespace Projeto_Dotnet
{
    class Program
    { 
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus",23,"Knight");
            Knight hiroito = new Knight("Hiroito",50,"Ninja");
            Wizard wizard = new Wizard("Jennica",23,"White Wizard");
            Wizard witch = new Wizard("Malefica",50,"Black Wizard");
            
            Console.WriteLine();
            Console.WriteLine(arus.Attack());
            Console.WriteLine(hiroito.Attack(5));
            Console.WriteLine(arus.Attack(10));
            Console.WriteLine();
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(witch.Attack(5));
            Console.WriteLine(wizard.Attack(10));
            Console.WriteLine();

        }
    }
}
