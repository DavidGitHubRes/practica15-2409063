namespace p15;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void CambioBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Cambio());
	}

	private void SupBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Superficie());
	}

	private void DinoBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Dinosaurio());
	}

    private void GasBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Gasolineria());
    }
}

