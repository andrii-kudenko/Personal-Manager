namespace PersonalManager.Views;

public partial class FinancePage : ContentPage
{
    //public DateTime(int year, int month, int day, int hour, int minute, int second)
    public FinancePage()
	{
		InitializeComponent();
		var date = new DateTime(2023, 04, 19, 17, 30, 00);
		//TestLabel.Text = date.TimeOfDay.ToString();
        var fullTime = date.TimeOfDay.ToString();
        var newTime = fullTime.Substring(0, fullTime.Length - 3);
        TestLabel.Text = newTime;


    }
}