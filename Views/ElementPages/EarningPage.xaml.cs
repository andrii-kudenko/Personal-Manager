using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class EarningPage : ContentPage
{
	public EarningPage(Earning earning)
	{
		InitializeComponent();
		AmountLabel.Text = earning.Amount.ToString();
		CategoryLabel.Text = earning.EarningCategory.ToString();
		TextLabel.Text = earning.Details.ToString();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();

    }
}