using MediaPlayer.ViewModels;
using Microsoft.Maui.Controls.PlatformConfiguration;
using System.Diagnostics;

namespace MediaPlayer
{
    public partial class MainPage : ContentPage
    {
        bool isPressed = false;

        Color color;
        int r = 50;
        int g = 255;
        int b = 255;
        bool x = false;

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();

            BindingContext = mainViewModel;
            color = Color.FromRgb(r, g, b);

            colorFR.BackgroundColor = color;
        }

        private async void ColorButtonPressed(object sender, EventArgs e)
        {
            isPressed = true;

            await Task.Run(() => {
                while (isPressed)
                {
                    //Debug.WriteLine($"Status is {isPressed}");
                    Thread.Sleep(500);

                    Dispatcher.Dispatch(new Action(() =>
                    {
                        Debug.WriteLine("Dispatching...");
                        if(x)
                        {
                            colorFR.BackgroundColor = Color.FromRgb(255, 0, 0);
                            x = false;
                        }
                        else 
                        {
                            colorFR.BackgroundColor = Color.FromRgb(0, 255, 0);
                            x = true;
                        }
                    }));

                    if(!isPressed)
                    {
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