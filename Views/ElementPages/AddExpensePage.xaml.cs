namespace PersonalManager.Views.ElementPages;

public partial class AddExpensePage : ContentPage
{
	public AddExpensePage()
	{
		InitializeComponent();
	}

    private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(AmountEntry.Text))
        {
            // The Entry control does not contain any text
            PlusLabel.TextColor = Colors.DimGray;

        }
        else
        {
            // The Entry control contains text
            PlusLabel.TextColor = Colors.Red;
        }

    }
}