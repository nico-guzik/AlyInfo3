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

namespace Museum
{
    public partial class Form1 : Form
    {
        MySqlConnection DatenbankVerbindung = new MySqlConnection();

        Color[] colors = new Color[] {Color.LightGreen, Color.LightGreen, Color.Orange, Color.Orange, Color.Red};
        NumericUpDown[] numerics;
        public Form1()
        {
            InitializeComponent();
            DatenbankVerbindung.ConnectionString = "Data Source=srlehre01.ls.haw-hamburg.de;"
                + "port=3306; SslMode=none;"
                + "initial catalog=Informatik3Smn; uid=M_2403249; pwd=M_2403249";
            DatenbankVerbindung.Open();

            numerics = new NumericUpDown[] { Time10Numeric, Time12Numeric, Time15Numeric, Time18Numeric };
            MySqlDataReader day1Reader = GetDayData(1);
            FillForm(day1Reader);
            day1Reader.Close();
        }

        void OnDayChange(object sender, EventArgs e)
        {
            Reset();
            MySqlDataReader reader = GetDayData(Decimal.ToInt32(DayNumeric.Value));
            FillForm(reader);
            reader.Close();
        }
        MySqlDataReader GetDayData(int day)
        {
            MySqlCommand abfrage = new MySqlCommand();
            abfrage.Connection = DatenbankVerbindung;
            abfrage.CommandText = $"SELECT id, tag, zeit, person FROM Museum WHERE TAG = {day}";
            MySqlDataReader reader = abfrage.ExecuteReader();
            return reader;
        }

        void FillForm(MySqlDataReader reader)
        {
            while (reader.Read())
            {
                switch (reader["ZEIT"])
                {
                    case 10:
                        Time10Numeric.Value++;
                        Visitors10Label.Text += (Visitors10Label.Text == "") ? reader["Person"].ToString() : ", " + reader["Person"].ToString(); 
                        break;
                    case 12:
                        Time12Numeric.Value++;
                        Visitors12Label.Text += (Visitors12Label.Text == "") ? reader["Person"].ToString() : ", " + reader["Person"].ToString();
                        break;
                    case 15:
                        Time15Numeric.Value++;
                        Visitors15Label.Text += (Visitors15Label.Text == "") ? reader["Person"].ToString() : ", " + reader["Person"].ToString();
                        break;
                    case 18:
                        Time18Numeric.Value++;
                        Visitors18Label.Text += (Visitors18Label.Text == "") ? reader["Person"].ToString() : ", " + reader["Person"].ToString();
                        break;
                    default:
                        Console.WriteLine($"Something went wrong. Time has a value of {reader["ZEIT"]}");
                        break;
                }
            }
            SetNumericBackground();
        }
        void SetNumericBackground()
        {
            foreach (NumericUpDown num in numerics)
            {
                num.BackColor = colors[Decimal.ToInt32(num.Value)];
            }
        }

        void Reset()
        {
            foreach(NumericUpDown num in numerics)
            {
                num.Value = 0;
            }

            Visitors10Label.Text = "";
            Visitors12Label.Text = "";
            Visitors15Label.Text = "";
            Visitors18Label.Text = "";
        }

    }
}
