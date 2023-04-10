using System;
using Microsoft.Maui.Controls;

namespace Finance_Manager
{
    public class UserProfile : ContentPage
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Create controls
            var changeNameButton = new Button { Text = "Change name" };
            var changeEmailButton = new Button { Text = "Change your email" };
            var changeMailingAddressButton = new Button { Text = "Change mailing address" };
            var changePhoneNumberButton = new Button { Text = "Change phone number" };
            var changeLocationButton = new Button { Text = "Change your location" };

            var displayPicker = new Picker { Title = "Display" };
            displayPicker.Items.Add("Black");
            displayPicker.Items.Add("White");
            displayPicker.Items.Add("Red");

            // Add event handlers
            changeNameButton.Clicked += ChangeNameButton_Clicked;
            changeEmailButton.Clicked += ChangeEmailButton_Clicked;
            changeMailingAddressButton.Clicked += ChangeMailingAddressButton_Clicked;
            changePhoneNumberButton.Clicked += ChangePhoneNumberButton_Clicked;
            changeLocationButton.Clicked += ChangeLocationButton_Clicked;
            displayPicker.SelectedIndexChanged += DisplayPicker_SelectedIndexChanged;

            // Add controls to the layout
            Content = new StackLayout
            {
                Children =
                {
                    changeNameButton,
                    changeEmailButton,
                    changeMailingAddressButton,
                    changePhoneNumberButton,
                    changeLocationButton,
                    displayPicker
                }
            };
        }

        private void ChangeNameButton_Clicked(object sender, EventArgs e)
        {
            // Handle name change
        }

        private void ChangeEmailButton_Clicked(object sender, EventArgs e)
        {
            // Handle email change
        }

        private void ChangeMailingAddressButton_Clicked(object sender, EventArgs e)
        {
            // Handle mailing address change
        }

        private void ChangePhoneNumberButton_Clicked(object sender, EventArgs e)
        {
            // Handle phone number change
        }

        private void ChangeLocationButton_Clicked(object sender, EventArgs e)
        {
            // Handle location change
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
    }
}