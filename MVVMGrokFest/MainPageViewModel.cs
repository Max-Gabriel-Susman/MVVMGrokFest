using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;


namespace MVVMGrokFest.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            EraseCommand = new Command(() =>
            {
                TheNote = string.Empty;
            });

            // I think we really need too better grok the big arrow syntax because it's useful in all sorts of ways
            SaveCommand = new Command(() =>
            {
                AllNotes.Add(TheNote);

                System.Diagnostics.Debug.WriteLine("god save the queen");

                TheNote = string.Empty;
            });

            AllNotes = new ObservableCollection<string>();
        }
        public ObservableCollection<string> AllNotes { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        string theNote;

        public string TheNote
        {
            // so I guess big arrow just means return?
            get => theNote;
            set
            {
                theNote = value;

                // what does nameof do?
                var args = new PropertyChangedEventArgs(nameof(TheNote));

                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command SaveCommand { get; }
        public Command EraseCommand { get; }
    }
}
