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


namespace Endoskope
{
    public partial class Form1 : Form
    {

        MySqlConnection DatenbankVerbindung = new MySqlConnection();
        Dictionary<int, string> idToHersteller = new Dictionary<int, string>();
        Dictionary<string, int> herstellerToId = new Dictionary<string, int>();


        public Form1()
        {
            InitializeComponent();
            DatenbankVerbindung.ConnectionString = "Data Source=localhost;"
               + "port=3306; SslMode=none;"
               + "initial catalog=M_2403249; uid=M_2403249; pwd=M_2403249";
            DatenbankVerbindung.Open();

            GetHersteller();    
            FillDataGrid();
        }

        MySqlDataReader ExecuteQuery(string query)
        {
            MySqlCommand abfrage = new MySqlCommand();
            abfrage.Connection = DatenbankVerbindung;
            abfrage.CommandText = query;
            MySqlDataReader reader = abfrage.ExecuteReader();
            return reader;
        }

        MySqlCommand ExecuteNonQuery(string statement)
        {
            MySqlCommand abfrage = new MySqlCommand();
            abfrage.Connection = DatenbankVerbindung;
            abfrage.CommandText = statement;
            abfrage.ExecuteNonQuery();
            return abfrage;
        }

        void GetHersteller()
        {
            MySqlDataReader reader = ExecuteQuery("SELECT id, name FROM endo_hersteller");
            while (reader.Read())
            {
                herstellerToId[reader["name"].ToString()] = (int)reader["id"];
                idToHersteller[(int)reader["id"]] = reader["name"].ToString();
                herstellerCombobox.Items.Add(reader["name"].ToString());
            }
            reader.Close();
        }
        void FillDataGrid()
        {
            MySqlDataReader reader = ExecuteQuery("SELECT * FROM endo_endoskope");
            while (reader.Read())
            {
                endoskopeDataGrid.Rows.Add(reader["bezeichnung"], reader["durchmesser"], reader["laenge"], reader["anz_kanaele"], idToHersteller[(int)reader["endo_hersteller_id"]]);
            }
            reader.Close();
        }

        private void endoAnlegenButton_Click(object sender, EventArgs e)
        {
            string statement = $"INSERT INTO endo_endoskope (bezeichnung, durchmesser, laenge, anz_kanaele, endo_hersteller_id)" +
                $"VALUES (\"{bezeichnungTextbox.Text}\", {durchmesserNumeric.Value.ToString().Replace(",", ".")}, {laengeNumeric.Value}, {kanaeleNumeric.Value}, {herstellerToId[herstellerCombobox.Text]})";
            ExecuteNonQuery(statement);
            endoskopeDataGrid.Rows.Add(bezeichnungTextbox.Text, durchmesserNumeric.Value, laengeNumeric.Value, kanaeleNumeric.Value, herstellerCombobox.Text);
        }

        private void herstellerAnlegenButton_Click(object sender, EventArgs e)
        {
            string statement = $"INSERT INTO endo_hersteller (name, ort)" +
                $"VALUES (\"{nameTextbox.Text}\", \"{ortTextbox.Text}\")";
            MySqlCommand cmd = ExecuteNonQuery(statement);

            herstellerToId[nameTextbox.Text] = (int)cmd.LastInsertedId;
            idToHersteller[(int)cmd.LastInsertedId] = nameTextbox.Text;
            herstellerCombobox.Items.Add(nameTextbox.Text);

        }
    }
}
