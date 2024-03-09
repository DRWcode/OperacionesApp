namespace OperacionesApp.Pages;

public partial class Rectangulo : ContentPage
{
	public Rectangulo()
	{
		InitializeComponent();
	}
    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (validarCampos())
            {
                double baseRectangulo = double.Parse(txtBase.Text);
                double alturaRectangulo = double.Parse(txtAltura.Text);
                double area = baseRectangulo * alturaRectangulo;
                txtArea.Text = $"Área del rectángulo: {area}";
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Error", ex.Message, "Aceptar");
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtBase.Text = "";
        txtAltura.Text = "";
        txtArea.Text = "";
    }

    private bool validarCampos()
    {
        if (string.IsNullOrWhiteSpace(txtBase.Text))
        {
            DisplayAlert("Advertencia", "Base del rectángulo en blanco", "Aceptar");
            return false;
        }
        else if (string.IsNullOrWhiteSpace(txtAltura.Text))
        {
            DisplayAlert("Advertencia", "Altura del rectángulo en blanco", "Aceptar");
            return false;
        }
        else
        {
            return true;
        }
    }

}