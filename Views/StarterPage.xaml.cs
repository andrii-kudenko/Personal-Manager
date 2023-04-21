using PersonalManager.Views;


namespace PersonalManager.Views;

public partial class StarterPage : ContentPage
{

    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public ImageSource ProfilePicture { get; set; }

    public StarterPage()
    {
        InitializeComponent();
        Name = "John Doe";
        Email = "johndoe@example.com";
        Phone = "+1 555-555-5555";
        Username = "";
        Password = "";
        ProfilePicture = ImageSource.FromFile("profile_picture.jpg");


        NavigationPage.SetHasNavigationBar(this, false);
    }

    private async void Button_Clicked(System.Object sender, System.EventArgs e)
    {

        if (string.IsNullOrEmpty(NameEntry.Text))
        {
            await DisplayAlert("Error", "Name field is required", "OK");
            return;
        }

        if (string.IsNullOrEmpty(PhoneEntry.Text))
        {
            await DisplayAlert("Error", "Phone Number field is required", "OK");
            return;
        }

        if (string.IsNullOrEmpty(PasswordEntry.Text))
        {
            await DisplayAlert("Error", "Password field is required", "OK");
            return;
        }
        if (string.IsNullOrEmpty(UsernameEntry.Text))
        {
            await DisplayAlert("Error", "Username field is required", "OK");
            return;
        }

        await DisplayAlert("Message Title\n\n", "Why did the tomato turn red?\n\n Because it saw the salad dressing!", "Lol");
        await Task.Delay(1000);
        await DisplayAlert("Welcome :)", "Your login was successful\n\n How are you doing today?", "Good");

        await Navigation.PushAsync(new AppShell());

    }
}
