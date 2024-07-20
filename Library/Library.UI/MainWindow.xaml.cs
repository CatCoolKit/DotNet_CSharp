using Library.UI.Entities;
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

namespace Library.UI
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LibraryDbContext context = new LibraryDbContext();
            BookListDataGrid.ItemsSource = context.Books.ToList();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            LibraryDbContext context = new LibraryDbContext();
            Book book = new Book
            {
                BookName = BookNameTextBox.Text,
            };
            context.Books.Add(book);
            context.SaveChanges();
            BookListDataGrid.ItemsSource = null;
            BookListDataGrid.ItemsSource = context.Books.ToList();
        }
    }
}