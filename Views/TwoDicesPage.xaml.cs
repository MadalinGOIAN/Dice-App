namespace Dice_App.Views;

public partial class TwoDicesPage : ContentPage
{
    private static readonly Random randomNumberGenerator = new Random();

    private int RandomDiceFace { get => randomNumberGenerator.Next(1, 7); }

    public TwoDicesPage()
	{
		InitializeComponent();
	}

    private void ImageButtonReturn_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MainPage();
    }

    private void ButtonRoll_Clicked(object sender, EventArgs e)
    {
        AnimateDiceRoll(imgDice1);
        AnimateDiceRoll(imgDice2);
    }

    private async void AnimateDiceRoll(Image imgDice)
    {
        for (int degrees = 72; degrees <= 360; degrees += 72)
        {
            await Microsoft.Maui.Controls.ViewExtensions.RotateTo(imgDice, degrees);
            imgDice.Source = $"dice_face_{RandomDiceFace}.png";
        }
    }
}