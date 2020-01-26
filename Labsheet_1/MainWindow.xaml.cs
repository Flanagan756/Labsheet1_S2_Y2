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

namespace Labsheet_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> allBands = new List<Band>();
        List<Band> allRockBands = new List<Band>();
        List<Band> allIndieBands = new List<Band>();
        List<Band> allPopBands = new List<Band>();
        List<Band> selectedBand = new List<Band>();

        List<Album> amAlbum = new List<Album>();
        List<Album> tiAlbum = new List<Album>();
        List<Album> vwAlbum = new List<Album>();
        List<Album> pAlbum = new List<Album>();
        List<Album> rocAlbum = new List<Album>();
        List<Album> mdAlbum = new List<Album>();

        List<Band> selectedAlbum = new List<Band>();

        public MainWindow()
        {
            InitializeComponent();



            //Create Bands//
            RockBand b1 = new RockBand("Arctic Monkys", 2002, "Alex Turner, Jamie Cook, Matt Melders, Nick O'Malley");
            IndieBand b2 = new IndieBand("Tame Implala", 2007, "Kevin Parker, Jay Watson, Dominic Simper, Cam Avery, ");
            IndieBand b3 = new IndieBand("Vampire Weekend", 2002, "Alex Turner, Jamie Cook, Matt Melders, Nick Allbrook, Nick O'Malley");
            RockBand b4 = new RockBand("Peace", 2009, "Harrison Koisser, Samuel Koisser, Dominic Boyce, Douglas Castle");
            PopBand b5 = new PopBand("Rex Orange County", 2016, "Alex O'Connor");
            IndieBand b6 = new IndieBand("Mac DeMarco", 2012, "Mac Demarco");

            //Create Albums
            Album am1 = new Album("AM", 200000);
            Album am2 = new Album("Favourite Worst Nightmare", 10000);
            Album ti1 = new Album("Currents", 15000);
            Album vw1 = new Album("Dianne", 30000);
            Album p1 = new Album("Happy People", 4000);
            Album p2 = new Album("In Love", 4000);
            Album roc1 = new Album("Bcos U Will Never B Free", 34000);
            Album roc2 = new Album("Pony", 9900);
            Album md1 = new Album("Here Comes the Cowboy", 16700);
            Album md2 = new Album("Salad Days", 943000);

            //Insert Bands into list//
            allBands.Add(b1);
            allBands.Add(b2);
            allBands.Add(b3);
            allBands.Add(b4);
            allBands.Add(b5);
            allBands.Add(b6);


            //Insert Albums into their corrisponding bands List//
            amAlbum.Add(am1);
            amAlbum.Add(am2);
            tiAlbum.Add(ti1);
            vwAlbum.Add(vw1);
            pAlbum.Add(p1);
            pAlbum.Add(p2);
            rocAlbum.Add(roc1);
            rocAlbum.Add(roc2);
            mdAlbum.Add(md1);
            mdAlbum.Add(md2);

            /*Ask Keith how to replace with a foreach loop*/

            allRockBands.Add(b1);
            allRockBands.Add(b4);

            allIndieBands.Add(b2);
            allIndieBands.Add(b3);
            allIndieBands.Add(b6);


            allPopBands.Add(b5);
        
            //Sort Bands//
            allBands.Sort();

           //Display
           lbxBandInfo.ItemsSource = allBands;

        }
            private void ComboBoxItem_Selected1(object sender, RoutedEventArgs e)
        {

            lbxBandInfo.ItemsSource = null;
            lbxBandInfo.ItemsSource = allRockBands;
        }

        private void ComboBoxItem_Selected2(object sender, RoutedEventArgs e)
        {
            lbxBandInfo.ItemsSource = null;
            lbxBandInfo.ItemsSource = allIndieBands;
        }

        private void ComboBoxItem_Selected3(object sender, RoutedEventArgs e)
        {
            lbxBandInfo.ItemsSource = null;
            lbxBandInfo.ItemsSource = allPopBands;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the currently selected item in the ListBox.
            Band selectedBand = lbxBandInfo.SelectedItem as Band;

            if (selectedBand != null)    //Checks if something is selected
            {
                //Display activity in text box
                txtBandFormation.Text = ("Formed : " + selectedBand.YearFormed.ToString());

                //Display band memebers in text box
                txtBandMemebrs.Text = ("Members : " + selectedBand.Members.ToString());

                //Display the bands album list
                switch(selectedBand.BandName)
                {
                    case "Arctic Monkys":
                        lbxAlbums.ItemsSource = null;
                        lbxAlbums.ItemsSource = amAlbum;
                        break;
                    case "Tame Implala":
                        lbxAlbums.ItemsSource = null;
                        lbxAlbums.ItemsSource = tiAlbum;
                        break;
                    case "Vampire Weekend":
                        lbxAlbums.ItemsSource = null;
                        lbxAlbums.ItemsSource = vwAlbum;
                        break;
                    case "Peace":
                        lbxAlbums.ItemsSource = null;
                        lbxAlbums.ItemsSource = pAlbum;
                        break;
                    case "Rex Orange County":
                        lbxAlbums.ItemsSource = null;
                        lbxAlbums.ItemsSource = rocAlbum;
                        break;
                    case "Mac DeMarco":
                        lbxAlbums.ItemsSource = null;
                        lbxAlbums.ItemsSource = mdAlbum;
                        break;
                }

      

            }

        }

      
    }
}
