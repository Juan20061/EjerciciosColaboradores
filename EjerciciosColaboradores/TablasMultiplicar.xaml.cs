namespace EjerciciosColaboradores;

public partial class TablasMultiplicar : ContentPage
{
	public TablasMultiplicar()
	{
		InitializeComponent();

        List<MultiplicationItem> multiplicationItems = GenerateMultiplicationTables();

        MultiplicationListView.ItemsSource = multiplicationItems;
    }

    private List<MultiplicationItem> GenerateMultiplicationTables()
    {
        List<MultiplicationItem> items = new List<MultiplicationItem>();

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                int result = i * j;
                items.Add(new MultiplicationItem($"{i} x {j} =", result));
            }
        }

        return items;
    }

    public class MultiplicationItem
    {
        public string MultiplicationExpression { get; set; }
        public int Result { get; set; }

        public MultiplicationItem(string expression, int result)
        {
            MultiplicationExpression = expression;
            Result = result;
        }
    }
}