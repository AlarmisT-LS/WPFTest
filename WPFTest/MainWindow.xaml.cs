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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            labeltextbox.Text = "Не знаю что тут написать)";
            buttentextbox.Content = "Нажми что бы создать новое окно";
        }

        private void buttentextbox_Click(object sender, RoutedEventArgs e)
        {
            TaskWinfow taskWindow = new TaskWinfow();
            taskWindow.Show();
            taskWindow.message += message => { textbox.Text = message; };
        }
    }
}
