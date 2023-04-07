using PersonalManager.Views.ElementPages;

namespace PersonalManager.Views;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

    private void EarningsButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new EarningsPage());
    }

    private void ExpensesButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ExpensesPage()); 
    }

    private void RemindersButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RemindersPage());
    }

    private void NotesButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NotesPage());
    }
}