using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MyticPartyTracker.Models;
using MyticPartyTracker.ViewModels;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Windows.Markup;

namespace MyticPartyTracker.ViewModels
{
   public partial class DiceViewModel : ObservableObject//essa classe é observada// sempre colocar esse ObservableObject//"implementar"
    {
        public DiceViewModel()
        {
            RollCommand = new Command(Roll);
        }
       

        [ObservableProperty]
        public int _numberSides;// numero de lados //se trocar o valor eu quero "observa"// public int numberSides; 
        [ObservableProperty]
        public int _quantity; //=_ para ser um number //contidade
        [ObservableProperty]
        public int _total;//soma

        
        private ObservableCollection<int> rolls = new ObservableCollection<int>();//instancia uma lista nove// para observar ua lisar transfirmamos em um "ObservableCollection"
        private int numberSides;
        private int total;
        private ObservableCollection<int> _rolls; new ObservableCollection<int>();
        public ObservableCollection<int> Rolls {
            get { return _rolls; }// retorna
            set { _rolls = value; }//adiciona
        }

        public ICommand RollCommand { get; }
        public int Total { get; private set; }
        public int Quantity { get; private set; }

        public void Roll()
        {
            Rolls.Clear(); //Limpa a lista

            //intancia um novo dado
            Total = 0;
            Dice dice = new Dice(numberSides);

            for (int i = 0; i < Quantity; i++)
            {
                int roll = dice.Roll();
                Rolls.Add(roll);
                total += roll;
            }
        }
    }
}
