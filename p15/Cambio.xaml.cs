namespace p15;

public partial class Cambio : ContentPage
{
	public Cambio()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{

    }

	private void calBtn_Clicked(object sender, EventArgs e)
	{
		try
		{
			double dinero = Convert.ToDouble(dineroCliente.Text);
			double precio = Convert.ToDouble(precioProduc.Text);

			double cambio;

			cambio = dinero - precio;

			cambioEn.Text = cambio.ToString();

			if (cambio < 0)
			{
				cambioEn.Text = "Usted debe: " + cambio;
			}
		}
		catch (Exception ex)
		{
			DisplayAlert("Error",ex.Message,"Aceptar");
		}


	}
}