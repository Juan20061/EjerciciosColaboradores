namespace EjerciciosColaboradores;

public partial class Langosta : ContentPage
{
	public Langosta()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(EntryP.Text))
        {
            if (double.TryParse(EntryP.Text, out double CantP))
            {
                double CalcularT;
                CantP = Convert.ToDouble(EntryP.Text);


                if (CantP < 200)
                {
                    CalcularT = CantP * 95;
                    EntryT.Text = CalcularT.ToString();
                }
                else if (CantP <= 300)
                {
                    CalcularT = CantP * 85;
                    EntryT.Text = CalcularT.ToString();

                    if (CantP >= 200)
                    {
                        CalcularT = CantP * 85;
                        EntryT.Text = CalcularT.ToString();
                    }
                }
                else if (CantP > 300)
                {
                    CalcularT = CantP * 75;
                    EntryT.Text = CalcularT.ToString();
                }
            }
            else
            {
                DisplayAlert("Error", "Introduce números válidos", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Llena todos los campos de lo que se le solicita", "OK");
        }
    }
}