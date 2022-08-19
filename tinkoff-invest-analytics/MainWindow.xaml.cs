using System.Windows;


namespace tinkoff_invest_analytics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Tinkoff_Info f = new Tinkoff_Info();

            f.GetClient();
        }
    }
}
