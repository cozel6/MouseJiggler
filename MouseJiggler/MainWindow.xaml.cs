using MouseJiggler;
using System.Windows;

namespace MouseJiggler
{
    public partial class MainWindow : Window
    {
        private readonly Jiggler _jiggler = new Jiggler();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            // Start
            _jiggler.Start();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            // Stop
            _jiggler.Stop();
        }
    }
}
