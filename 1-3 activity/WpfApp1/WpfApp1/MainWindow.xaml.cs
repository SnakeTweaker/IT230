
/*
CJ Busca
IT-230 Software Development with C#.NET
05/04/2021
1-3 Coding Activity: Your First C# WPF Application (HelloYourName)
*/
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

namespace HelloYourName
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void okClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello " + userName.Text + " and welcome to C#!");
        }
    }
}