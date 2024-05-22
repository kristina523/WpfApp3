using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp3;

namespace WpfApp3
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

public class MainViewMode : NotificationObject
    {
        public ICommand OpenPlayerCommand { get; private set; }
        public ICommand OpenSettingsCommand { get; private set; }
        public ICommand ExitCommand { get; private set; }

        public MainViewMode()
        {
            OpenPlayerCommand = new RelayCommand(_ => OpenPlayer());
            OpenSettingsCommand = new RelayCommand(_ => OpenSettings());
            ExitCommand = new RelayCommand(_ => ExitApplication());
        }

        private void OpenPlayer() 
        {
            PlayerWindow playerWindow = new PlayerWindow();
            playerWindow.Show();
            Application.Current.MainWindow.Close();
        }

        private void OpenSettings() 
        {
            setting settingsWindow = new setting();
            settingsWindow.Show();
            Application.Current.MainWindow.Close();
        }

        private void ExitApplication()
        {
            Application.Current.Shutdown();
        }
    }
