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

namespace TabStoplab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ( ) {

            InitializeComponent ();

            MylistBox1.ItemsSource = GetEmplist ();
        }

        class Employer
        {
            public string Name {
                set;
                get;
            }
            public string Position {
                set;
                get;
            }
            public BitmapImage Img {
                set;
                get;
            }

        }

        private IEnumerable<Employer> GetEmplist ( )
        {

            var empList = new List<Employer>
            {
                new Employer() {Name = "Halid Cisse", Position = "CEO", Img = GetImageFromFile("Images/ico1.png")},
                new Employer() {Name = "Ousou Djounou", Position = "CMO", Img = GetImageFromFile("Images/ico2.png")},
                new Employer() {Name = "Amad Cisse", Position = "CTO", Img = GetImageFromFile("Images/ico3.png")},
                new Employer() {Name = "Keita Assouma", Position = "TCM", Img = GetImageFromFile("Images/ico4.png")},
                new Employer() {Name = "Bayogo Madou", Position = "NMO", Img = GetImageFromFile("Images/ico5.png")},
                new Employer() {Name = "Maiga Ouamr", Position = "YHN", Img = GetImageFromFile("Images/ico6.png")},
                new Employer() {Name = "Toure Kemera", Position = "RTE", Img = GetImageFromFile("Images/ico7.png")},
                new Employer() {Name = "Diallo Adam", Position = "VCI", Img = GetImageFromFile("Images/ico8.png")},
                new Employer() {Name = "Barry Alhassane", Position = "OKM", Img = GetImageFromFile("Images/ico9.png")},
                new Employer() {Name = "Cisse Aicha", Position = "LLK", Img = GetImageFromFile("Images/ico10.png")},
                new Employer() {Name = "Halid", Position = "CEO", Img = GetImageFromFile("Images/ico1.png")},
                new Employer() {Name = "Ousou", Position = "CMO", Img = GetImageFromFile("Images/ico2.png")},
                new Employer() {Name = "Amad", Position = "CTO", Img = GetImageFromFile("Images/ico3.png")},
                new Employer() {Name = "Keita", Position = "TCM", Img = GetImageFromFile("Images/ico4.png")},
                new Employer() {Name = "Bayogo", Position = "NMO", Img = GetImageFromFile("Images/ico5.png")},
                new Employer() {Name = "Maiga", Position = "YHN", Img = GetImageFromFile("Images/ico6.png")},
                new Employer() {Name = "Toure", Position = "RTE", Img = GetImageFromFile("Images/ico7.png")},
                new Employer() {Name = "Diallo", Position = "VCI", Img = GetImageFromFile("Images/ico8.png")},
                new Employer() {Name = "Barry", Position = "OKM", Img = GetImageFromFile("Images/ico9.png")},
                new Employer() {Name = "Cisse", Position = "LLK", Img = GetImageFromFile("Images/ico10.png")}
            };

            return empList;

        }


        public System.Windows.Media.Imaging.BitmapImage GetImageFromFile ( string path )
        {
            System.Windows.Media.Imaging.BitmapImage img = new System.Windows.Media.Imaging.BitmapImage ();
            img.BeginInit ();
            img.UriSource = new System.Uri (path, System.UriKind.RelativeOrAbsolute);
            img.EndInit ();

            return img;
        }

        private void Button_Click ( object sender, RoutedEventArgs e )
        {
            MainFrame.NavigationService.Navigate (new Uri ("HomePageX.xaml", UriKind.Relative));
        }



    }
}
