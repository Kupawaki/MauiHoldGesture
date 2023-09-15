using MediaPlayer.ViewModels;
using System.Diagnostics;

namespace MediaPlayer
{
    public partial class MainPage : ContentPage
    {
        bool isPressed = false;

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();

            BindingContext = mainViewModel;
        }

        private async void ColorButtonPressed(object sender, EventArgs e)
        {
            isPressed = true;

            await Task.Run(() => {
                while (isPressed)
                {
                    Debug.WriteLine($"Status is {isPressed}");
                    Thread.Sleep(500);
                    if(!isPressed)
                    {
                        Debug.WriteLine("Thread should be finished");
                        return;
                    }
                }
            });
        }

        private void ColorButtonReleased(object sender, EventArgs e)
        {
            Debug.WriteLine("Button Released");
            isPressed = false;
        }
    }
}