using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ImageGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {     
        PageImage PageImagee;
        public ObservableCollection<Picture> Pictures { get; set; }
        

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            Pictures = new ObservableCollection<Picture>
            {
               new Picture
               {
                    ImageSource="Images/aze.png"
               },
               new Picture
               {
                    ImageSource="Images/baku.png"
               },
               new Picture
               {
                    ImageSource="Images/army.png"
               },
               new Picture
               {
                    ImageSource="Images/wolf.png"
               }
            };
        }

  
        private void listbox_image_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
          
            PageImagee = new PageImage();
            var image = listbox_image.SelectedItem as Picture;
            PageImagee.Image.Source = new BitmapImage(new Uri(image.ImageSource, UriKind.RelativeOrAbsolute));
            PageImagee.SelectedIndex = listbox_image.SelectedIndex;


            Main.Content = PageImagee;
         
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(sender is MenuItem menuItem)
            {
               if (menuItem.Header.ToString() == "Small") Resources["imageSize"] = 150.0;
               else if (menuItem.Header.ToString() == "Medium") Resources["imageSize"] = 250.0;
               else  if (menuItem.Header.ToString() == "Large") Resources["imageSize"] = 500.0;
               else if(menuItem.Header.ToString()=="Add File")
               {
                    OpenFileDialog openFile = new OpenFileDialog();

                    openFile.Multiselect = false;
                    openFile.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
                    openFile.FilterIndex = 2;

                    if (openFile.ShowDialog() == true)
                    {
                        Picture newImage = new Picture()
                        {
                             ImageSource = openFile.FileName
                        };
                        Pictures.Add(newImage);
                    }
               }
            }
        }

    }
}
