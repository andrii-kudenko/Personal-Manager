namespace PersonalManager.Views.ElementPages;

public partial class AddEarningPage : ContentPage
{
	public AddEarningPage()
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
            PlusLabel.TextColor = Colors.Green;
        }
    }
}