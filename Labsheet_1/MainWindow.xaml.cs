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
        public MainWindow()
        {
            InitializeComponent();

            List<Band> allBands = new List<Band>();

            //Create Bands//
            RockBand b1 = new RockBand("Arctic Monkys", 2002, "Alex Turner, Jamie Cook, Matt Melders, Nick O'Malley");
            Band b2 = new Band("Tame Implala", 2007, "Kevin Parker, Jay Watson, Dominic Simper, Cam Avery, ");
            Band b3 = new Band("Vampire Weekend", 2002, "Alex Turner, Jamie Cook, Matt Melders, Nick Allbrook, Nick O'Malley");
            Band b4 = new Band("Peace", 2009, "Harrison Koisser, Samuel Koisser, Dominic Boyce, Douglas Castle");
            Band b5 = new Band("Rex Orange County", 2016, "Alex O'Connor");
            Band b6 = new Band("Mac Demarco", 2012, "Mac Demarco");

            //Insert Bands into list//
            allBands.Add(b1);
            allBands.Add(b2);
            allBands.Add(b3);
            allBands.Add(b4);
            allBands.Add(b5);
            allBands.Add(b6);

            //Sort Bands//
            allBands.Sort();



        }


    }
}
