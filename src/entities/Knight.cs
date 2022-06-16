using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_RPG_DIO.src.entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
        }
         public override string Attack()
         {
            return this.Name + "Atacou com sua espada";
         }
        public  string Attack(int Bonus)
        {
            if(Bonus > 6)
                return this.Name + " Atacou com sua espada e causou muitos danos ao oponente " + Bonus;
            else
                return this.Name + " Atacou com sua espada causando poucos danos" + Bonus;
           
        }
    }
}