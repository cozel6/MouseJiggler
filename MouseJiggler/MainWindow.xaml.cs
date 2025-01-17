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
            // Pornim jiggler-ul
            _jiggler.Start();
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            // Oprim jiggler-ul
            _jiggler.Stop();
        }
    }
}
