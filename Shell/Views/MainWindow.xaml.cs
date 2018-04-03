using FXBocompPreparer.classes;

namespace Shell.Views
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            // InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            WinController.Instance.SetWin("MainWindow", this);
        }
    }
}
