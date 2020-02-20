using SuperHeros.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeros.Logic
{
   public class PowerLogic
    {
        public List<SuperHero> SuperHeros { get; set; }
        public PowerLogic()
        {
            
            SuperHeros = new List<SuperHero>()
            {
                new SuperHero("Superman",Universe.Dc,MoralCode.Nokill,
                new List<Power>{ new Power(1,"Fly",50,
                new List<string> 
                {"Super Strength","Imortal" },50)}),
                
                new SuperHero("Batman",Universe.Dc,MoralCode.Nokill,
                new List<Power>{ new Power(1,"strength",50,
                new List<string>
                {"Super Strength","Imortal" },50)})
            };
        }

        public void DisplayHeros() 
        {
            foreach (var item in SuperHeros)
            {
                item.superpower();
                item.Display();
            }
        }
    }
}
