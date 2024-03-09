namespace OperacionesApp.Pages;

public partial class Cuadrado : ContentPage
{
	public Cuadrado()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (validarCampoLado())
            {
                double lado = double.Parse(txtLado.Text);
                double area = lado * lado;
                txtArea.Text = $"Área del cuadrado: {area}";
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtLado.Text = "";
        txtArea.Text = "";
    }

    private bool validarCampoLado()
    {
        if (string.IsNullOrWhiteSpace(txtLado.Text))
        {
            DisplayAlert("Advertencia", "Lado del cuadrado en blanco", "Aceptar");
            return false;
        }
        else
        {
            return true;
        }
    }


}