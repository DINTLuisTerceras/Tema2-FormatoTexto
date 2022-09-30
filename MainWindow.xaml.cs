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

namespace T2_ej5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void userTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            titleTextBlock.Text = userTextBox.Text;
        }

        private void blueRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            titleTextBlock.Foreground = Brushes.Blue;
        }

        private void redRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            titleTextBlock.Foreground = Brushes.Red;
        }

        private void greenRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            titleTextBlock.Foreground = Brushes.Green;
        }

        private void boldCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            titleTextBlock.FontWeight = FontWeights.Bold;
        }

        private void boldCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            titleTextBlock.FontWeight = FontWeights.Normal;
        }

        private void obliqueCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            titleTextBlock.FontStyle = FontStyles.Oblique;
        }

        private void obliqueCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            titleTextBlock.FontStyle = FontStyles.Normal;
        }
    }
}
