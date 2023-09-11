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
        imgDice1.Source = $"dice_face_{RandomDiceFace}.png";
        imgDice2.Source = $"dice_face_{RandomDiceFace}.png";
    }
}