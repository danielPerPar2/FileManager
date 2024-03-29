﻿using FileManager.Common.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FileManager.DataAccess.DAO.Singletons
{
    public class VuelosSingleton
    {
        private static VuelosSingleton instance = null;
        private static readonly object padlock = new object();
        public static string FilePath { get; private set; }

        public Guid Id { get; set; }

        public static Dictionary<Airport, List<Airport>> FlightsDictionary { get; private set; }
        private VuelosSingleton()
        {
            Id = Guid.NewGuid();

            string solutionFolderPath = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = ConfigurationManager.AppSettings["flights_file_xml"];
            FilePath = solutionFolderPath + fileName;

            FlightsDictionary = new Dictionary<Airport, List<Airport>>();
            LoadFlights(FilePath);

        }
        public static VuelosSingleton Instance {
            get
            {
                lock (padlock)
                if(instance == null)
                {
                    instance = new VuelosSingleton();
                }
                return instance;
            }
        }

        private static void LoadFlights(string FilePath)
        {
            XDocument document= XDocument.Load(FilePath);
            XElement root = document.Element("airports");

            var airports = from element in root.Elements()                 
                          select element;

            foreach(XElement connection in airports)
            {
                string name = connection.Attribute("origin").Value;
                var connections = connection.Elements("connection");

                List<Airport> airportConnections = new List<Airport>();
                foreach(XElement con in connections)
                {
                    airportConnections.Add(new Airport(con.Value));
                }
                FlightsDictionary.Add(new Airport(name), airportConnections);
            }
        }     
    }
}
