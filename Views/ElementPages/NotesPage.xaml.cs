using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class NotesPage : ContentPage
{
	public NotesPage()
	{
		InitializeComponent();
		NotesListView.ItemsSource = NotesRepository.GetNotes();
	}
}