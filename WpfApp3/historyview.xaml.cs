using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp3
{
    public partial class historyview : Window
    {
        private ObservableCollection<FileInfo> _listeningHistory;
        private MediaElement _mediaElement;

        public ICommand PlaySelectedSongCommand { get; }

        public ObservableCollection<FileInfo> ListeningHistory
        {
            get { return _listeningHistory; }
            set { _listeningHistory = value; OnPropertyChanged(new DependencyPropertyChangedEventArgs()); }
        }

        public historyview(ObservableCollection<FileInfo> history, MediaElement mediaElement)
        {
            ListeningHistory = history;
            _mediaElement = mediaElement;
            PlaySelectedSongCommand = new RelayCommand(PlaySelectedSong);
        }

        private void PlaySelectedSong(object obj)
        {
            if (obj is FileInfo fileInfo)
            {
                string selectedAudioPath = fileInfo.FullName;
                _mediaElement.Source = new Uri(selectedAudioPath);
                _mediaElement.Play();
            }
        }
    }
}