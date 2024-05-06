
using MyticPartyTracker.Models;
using MyticPartyTracker.ViewModels;

namespace MyticPartyTracker.View;

public partial class DiceView : ContentPage
{
    public DiceView()
	{
		InitializeComponent();
        DicePicker.SelectedIndex = 0;
        // QuantityPicker.SelectedIndex = 0;
        BindingContext = new DiceViewModel();

    }
    private void DiceBtn_Clicked(object sender, EventArgs e)
    {
        AllDicesResultString.Text = " ";
        int quantidade = Convert.ToInt32(DicePicker.SelectedItem);

        int lados = Convert.ToInt32(SidesPicker.SelectedItem);
        int total = 0;
        for(int i =0; i<quantidade;i++)
        {
            int resultado = new Dice(lados).Roll();
            total += resultado; // ou total = total + resultado;

            AllDicesResultString.Text = resultado.ToString() + "\n";//label
            ResultString.Text = resultado.ToString(); //Label

        }
      
    }
    private void DicePicker_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }
    
    private void DiceDoisBtn_Clicked(object sender, EventArgs e)
    {
       
    }

    private void resultString_Clicked(object sender, EventArgs e)
    {

    }

    /* private void PicName_SelectedIndexChanged_2(object sender, EventArgs e)
     {

     }*/
}