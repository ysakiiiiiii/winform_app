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

namespace ToDoApp
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

        private void CreateTask_Click(object sender, RoutedEventArgs e)
        {
            string todoText = "> " + TaskInput.Text;

            if(!string.IsNullOrEmpty(todoText) )
            {
                TextBlock todoItem = new TextBlock
                {   

                    Text = todoText,
                    Margin = new Thickness(10),
                    Foreground =  new SolidColorBrush(Colors.White)
                };

                TaskList.Children.Add(todoItem);

                TaskInput.Clear();
            }else
            {
                MessageBox.Show("Please enter a Task");
            }
        }
    }
}