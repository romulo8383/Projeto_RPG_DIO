using System;
namespace Projeto_RPG_DIO.src.entities
{

    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 52, "Knight");
            Wizard wizard = new Wizard("Jenica", 48,"White Wizard");
            Ninja weder = new Ninja("weder", 40, "Ninja");
            BlackWizard thron = new BlackWizard("Thron", 35, "Black Wizard");

            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(arus.Attack(2));
            Console.WriteLine(weder.Attack(7));
            Console.WriteLine(thron.Attack(1));
            
        }
    }
}