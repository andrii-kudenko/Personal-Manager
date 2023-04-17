using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class NotesPage : ContentPage
{
	public NotesPage()
	{
		InitializeComponent();
	}

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        NotesListView.ItemsSource = NotesRepository.GetNotes();

    }
}