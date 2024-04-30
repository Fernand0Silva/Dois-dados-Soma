using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyticPartyTracker.Models;
using MyticPartyTracker.ViewModels;

namespace MyticPartyTracker.ViewModels
{
   public class DiceViewModel
    {
        public DiceViewModel() { 
        
        }

        public int numberSides; // numero de lados
        public int quantity;//contidade
        public int total;//soma

        public void Roll()
        {
            //intancia um novo dado
            total = 0;
            Dice dice = new Dice(numberSides);

            for (int i = 0; i < quantity; i++)
            {
                int roll = dice.Roll();
                total += roll;
            }
        }
    }
}
