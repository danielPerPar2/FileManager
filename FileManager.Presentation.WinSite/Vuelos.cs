using FileManager.Common.Models;
using FileManager.DataAccess.DAO.Singletons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Presentation.WinSite
{
    public partial class Vuelos : Form
    {
        private static VuelosSingleton vuelosSingleton = null;

        public string language = Properties.Settings.Default.Language;

        public Vuelos()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
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
            List<Airport> airports;
            bool found = VuelosSingleton.FlightsDictionary.TryGetValue(new Airport(cityName), out airports);
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

        private void ChangeLanguage(string lang)
        {
            foreach(Control c in  this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Vuelos));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }  
        }

        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en-GB");
            this.Text = "Flights";
            Properties.Settings.Default.Language = "en-GB";
            //TODO: remove literal strings
        }

        private void SpanishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("es-ES");
            this.Text = "Vuelos";
            Properties.Settings.Default.Language = "es-ES";
            //TODO: remove literal strings
        }
    }
}
