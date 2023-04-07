using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using PersonalManager.Models;

namespace PersonalManager.Views.ElementPages;

public partial class RemindersPage : ContentPage
{
    public RemindersPage()
    {
        InitializeComponent();
        RemindersListView.ItemsSource = RemindersRepository.GetReminders();
    }

    //private void AnimatedBorder_Loaded(object sender, EventArgs e)
    //{
    //    var stops = new GradientStopCollection
    //    {
    //        new GradientStop(Colors.Red, 0),
    //        new GradientStop(Colors.Blue, 0.5f),
    //        new GradientStop(Colors.Yellow, 1)
    //    };

    //    var brush = new LinearGradientBrush(stops, new Point(0, 0), new Point(1, 1));

    //    var animation = new Animation(callback =>
    //    {
    //        brush.StartPoint = new Point(callback, 0);
    //        brush.EndPoint = new Point(1 + callback, 1);
    //    });
    //    AnimatedBorder.Stroke = brush;


    //    animation.Commit(this, "AnimatedBorder_Loaded", length: 3000, repeat: () => true);
    //}
}
