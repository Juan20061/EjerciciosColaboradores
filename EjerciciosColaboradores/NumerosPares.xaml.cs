namespace EjerciciosColaboradores;

public partial class NumerosPares : ContentPage
{
    int count = 0;
    public NumerosPares()
	{
		InitializeComponent();
	}

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        count += 2;

        if (count <= 100)
            EntryN.Text = $"N�mero Par {count}";
        else
            EntryN.Text = "L�mite alcanzado";

        SemanticScreenReader.Announce(EntryN.Text);
    }
}