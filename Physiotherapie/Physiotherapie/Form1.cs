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

namespace Physiotherapie
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

            FillTagesplan(datumDatePicker.Value.Day);
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

        void FillTagesplan(int day)
        {
            MySqlDataReader reader = ExecuteQuery("SELECT * FROM PT_Therapieteam");
            while (reader.Read())
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = reader["name"].ToString();
                col.Width = 110;
                tagesplanDataGrid.Columns.Add(col);
            }
            reader.Close();

            for(float i = 8; i<= 18; i += 0.5f)
            {
                tagesplanDataGrid.Rows.Add(FloatToTime(i));
            }

            reader = ExecuteQuery($"SELECT * FROM PT_Arbeitszeiten WHERE tag = {day}");

            tagesplanDataGrid.Rows[(10 - 8) * 2].DefaultCellStyle.BackColor = Color.DarkGray;
            tagesplanDataGrid.Rows[(13 - 8) * 2].DefaultCellStyle.BackColor = Color.DarkGray;
            tagesplanDataGrid.Rows[(int)((13.5 - 8) * 2)].DefaultCellStyle.BackColor = Color.DarkGray;
        }

        string FloatToTime(float time)
        {
            TimeSpan t = TimeSpan.FromHours(time);
            return t.ToString("hh':'mm");
        }

    }
}
