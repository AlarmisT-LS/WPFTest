using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFTest
{
    /// <summary>
    /// Логика взаимодействия для TaskWinfow.xaml
    /// </summary>
    public partial class TaskWinfow : Window
    {
        public event Action<string> message;
        public TaskWinfow()
        {
            InitializeComponent();
        }

        private void buttonTextBox_Click(object sender, RoutedEventArgs e)
        {
            message?.Invoke(textbox.Text);
        }
    }
}
