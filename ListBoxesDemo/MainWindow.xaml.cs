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
using ListBoxesDemo.Data;

namespace ListBoxesDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>
        {
            new Person{Name = "Lucky", Age = 20},
            new Person{Name = "Allysa", Age = 20},
            new Person{Name = "Aki", Age = 24},
            new Person{Name = "Ysaki", Age = 25},
            new Person{Name = "Alliesum", Age = 28}

        };
        public MainWindow()
        {
            InitializeComponent();

            ListBoxNames.ItemsSource = people;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedItems = ListBoxNames.SelectedItems;

            foreach (var item in selectedItems)
            {
                var person = item as Person;
                MessageBox.Show(person.Name);
            }
        }
    }
}