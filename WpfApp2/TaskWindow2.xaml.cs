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
using static WpfApp2.MainWindow;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для TaskWindow2.xaml
    /// </summary>
    public partial class TaskWindow2 : Window
    {
        public string Login1 { get; set; }
        public string Password1 { get; set; }

        public TaskWindow2()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string messageBoxText = Login1 + Password1+ "";
            string caption = "Не надо";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxImage icon = MessageBoxImage.Warning;

            MessageBox.Show(messageBoxText, caption, button, icon, MessageBoxResult.Yes);
        }

    }
}
