namespace Dice_App;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();

        InitializeButton1Dice();
        InitializeButton2Dices();
    }

    private void InitializeButton1Dice()
    {
        btn1Dice.WidthRequest = DeviceDisplay.MainDisplayInfo.Width * 0.2;
        btn1Dice.HeightRequest = DeviceDisplay.MainDisplayInfo.Height * 0.04;
    }

    private void InitializeButton2Dices() 
    {
        btn2Dices.WidthRequest = DeviceDisplay.MainDisplayInfo.Width * 0.2;
        btn2Dices.HeightRequest = DeviceDisplay.MainDisplayInfo.Height * 0.04;
    }

    private void Btn1Dice_Clicked(object sender, EventArgs e)
    {
        //Application.Current.MainPage = new OneDicePage();
    }

    private void Btn2Dices_Clicked(object sender, EventArgs e)
    {
        //Application.Current.MainPage = new TwoDicesPage();
    }
}

