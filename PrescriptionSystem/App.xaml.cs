using System.Windows;

namespace PrescriptionSystem
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var mainWindow = new MainWindow();
            //mainWindow.DataContext = new PatientViewModel();
            mainWindow.Show();
        }
    }

}
