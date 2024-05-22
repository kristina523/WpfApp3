using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using WpfApp3;

namespace WpfApp3
{
    public partial class PlayerViewModel : INotifyPropertyChanged
    {
        private MediaPlayer mediaPlayer;
        public PlayerViewModel()
        {
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri("путь_к_вашему_аудиофайлу.mp3"));
        }

        public void Play()
        {
            if (mediaPlayer != null)
            {
                mediaPlayer.Play();
                Console.WriteLine("Playing the song...");
            }
        }

        public void Pause()
        {
            if (mediaPlayer != null)
            {
                mediaPlayer.Pause();
                Console.WriteLine("Pausing the song...");
            }
        }

        public void Stop()
        {
            if (mediaPlayer != null)
            {
                mediaPlayer.Stop();
                Console.WriteLine("Stopping the song...");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
public partial class PlayerWindow : Window
{
    private PlayerViewModel viewModel;
    public PlayerWindow()
    {
        InitializeComponent();
        viewModel = new PlayerViewModel();
        DataContext = viewModel;
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private void PlayButton_Click(object sender, RoutedEventArgs e)
    {
        viewModel.Play();
    }

    private void PauseButton_Click(object sender, RoutedEventArgs e)
    {
        viewModel.Pause();
    }

    private void StopButton_Click(object sender, RoutedEventArgs e)
    {
        viewModel.Stop();
    }
}
