using PersonalManager.Views.ElementPages;

namespace PersonalManager.Views;

public partial class AddPage : ContentPage
{

	public AddPage()
	{
		InitializeComponent();
	}

    private void ExpenseButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new AddExpensePage());
    }

    private void EarningButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new AddEarningPage());
    }

    private void NoteButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new AddNotePage());
    }

    private void ReminderButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new AddReminderPage());
    }
}