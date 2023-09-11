using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Songs = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> songs;

        [ObservableProperty]
        string simpleText;

        partial void OnSimpleTextChanged(string oldValue, string newValue)
        {
            Debug.WriteLine("I DID A THING");
        }

        [RelayCommand]
        void AddSong()
        {
            if (string.IsNullOrWhiteSpace(SimpleText))
            {
                return;
            }
            Songs.Add(SimpleText);
        }
    }
}
