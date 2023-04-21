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

        var expensesPercentages = ExpensesRepository.CalculatePercentage();
        Expense1Label.Text = expensesPercentages[0].Description;
        Expense2Label.Text = expensesPercentages[1].Description;
        Expense3Label.Text = expensesPercentages[2].Description;
        Expense4Label.Text = expensesPercentages[3].Description;
        Expense5Label.Text = expensesPercentages[4].Description;
        Expense6Label.Text = expensesPercentages[5].Description;
        Expense7Label.Text = expensesPercentages[6].Description;
        Expense8Label.Text = expensesPercentages[7].Description;
        Expense9Label.Text = expensesPercentages[8].Description;
        Expense10Label.Text = expensesPercentages[9].Description;
        Expense11Label.Text = expensesPercentages[10].Description;

        var incomePercentages = EarningsRepository.CalculatePercentage();
        Income1Label.Text = incomePercentages[0].Description;
        Income2Label.Text = incomePercentages[1].Description;
        Income3Label.Text = incomePercentages[2].Description;
        Income4Label.Text = incomePercentages[3].Description;
        Income5Label.Text = incomePercentages[4].Description;
        Income6Label.Text = incomePercentages[5].Description;


        //TestLabel.Text = housing[10].Description;
        //Test2Label.Text = housing[9].Description;
    }

}