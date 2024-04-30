using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MyticPartyTracker.Models;
using MyticPartyTracker.ViewModels;

namespace MyticPartyTracker.ViewModels
{
   public class DiceViewModel : ObservableObject//essa classe é observada// sempre colocar esse ObservableObject//"implementar"
    {
        public DiceViewModel() { 
        
        }

        [ObservableProperty]
        public int numberSides;// numero de lados //se trocar o valor eu quero "observa"

        // public int numberSides; 
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
