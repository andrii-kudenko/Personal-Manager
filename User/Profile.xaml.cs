//Parth Manchanda 
//Student ID - 991619566

using static PersonalManager.User.Profile;

namespace PersonalManager.User;

public partial class Profile : ContentPage
{
    private string _phoneNumber;
    public string PhoneNumber
    {
        get { return _phoneNumber; }
       
    }

    public Profile()
	{
        InitializeComponent();
    }

    private void DisplayPicker_SelectedIndexChanged(object sender, EventArgs e)

    {
        var picker = (Picker)sender;
        var selectedItem = (string)picker.SelectedItem;

        switch (selectedItem)
        {
            case "Black":
                BackgroundColor = Colors.Black;
                break;
            case "White":
                BackgroundColor = Colors.White;
                break;
            case "Red":
                BackgroundColor = Colors.Red;
                break;
        }


    }

    void CountryCodePicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
    {
        
    }
}
