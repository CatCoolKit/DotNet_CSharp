using AirConditionerShop.BLL.Services;
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

namespace AirConditionerShop_HoangNgocTrinh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly AirConService _airConService;

        public MainWindow()
        {
            InitializeComponent();
            _airConService = new();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            DetailWindow d = new();
            d.ShowDialog();
            FillDataGrid();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            AirConsDataGrid.ItemsSource = null;
            AirConsDataGrid.ItemsSource = _airConService.GetAll();
        }

        private void AirConsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}