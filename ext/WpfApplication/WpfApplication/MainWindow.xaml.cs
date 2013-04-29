using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication
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

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void checkBox_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox.IsChecked == true)
                checkBoxLabel.Content = "checkBox is on";
            else
                checkBoxLabel.Content = "checkBox is off";
        }

        private void radioButton1_Click(object sender, RoutedEventArgs e)
        {
            radioButtonLabel.Content = "Option 1 selected";
        }

        private void radioButton2_Click(object sender, RoutedEventArgs e)
        {
            radioButtonLabel.Content = "Option 2 selected";
        }

        private void radioButtonReset_Click(object sender, RoutedEventArgs e)
        {
            radioButton1.IsChecked = false;
            radioButton2.IsChecked = false;
            radioButtonLabel.Content = "No option selected";
        }

        private void FruitsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            fruitsLabel.Content = FruitsComboBox.Text;
        }

        private void nextFormButton_Click(object sender, EventArgs e)
        {
            DataEntryForm form = new DataEntryForm();
            form.Show();
        }

        private void buttonButton_Click(object sender, EventArgs e)
        {
            SimpleElementsForm buttonForm = new SimpleElementsForm();
            buttonForm.Show();
        }

        private void calendar1_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
