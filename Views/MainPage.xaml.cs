namespace Dice_App.Views; 

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
    }

    private void Btn1Dice_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new OneDicePage();
    }

    private void Btn2Dices_Clicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new TwoDicesPage();
    }
}

