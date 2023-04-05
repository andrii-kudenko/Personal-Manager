using PersonalManager.Views.ElementPages;

namespace PersonalManager.Views;

public partial class AddPage : ContentPage
{

	public AddPage()
	{
		InitializeComponent();
	}

    private async void ExpenseButton_Clicked(object sender, EventArgs e)
    {
       await Navigation.PushModalAsync(new AddExpensePage());
    }

    private async void EarningButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddEarningPage());
    }

    private async void NoteButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddNotePage());
    }

    private async void ReminderButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new AddReminderPage());
    }
}