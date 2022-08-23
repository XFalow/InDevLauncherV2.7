
using System;
using System.Windows;
using System.Windows.Threading;

namespace InDevLauncher
{

    /// <summary>
    /// Logique d'interaction pour LoadingScreen.xaml
    /// </summary>
    public partial class LoadingScreen : Window
    {

        DispatcherTimer dT = new DispatcherTimer();

        public LoadingScreen()
        {
            InitializeComponent();

            Random rnd = new Random();
            int loadTime = rnd.Next(2, 6);

            dT.Tick += new EventHandler(dt_Tick);
            dT.Interval = new TimeSpan(0, 0, loadTime);
            dT.Start();
        }

        private void dt_Tick(object sender, EventArgs e)
        {
            MainWindow db = new MainWindow();
            db.Show();

            dT.Stop();
            this.Close();
        }
    }
}