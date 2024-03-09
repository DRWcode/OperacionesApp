namespace OperacionesApp.Pages;

public partial class Circulo : ContentPage
{
	public Circulo()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (validarCampoRadio())
            {
                double radio = double.Parse(txtRadio.Text);
                double area = Math.PI * Math.Pow(radio, 2);
                txtArea.Text = $"Área del círculo: {area}";
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtRadio.Text = "";
        txtArea.Text = "";
    }

    private bool validarCampoRadio()
    {
        if (string.IsNullOrWhiteSpace(txtRadio.Text))
        {
            DisplayAlert("Advertencia", "Radio del círculo en blanco", "Aceptar");
            return false;
        }
        else
        {
            return true;
        }
    }

}