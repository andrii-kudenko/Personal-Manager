using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class ExpensesPage : ContentPage
{
	public ExpensesPage()
	{
		InitializeComponent();
        ExpensesListView.ItemsSource = ExpensesRepository.GetEarnings();
    }
}