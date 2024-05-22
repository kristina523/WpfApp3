using System;
using System.Collections.Generic;
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
using WpfApp3;
namespace WpfApp3
{
    public partial class PlayerWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public PlayerWindow()
        {
            InitializeComponent();
            mediaPlayer.Open(new Uri("\"\\\\Mac\\Home\\Downloads\\Anna_Asti_-_Carica_76781122.mp3\""));
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer != null)
            {
                mediaPlayer.Play();
                Console.WriteLine("Играет музыка...");
            }
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer != null)
            {
                mediaPlayer.Pause();
                Console.WriteLine("Музыка на пауэе...");
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer != null)
            {
                mediaPlayer.Stop();
                Console.WriteLine("Стоп песне...");
            }
        }
    }
}

