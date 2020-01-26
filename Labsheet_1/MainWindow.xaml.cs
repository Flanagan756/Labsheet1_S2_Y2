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

        public MainWindow()
        {
            InitializeComponent();



            //Create Bands//
            RockBand b1 = new RockBand("Arctic Monkys", 2002, "Alex Turner, Jamie Cook, Matt Melders, Nick O'Malley");
            IndieBand b2 = new IndieBand("Tame Implala", 2007, "Kevin Parker, Jay Watson, Dominic Simper, Cam Avery, ");
            IndieBand b3 = new IndieBand("Vampire Weekend", 2002, "Alex Turner, Jamie Cook, Matt Melders, Nick Allbrook, Nick O'Malley");
            RockBand b4 = new RockBand("Peace", 2009, "Harrison Koisser, Samuel Koisser, Dominic Boyce, Douglas Castle");
            PopBand b5 = new PopBand("Rex Orange County", 2016, "Alex O'Connor");
            IndieBand b6 = new IndieBand("Mac Demarco", 2012, "Mac Demarco");

            //Insert Bands into list//
            allBands.Add(b1);
            allBands.Add(b2);
            allBands.Add(b3);
            allBands.Add(b4);
            allBands.Add(b5);
            allBands.Add(b6);


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


            }

        }
    }
}
