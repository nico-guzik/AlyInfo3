using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Citynames
{
    public partial class Form1 : Form
    {
        MySqlConnection DatenbankVerbindung = new MySqlConnection();
        List<City> cities = new List<City>();

        struct City
        {
            public City(string name, string country, string einwohner)
            {
                Name = name;
                Country = country;
                Einwohner = einwohner;
            }
            public string Name { get; }
            public string Country { get; }
            public string Einwohner { get; }

            public override string ToString()
            {
                return Name;
            }
        }

        public Form1()
        {  // Konstruktor

            InitializeComponent();
            // Aufbau der Datenbankverbindung
            DatenbankVerbindung.ConnectionString = "Data Source=srlehre01.ls.haw-hamburg.de;"
                + "port=3306; SslMode=none;"
                + "initial catalog=Terra; uid=terrauser; pwd=testen";
            DatenbankVerbindung.Open();
            // Aufbau und Absenden einer SELECT-Abfrage
            //string allCitiesStatement = "SELECT ST_NAME FROM STADT ORDER BY ST_NAME";
            //MySqlDataReader reader = ExecuteSQLCommand(allCitiesStatement);
            //FillListBox(CitiesListbox, reader);
            ReadData();
        }

        void ReadData()
        {
            string allCitiesStatement = "SELECT ST_NAME, L_ID, EINWOHNER FROM STADT ORDER BY ST_NAME";
            MySqlDataReader reader = ExecuteSQLCommand(allCitiesStatement);
            while (reader.Read())
            {
                City city = new City(reader["ST_Name"].ToString(), reader["L_ID"].ToString(), reader["EINWOHNER"].ToString());
                cities.Add(city);
                CitiesListbox.Items.Add(city);
            }
            reader.Close();
        }

        void OnCitySelect(object sender, EventArgs e)
        {
            string populationStatement = $"SELECT EINWOHNER FROM STADT WHERE ST_NAME=\"{CitiesListbox.SelectedItem}\"";
            MySqlDataReader reader = ExecuteSQLCommand(populationStatement);
            if (reader.Read() == true)
            {
                PopulationLabel.Text = $"Einwohner: {reader[0]}";
            }
            reader.Close();



            string countryIdStatement = $"SELECT L_ID FROM STADT WHERE ST_NAME =\"{CitiesListbox.SelectedItem}\"";
            reader = ExecuteSQLCommand(countryIdStatement);
            string countryId ="";
            if (reader.Read() == true) {
                countryId = reader[0].ToString();
            }
            reader.Close();
            

            string countryStatement = $"SELECT L_NAME FROM LAND WHERE L_ID = \"{countryId}\"";
            reader = ExecuteSQLCommand(countryStatement);
            if (reader.Read() == true)
            {
                CountryLabel.Text = $"Land: {reader[0]}";
            }
            reader.Close();



            string otherCitiesStatement = $"SELECT ST_NAME FROM STADT WHERE L_ID = \"{countryId}\"";
            reader = ExecuteSQLCommand(otherCitiesStatement);
            FillListBox(OtherCitiesTextbox, reader);
            reader.Close();

        }

        void OnFilterChange(object sender, EventArgs e)
        {
            string statement = $"SELECT ST_NAME FROM STADT WHERE ST_NAME LIKE \"%{FilterTextbox.Text}%\"";
            MySqlDataReader reader = ExecuteSQLCommand(statement);
            FillListBox(CitiesListbox, reader);
        }

        MySqlDataReader ExecuteSQLCommand(string command)
        {
            MySqlCommand abfrage = new MySqlCommand();
            abfrage.Connection = DatenbankVerbindung;
            abfrage.CommandText = command;
            MySqlDataReader reader = abfrage.ExecuteReader();
            return reader;
        }

        void FillListBox(ListBox box, MySqlDataReader reader)
        {
            // Lesen und Verarbeiten der Daten
            box.Items.Clear();
            while (reader.Read() == true)
            {
                box.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

    }
}
