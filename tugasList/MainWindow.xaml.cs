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

namespace tugasList
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

        private void AddNameButton_Click(object sender, RoutedEventArgs e)
        {
            string newName = nameTextBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(newName))
            {
                // Check if the name already exists in the list
                if (!nameListBox.Items.Contains(newName))
                {
                    // Add the name to the ListBox
                    nameListBox.Items.Add(newName);

                    // Clear the TextBox
                    nameTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Name already exists in the list.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid name.");
            }
        }
    }
}
