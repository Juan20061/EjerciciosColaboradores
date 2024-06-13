namespace EjerciciosColaboradores;

public partial class Sueldo : ContentPage
{
	public Sueldo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (int.TryParse(HorasTrabajadasEntry.Text, out int horasTrabajadas) &&
           double.TryParse(PagoPorHoraEntry.Text, out double pagoPorHora))
        {
            double sueldoSemana = horasTrabajadas * pagoPorHora * 7;

            SueldoLabel.Text = $"El sueldo semanal es: {sueldoSemana.ToString("C")}";
        }
        else
        {
            SueldoLabel.Text = "Por favor, ingresa valores numéricos válidos.";
        }
    }
}