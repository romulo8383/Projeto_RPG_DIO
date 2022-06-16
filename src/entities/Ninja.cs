using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_RPG_DIO.src.entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
        }
         public override string Attack()
         {
            return this.Name + "Atirou flexas";
         }
        public  string Attack(int Bonus)
        {
            if(Bonus > 6)
                return this.Name + " Atirou flexa na cabeça do oponente causando muitos danos " + Bonus;
            else
                return this.Name + " Atirou flexa sem causar muitos danos ao oponente" + Bonus;
           
        }
    }
    
}