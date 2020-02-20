using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeros.Models
{
    public enum Universe
    {
    Dc=10,
    Marvel=11
    }
    public enum MoralCode
    {
    Nokill=-10,
    NoWeapon=-8
    }
    public class SuperHero
    {
        public string Name { get; set; }
        public Universe Universe { get; set; }
        public MoralCode MoralCode { get; set; }
        public List<Power> Powers { get; set; }
        public SuperHero()
        {
            Powers = new List<Power>();
        }
        public SuperHero(string name, Universe universe, MoralCode moralcode, List<Power> power)
        {
            Name = name;
            Universe = universe;
            MoralCode = moralcode;
            Powers =    power;
        }
        public void Display() 
        {
            Console.Write("\n"+Name+" "+Universe," \n"+ MoralCode+"\n");
        }
        public void superpower() 
        {
            int i = 0;
            foreach (var power in Powers)
            {
                Console.WriteLine(power.ExtraOrdinaryAbilities[i]+"\n");
                i++;
            }
        }
    }
}
