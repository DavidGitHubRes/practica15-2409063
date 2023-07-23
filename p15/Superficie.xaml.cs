namespace p15;

public partial class Superficie : ContentPage
{
	public Superficie()
	{
		InitializeComponent();
	}

	private void calBtn_Clicked(object sender, EventArgs e)
	{
		try
		{
			double a = Convert.ToDouble(aEn.Text);
			double h = Convert.ToDouble(hEn.Text);

			double sup;

			sup = a * h;

			supEn.Text = sup.ToString();

		}catch(Exception ex)
		{
			DisplayAlert("Error", ex.Message, "Aceptar");
		}
	}

}