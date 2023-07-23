namespace p15;

public partial class Gasolineria : ContentPage
{
	public Gasolineria()
	{
		InitializeComponent();
	}

    private void calBtn_Clicked(object sender, EventArgs e)
    {
		double galones = Convert.ToDouble(cantGal.Text);
		double litros = galones * 4.546092;

		totalPagar.Text = (litros * 1.00).ToString();

    }
}