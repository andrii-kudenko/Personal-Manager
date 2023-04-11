using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class ExpensesPage : ContentPage
{
	public ExpensesPage()
	{
		InitializeComponent();
    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        ExpensesListView.ItemsSource = ExpensesRepository.GetEarnings();
    }
}