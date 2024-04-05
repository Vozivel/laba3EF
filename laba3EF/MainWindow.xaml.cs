using System.Linq;
using System.Windows;
namespace laba3EF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private dartbaseEntities content = new dartbaseEntities();
        public MainWindow()
        {
            InitializeComponent();
            MyDataGrid.ItemsSource = content.GetFullInfo.ToList();
        }
    }
}
