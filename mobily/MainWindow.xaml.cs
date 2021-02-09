using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mobily
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
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public void playSound(String link)
        {

            mediaPlayer.Open(new Uri(link, UriKind.RelativeOrAbsolute));
            mediaPlayer.Play();

        }
        private void ImageMainButton_TouchDown(object sender, TouchEventArgs e)
        {
            try
            {
                playSound(@"Resources\mobily-loud.mp3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }

        private void ImageMainButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                playSound(@"Resources\mobily-loud.mp3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Issue is " + ex);
            }
        }
    }
}
