using Microsoft.Maui.Controls;

namespace Dice_App.Views;

public partial class OneDicePage : ContentPage
{
	public OneDicePage()
	{
		InitializeComponent();
	}

    private void ImageButtonReturn_Clicked(object sender, EventArgs e)
    {
		Application.Current.MainPage = new MainPage();
    }

    private void BtnRoll_Clicked(object sender, EventArgs e)
    {
        int randomDiceFace = new Random().Next(1, 7);
        imgDice.Source = $"dice_face_{randomDiceFace}.png";
    }
}