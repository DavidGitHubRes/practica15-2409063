namespace p15;

public partial class Dinosaurio : ContentPage
{
	public Dinosaurio()
	{
		InitializeComponent();
	}

	private void calBtn_Clicked(object sender, EventArgs e)
	{
		try
		{
			double peso = Convert.ToDouble(pesoEn.Text);
			double altura = Convert.ToDouble(alturaEn.Text);

			resultLbl.Text = "ALTURA(CM):	" + (altura * 100) + "			" + "PESO(LB):   " + (peso * 2.2);

		}
		catch (Exception ex)
		{
			DisplayAlert("Error", ex.Message, "Aceptar");
		}
	}
}