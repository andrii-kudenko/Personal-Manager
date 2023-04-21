using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class ExpensePage : ContentPage
{
	public ExpensePage(Expense expense)
	{
		InitializeComponent();
        AmountLabel.Text = expense.Amount.ToString();
        CategoryLabel.Text = expense.ExpenseCategory.ToString();
        TextLabel.Text = expense.Details.ToString();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();

    }
}