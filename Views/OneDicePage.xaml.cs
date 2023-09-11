using Java.Time.Temporal;
using Microsoft.Maui.Controls;

namespace Dice_App.Views;

public partial class OneDicePage : ContentPage
{
    private static readonly Random randomNumberGenerator = new Random();
    
    private int RandomDiceFace { get => randomNumberGenerator.Next(1, 7); }

    public OneDicePage()
	{
		InitializeComponent();
	}

    private void ImageButtonReturn_Clicked(object sender, EventArgs e)
    {
		Application.Current.MainPage = new MainPage();
    }

    private void ButtonRoll_Clicked(object sender, EventArgs e)
    {
        AnimateDiceRoll();
    }

    private async void AnimateDiceRoll()
    {
        for (int degrees = 72; degrees <= 360; degrees += 72)
        {
            await Microsoft.Maui.Controls.ViewExtensions.RotateTo(imgDice, degrees);
            imgDice.Source = $"dice_face_{RandomDiceFace}.png";
        }
    }
}