using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class EarningsPage : ContentPage
{
	public EarningsPage()
	{
		InitializeComponent();
		EarningsListView.ItemsSource = EarningsRepository.GetEarnings();
	}
}