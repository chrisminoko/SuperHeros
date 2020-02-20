using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeros.Models
{
    public class Power
    {
        public int ID { get; set; }
        public string MainPowername { get; set; }
        public int PowerPoints { get; set; }
        public List<string> ExtraOrdinaryAbilities { get; set; }
        public int BonusPoint { get; set; }
        public Power()
        {
        }
        public Power(int id,string mainpowername,int powerpoints,List<string> extraordinaryablities,int bonuspoint)
        {
            ID = id;
            MainPowername = mainpowername;
            PowerPoints=powerpoints;
            ExtraOrdinaryAbilities = extraordinaryablities;
            BonusPoint = BonusPoint;
        }
    }
}
