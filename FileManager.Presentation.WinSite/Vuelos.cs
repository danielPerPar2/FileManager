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

        private static VuelosSingleton vuelosSingleton = null;

        private Dictionary<Airport, List<Airport>> cachedDestinations = new Dictionary<Airport, List<Airport>>();

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
            int size = VuelosSingleton.FlightsDictionary.Keys.Count;
            string[] items = new string[size];

            for(int i = 0; i < size; ++i)
            {
                items[i] = VuelosSingleton.FlightsDictionary.Keys.ElementAt(i).Name;
            }
            originCbo.DataSource = items;
            originCbo.SelectedIndex = 0;
        }

        private void InitializeDestinationCombobox(string cityName)
        {
            if (FoundCachedDestination(cityName, out List<Airport> destinations))
            {
                destinationCbo.DataSource = destinations;
                destinationCbo.SelectedItem = 0;
            }
            else
            {                
                List<Airport> airports;
                bool found = GetDestinations(cityName, out airports);
                if (!found)
                {
                    throw new Exception("No airports");
                }

                List<string> airportNames = CreateDestinations(airports);

                destinationCbo.DataSource = airportNames;
                destinationCbo.SelectedItem = 0;
              
                cachedDestinations.Add(new Airport(cityName), airports);
            }
        }

        private bool FoundCachedDestination(string originCityName, out List<Airport> cachedDestination)
        {
            List<Airport> destination;
            bool isDestinationCached = GetCachedDestinations(originCityName, out destination);
            if(isDestinationCached)
            {
                cachedDestination = destination;
                return true;
            }
            cachedDestination = new List<Airport>();
            return false;
        }

        private bool GetCachedDestinations(string originCityName, out List<Airport> destination)
        {
            try
            {
                return cachedDestinations.TryGetValue(new Airport(originCityName), out destination);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private bool GetDestinations(string originCityName, out List<Airport> destination)
        {
            try
            {
                return VuelosSingleton.FlightsDictionary.TryGetValue(new Airport(originCityName), out destination);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private List<string> CreateDestinations(List<Airport> airports)
        {
            List<string> result = new List<string>();
            foreach(Airport airport in airports)
            {
                result.Add(airport.Name);
            }
            
            return result;
        }
    }
}
