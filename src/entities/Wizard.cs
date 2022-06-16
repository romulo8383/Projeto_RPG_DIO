using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_RPG_DIO.src.entities
{
    public class Wizard : Hero 
    {
         public Wizard(string Name, int Level, string Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = Herotype;
        }
         public override string Attack()
         {
            return this.Name + " Lançou Magia";
         }
        public  string Attack(int Bonus)
        {
            if(Bonus > 6)
                return this.Name + " Lançou Magia super efetiva com bonus de ataque de " + Bonus;
            else
                return this.Name  + " Lançou Magia fraca sem causar danos ao oponente" + Bonus;
           
        }
    }
    
}