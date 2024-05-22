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

namespace WpfApp3
{
    internal class SettingsViewMode
    {
        private readonly Window _currentWindow;

        public ICommand ToggleDarkModeCommand { get; private set; }
        public ICommand GoBackCommand { get; private set; }

        public SettingsViewMode(Window currentWindow)
        {
            ToggleDarkModeCommand = new RelayCommand(ToggleDarkMode);
            _currentWindow = currentWindow;
            GoBackCommand = new RelayCommand(_ => GoBack());
        }

        private void ToggleDarkMode(object parameter) 
        {
            MessageBox.Show("В разработке!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning); 
        }

        private void GoBack()
        {
            MainWindow mainWindow = new MainWindow();

            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
            _currentWindow.Close();
        }
    }
}