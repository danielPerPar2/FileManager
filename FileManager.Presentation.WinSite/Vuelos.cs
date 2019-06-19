using FileManager.Common.Models;
using FileManager.DataAccess.DAO.Singletons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Presentation.WinSite
{
    public partial class Vuelos : Form
    {

        private  VuelosSingleton vuelosSingleton = null;

        public Vuelos()
        {
            InitializeComponent();
        }

        private void originCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = originCbo.SelectedItem.ToString();
            InitializeDestinationCombobox(selectedCity);
        }

        private void destinationCbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nothing to do atm.
        }

        private void Vuelos_Load(object sender, EventArgs e)
        {
            vuelosSingleton = VuelosSingleton.Instance;
            InitializeOriginComboBox();

            string selectedCity = originCbo.SelectedItem.ToString();
            InitializeDestinationCombobox(selectedCity);
        }

        private void InitializeOriginComboBox()
        {
            int size = vuelosSingleton.FlightsDictionary.Keys.Count;
            string[] items = new string[size];

            for(int i = 0; i < size; ++i)
            {
                items[i] = vuelosSingleton.FlightsDictionary.Keys.ElementAt(i).Name;
            }
            originCbo.DataSource = items;
            originCbo.SelectedIndex = 0;
        }

        private void InitializeDestinationCombobox(string cityName)
        {
            List<Airport> airports;
            bool found = vuelosSingleton.FlightsDictionary.TryGetValue(new Airport(cityName), out airports);
            if (!found)
            {
                throw new Exception("No airports");
            }
            string[] airportNames = new string[airports.Count];
            for(int i = 0; i < airportNames.Length; ++i)
            {
                airportNames[i] = airports[i].Name;
            }
            destinationCbo.DataSource = airportNames;
            destinationCbo.SelectedItem = 0;
        }
    }
}
