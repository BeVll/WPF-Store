using StoreLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StoreWpf
{
    /// <summary>
    /// Interaction logic for CreateProductWindow.xaml
    /// </summary>
    public partial class CreateProductWindow : Window
    {
        public Product Product { get; set; }

        public CreateProductWindow()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();

            product.Id = long.Parse(BarcodeTextBox.Text);
            product.Title = TitleTextBox.Text;
            product.Price = decimal.Parse(PriceTextBox.Text);
            product.Description = DescriptionTextBox.Text;

            if (IsDigitalRadioButton.IsChecked == true)
            {
                product.Type = ProductType.Digital;
            }
            else if (IsPhysicalRadioButton.IsChecked == true)
            {
                product.Type = ProductType.Physical;
            }

            Product = product;

            DialogResult = true;
        }

    }    
}
