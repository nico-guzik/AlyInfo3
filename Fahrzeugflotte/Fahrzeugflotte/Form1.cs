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

namespace Fahrzeugflotte
{
    public partial class Form1 : Form
    {
        MySqlConnection DatenbankVerbindung = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
            DatenbankVerbindung.ConnectionString = "Data Source=localhost;"
                + "port=3306; SslMode=none;"
                + "initial catalog=M_2403249; uid=M_2403249; pwd=M_2403249";
            DatenbankVerbindung.Open();

            FillDataGrid();
            FillHerstellerComboBox();
        }

        MySqlDataReader ExecuteQuery(string query)
        {
            MySqlCommand abfrage = new MySqlCommand();
            abfrage.Connection = DatenbankVerbindung;
            abfrage.CommandText = query;
            MySqlDataReader reader = abfrage.ExecuteReader();
            return reader;
        }

        void ExecuteNonQuery(string statement)
        {
            MySqlCommand abfrage = new MySqlCommand();
            abfrage.Connection = DatenbankVerbindung;
            abfrage.CommandText = statement;
            abfrage.ExecuteNonQuery();
        }

        void FillDataGrid()
        {
            MySqlDataReader reader = ExecuteQuery("SELECT * FROM fahrzeuge");
            string[] zeile = new string[5];
            while (reader.Read() == true) {
                for (int i = 0; i < zeile.Length; i++)
                {
                    zeile[i] = reader[i].ToString();
                }
                fahrzeugeDataGrid.Rows.Add(zeile);
            }
            reader.Close();
        }

        void FillHerstellerComboBox()
        {
            MySqlDataReader reader = ExecuteQuery("SELECT name FROM kfzhersteller");
            while (reader.Read() == true)
            {
                herstellerCombobox.Items.Add(reader["name"].ToString());
            }
            reader.Close();
        }

        private void anlegenButton_Click(object sender, EventArgs e)
        {
            if (kennzeichenTextbox.Text == "" || herstellerCombobox.Text == "" || modellTextbox.Text == "")
            {
                //Fehler
                Console.WriteLine("Alle Felder müssen ausgefüllt werden.");
            }
            else
            {
                string insertStatement = "INSERT INTO fahrzeuge" +
                    $" VALUES (\"{kennzeichenTextbox.Text}\",\"{herstellerCombobox.Text}\",\"{modellTextbox.Text}\",{jahrNumeric.Value}, {leistungNumeric.Value})";
                ExecuteNonQuery(insertStatement);
                string[] zeile = new string[5];
                zeile[0] = kennzeichenTextbox.Text;
                zeile[1] = herstellerCombobox.Text;
                zeile[2] = modellTextbox.Text;
                zeile[3] = jahrNumeric.Value.ToString();
                zeile[4] = leistungNumeric.Value.ToString();
                fahrzeugeDataGrid.Rows.Add(zeile);
                ClearInput();
            }
        }

        private void ClearInput()
        {
            kennzeichenTextbox.Text = "";
            herstellerCombobox.Text = "";
            modellTextbox.Text = "";
            leistungNumeric.Value = 0;
        }

        private void löschenButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = fahrzeugeDataGrid.SelectedRows;
            string message = "";
            if(selectedRows.Count == 0) { return; }
            if(selectedRows.Count == 1)
            {
                message = $"Wollen Sie das Fahrzeug mit dem Kennzeichen {selectedRows[0].Cells["Kennzeichen"].Value} wirklich löschen ? ";
            }
            if(selectedRows.Count > 1)
            {
                List<string> kennzeichen = new List<string>();
                foreach(DataGridViewRow row in selectedRows)
                {
                    kennzeichen.Add(row.Cells["Kennzeichen"].Value.ToString());
                }
                message = $"Wollen Sie die Fahrzeuge mit den Kennzeichen {String.Join(", ", kennzeichen)} wirklich löschen ? ";
            }
            if (MessageBox.Show(message, "Nachfrage Löschen", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    ExecuteNonQuery($"DELETE FROM Fahrzeuge WHERE Kennzeichen=\"{row.Cells["Kennzeichen"].Value}\"");
                    fahrzeugeDataGrid.Rows.Remove(row);
                }
            }

        }
    }
}
        
   

