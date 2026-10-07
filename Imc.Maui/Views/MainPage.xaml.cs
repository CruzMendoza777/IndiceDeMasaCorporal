using Imc.Maui.Models;
namespace Imc.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnCalcularButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            decimal peso = decimal.Parse(PesoEntry.Text);
            decimal estatura = decimal.Parse(EstaturaEntry.Text);
            decimal imc = CalculadoraIMC.IndiceDeMasaCorporal(peso, estatura);
            imcLabel.Text = imc.ToString("F4");
            EstadoNutricionalLabel.Text = CalculadoraIMC.EstadoNutricional(imc);

        }
        catch (Exception)
        {
            throw;
        }
        
    }

    private void OnLimpiarButton_Clicked(object sender, EventArgs e)
    {
        PesoEntry.Text = string.Empty;
        EstaturaEntry.Text = string.Empty;
        imcLabel.Text = string.Empty;
        EstadoNutricionalLabel.Text = string.Empty;


    }

}