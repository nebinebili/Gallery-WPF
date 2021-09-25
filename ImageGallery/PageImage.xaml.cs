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
using System.Threading;
using System.Collections.ObjectModel;

namespace ImageGallery
{
    /// <summary>
    /// Interaction logic for PageImage.xaml
    /// </summary>
    public partial class PageImage : Page
    {
        public ObservableCollection<Picture> TempPictures { get; set; }
        public int SelectedIndex { get; set; }

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

       
       
        public static readonly DependencyProperty PictureProperty =
         DependencyProperty.Register("Picture", typeof(Picture), typeof(PageImage));


        public PageImage()
        {
            InitializeComponent();

            DataContext = this;

            TempPictures = ((MainWindow)Application.Current.MainWindow).Pictures;

        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;  
        }

        private void PlayImages_Tick(object sender, EventArgs e)
        {
            Play();
        }

        
        private void Play()
        {
            dispatcherTimer.Start();
            dispatcherTimer.Interval = new TimeSpan(0,0,0,3);

            if (SelectedIndex != TempPictures.Count-1)
            {
                Image.Source = new BitmapImage(new Uri(TempPictures[SelectedIndex+1].ImageSource, UriKind.RelativeOrAbsolute));
                SelectedIndex += 1;
            }
            else
            {
                SelectedIndex = 0;
                Image.Source = new BitmapImage(new Uri(TempPictures[SelectedIndex].ImageSource, UriKind.RelativeOrAbsolute));
            }

            
        }

        private void autoplay_Click(object sender, RoutedEventArgs e)
        {
            Play();
            dispatcherTimer.Tick += new EventHandler(PlayImages_Tick);
        }

       
        private void pasue_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedIndex != TempPictures.Count - 1)
            {
                Image.Source = new BitmapImage(new Uri(TempPictures[SelectedIndex + 1].ImageSource, UriKind.RelativeOrAbsolute));
                SelectedIndex += 1;
            }
            else
            {
                SelectedIndex = 0;
                Image.Source = new BitmapImage(new Uri(TempPictures[SelectedIndex].ImageSource, UriKind.RelativeOrAbsolute));
            }
        }

       

        private void previous_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedIndex !=0)
            {
                Image.Source = new BitmapImage(new Uri(TempPictures[SelectedIndex - 1].ImageSource, UriKind.RelativeOrAbsolute));
                SelectedIndex -= 1;
            }
            else
            {
                SelectedIndex = TempPictures.Count - 1;
                Image.Source = new BitmapImage(new Uri(TempPictures[SelectedIndex].ImageSource, UriKind.RelativeOrAbsolute));
            }
        }
    }
}
