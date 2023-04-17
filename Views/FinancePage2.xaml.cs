namespace PersonalManager.Views;
using PersonalManager.Models;
public partial class FinancePage2 : ContentPage
{
	public FinancePage2()
	{
		InitializeComponent();
        Income1Label.Text = "Name";
	}

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        var percentages = ExpensesRepository.CalculatePercentage();
        Income2Label.Text = percentages[0].Description;
        Income3Label.Text = percentages[1].Description;

    }
}