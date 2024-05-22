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
    public partial class setting : Window
    {
        private Brush darkModeBrush = new SolidColorBrush(Color.FromRgb(0, 0, 0));

        public setting()
        {
            InitializeComponent();

            DataContext = this;
        }

        private void ToggleDarkMode()
        {
            if (Application.Current.Resources["DarkMode"] is Brush darkMode && darkMode != null)
            {
                Application.Current.Resources["DarkMode"] = null;
            }
            else
            {
                Application.Current.Resources["DarkMode"] = darkModeBrush;
            }
        }

        private void GoBack()
        {
            this.Close();
        }
    }
}

