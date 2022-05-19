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


namespace Tennishalle
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

            FillDataGrid(1);
        }

        void InitializeDataGrid()
        {
            for(int i = 10; i < 22; i++)
            {
                reservierungenDataGrid.Rows.Add(i.ToString(), "---", "---", "---");
            }
        }

        void ResetDataGrid()
        {
            reservierungenDataGrid.Rows.Clear();
            InitializeDataGrid();
        }

        void FillDataGrid(int day)
        {
            ResetDataGrid();
            MySqlDataReader reader = ExecuteQuery($"SELECT * FROM Hallenreservierungen WHERE Tag={day}");
            while (reader.Read())
            {
                reservierungenDataGrid.Rows[((int)reader["stunde"])-10].Cells[(int)reader["platz"]].Value = reader["name"];
            }
            reader.Close();
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

        private void tagNumeric_ValueChanged(object sender, EventArgs e)
        {
            FillDataGrid(Decimal.ToInt32(tagNumeric.Value));
        }

        private void eintragenButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text == "")
            {
                MessageBox.Show("Namensfeld darf nicht leer sein.", "Fehler", MessageBoxButtons.OK);
            }
            else if(reservierungenDataGrid.SelectedCells[0].Value.ToString() != "---")
            {
                MessageBox.Show("Termin ist bereits reserviert", "Fehler", MessageBoxButtons.OK);
            }
            else
            {
                DataGridViewCell selectedCell = reservierungenDataGrid.SelectedCells[0];
                selectedCell.Value = nameTextbox.Text;
                ExecuteNonQuery($"INSERT INTO Hallenreservierungen VALUES({tagNumeric.Value},{selectedCell.RowIndex+10}, {selectedCell.ColumnIndex}, \"{nameTextbox.Text}\")");
            }

        }

        private void löschenButton_Click(object sender, EventArgs e)
        {
            DataGridViewCell selectedCell = reservierungenDataGrid.SelectedCells[0];
            if (selectedCell.Value.ToString() == "---")
            {
                MessageBox.Show("Termin nicht vergeben", "Fehler", MessageBoxButtons.OK);
            }
            else
            {
                ExecuteNonQuery($"DELETE FROM Hallenreservierungen WHERE Tag={tagNumeric.Value} AND Stunde={selectedCell.RowIndex+10} AND Platz={selectedCell.ColumnIndex}");
                selectedCell.Value = "---";
            }
        }
    }
}
