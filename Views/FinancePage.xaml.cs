using PersonalManager.Models;
namespace PersonalManager.Views;
public partial class FinancePage : ContentPage
{
    //public DateTime(int year, int month, int day, int hour, int minute, int second)
    public FinancePage()
	{
		InitializeComponent();

        //double total = 10;
        //double food = 4;

        //double foodPercentage = 4 % 10;
        //TestLabel.Text = foodPercentage.ToString();

        //double foodP = (4 * 0.1 / 20) * 1000;
        //Test2Label.Text = foodP.ToString() + "%";

    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {

        var percentages = ExpensesRepository.CalculatePercentage();
        Expense1Label.Text = percentages[0].Description;
        Expense2Label.Text = percentages[1].Description;
        Expense3Label.Text = percentages[2].Description;
        Expense4Label.Text = percentages[3].Description;
        Expense5Label.Text = percentages[4].Description;
        Expense6Label.Text = percentages[5].Description;
        Expense7Label.Text = percentages[6].Description;
        Expense8Label.Text = percentages[7].Description;
        Expense9Label.Text = percentages[8].Description;
        Expense10Label.Text = percentages[9].Description;
        Expense11Label.Text = percentages[10].Description;

        //TestLabel.Text = housing[10].Description;
        //Test2Label.Text = housing[9].Description;
    }

}