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
using StoreLibrary;

namespace StoreWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Store _store;

        public MainWindow()
        {
            _store = new Store("My Store");

            _store.AddProduct(new Product
            {
                Id = 1,
                Title = "Product 1",
                Price = 9.99m,
                Description = "This is product 1",
                Type = ProductType.Physical
            });

            _store.AddProduct(new Product
            {
                Id = 2,
                Title = "Product 2",
                Price = 19.99m,
                Description = "This is product 2",
                Type = ProductType.Digital
            });

            _store.AddProduct(new Product
            {
                Id = 3,
                Title = "Product 3",
                Price = 29.99m,
                Description = "This is product 3",
                Type = ProductType.Physical
            });

            InitializeComponent();

            UpdateProductList();
            ProductComboBox.SelectedIndex = 0;


            ProductComboBox.PreviewMouseWheel += (o, e) => { if (!ProductComboBox.IsDropDownOpen) e.Handled = true; };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateProductWindow createProductWindow = new CreateProductWindow { Owner = this };


            bool? result = createProductWindow.ShowDialog();

            if (result == true)
            {
                _store.AddProduct(createProductWindow.Product);
                UpdateProductList();
            }


        }

        public void UpdateProductList()
        {
            ProductComboBox.ItemsSource = null;
            ProductComboBox.ItemsSource = _store.GetAllProducts();
        }

       
}
}