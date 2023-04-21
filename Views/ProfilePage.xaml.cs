//Parth Manchanda
//Student ID - 991619566

using PersonalManager.User;

namespace PersonalManager.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();

            List<string> functions = new List<string>()
            {
                "UserProfile",
                "CardDetails",
                "QRCode",
                "Contact Us",
                "Rating",
                "Offers",
                "Terms",
                "Insights"

            };

            functionsListView.ItemsSource = functions;
            functionsListView.ItemSelected += OnFunctionSelected;
        }

        private async void OnFunctionSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            string functionName = e.SelectedItem.ToString();
            functionsListView.SelectedItem = null;

            switch (functionName)
            {
                case "UserProfile":
                    await Navigation.PushAsync(new Profile());
                    break;
                case "QRCode":
                    await Navigation.PushAsync(new Code());
                    break;
                case "Contact Us":
                    await Navigation.PushAsync(new User.Contact());
                    break;
                case "Rating":
                    await Navigation.PushAsync(new Rating());
                    break;
                case "Terms":
                    await Navigation.PushAsync(new Terms());
                    break;
                case "CardDetails":
                    await Navigation.PushAsync(new CardDetails());
                    break;

            }
        }
    }
}
