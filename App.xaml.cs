using PersonalManager.Views;

namespace PersonalManager;

public partial class App : Application
{
	public App()
	{

		MainPage = new NavigationPage (new StarterPage());
	}
}
