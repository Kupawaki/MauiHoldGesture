using MediaPlayer.ViewModels;
using System.Diagnostics;

namespace MediaPlayer
{
    public partial class MainPage : ContentPage
    {
        int x = 1;
        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();

            BindingContext = mainViewModel;
        }

        private async void ColorButtonPressed(object sender, EventArgs e)
        {
            await Task.Run(() => {
                for(int count = 0; count <= 1000; count++)
                {
                    Thread.Sleep(1000);
                    Debug.WriteLine($"Finished {count} loops");
                }
            });
        }

        private void ColorButtonReleased(object sender, EventArgs e)
        {
           
        }
    }
}