using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LangApp
{
    public class General
    {
        static string connectingString = "Server=localhost\\sqlexpress;Database=LangDB;integrated security=True;encrypt=True;trustservercertificate=True;";

        public static void CreateChart(Chart chart, string query, SqlParameter[] parameters,
            SeriesChartType chartType, string seriesName, string chartArea)
        {
            using (SqlConnection con = new SqlConnection(connectingString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
                if (parameters != null)
                {
                    dataAdapter.SelectCommand.Parameters.AddRange(parameters);
                }

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                chart.DataSource = dt;
                chart.Series.Clear();

                Series series = new Series(seriesName);
                series.XValueMember = dt.Columns[0].ColumnName;
                series.YValueMembers = dt.Columns[1].ColumnName;
                series.ChartType = chartType;
                chart.Series.Add(series);
                chart.DataBind();

                CustomizeChart(series, chartType, chartArea);
            }
        }
        private static void CustomizeChart(Series serie, SeriesChartType chartType, string chartArea)
        {
            switch (chartType)
            {
                case SeriesChartType.Pie:
                    foreach (DataPoint point in serie.Points)
                    {
                        point.Label = string.Format("{0} ({1:P})", point.AxisLabel,
                            point.YValues[0] / serie.Points.Sum(x => x.YValues[0]));
                    }
                    serie.IsValueShownAsLabel = true;
                    serie.LabelForeColor = Color.Yellow;
                    serie.Color = Color.Navy;
                    serie.ChartArea = chartArea;
                    break;

                case SeriesChartType.Column:
                    serie.IsValueShownAsLabel = true;
                    break;
            }
        }

        public static string ConventIntToPartsOfSpeech(int partsOfSpeechID)
        {
            if (partsOfSpeechID == 1)
            {
                return "Noun";
            }
            else if (partsOfSpeechID == 2)
            {
                return "Verb";
            }
            else if (partsOfSpeechID == 3)
            {
                return "Adjective";
            }
            else if (partsOfSpeechID == 4)
            {
                return "Phrase or Idiom";
            }
            else if (partsOfSpeechID == 5)
            {
                return "None";
            }
            else if (partsOfSpeechID == 6)
            {
                return "Adverb";
            }
            else if (partsOfSpeechID == 7)
            {
                return "Conjunction";
            }
            else if (partsOfSpeechID == 8)
            {
                return "Sentence";
            }            
            else
            {
                return "Unknown Parts of speech";
            }
        }
        public static bool isNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void ComboBoxProps(ComboBox cmb, string name, string ID)
        {
            cmb.DisplayMember = name;
            cmb.ValueMember = ID;
            cmb.SelectedIndex = -1;
        }
        public static string ConventIntToMonth(int month)
        {
            if (month == 1)
            {
                return "January";
            }
            else if (month == 2)
            {
                return "February";
            }
            else if (month == 3)
            {
                return "March";
            }
            else if (month == 4)
            {
                return "April";
            }
            else if (month == 5)
            {
                return "May";
            }
            else if (month == 6)
            {
                return "June";
            }
            else if (month == 7)
            {
                return "July";
            }
            else if (month == 8)
            {
                return "August";
            }
            else if (month == 9)
            {
                return "September";
            }
            else if (month == 10)
            {
                return "October";
            }
            else if (month == 11)
            {
                return "November";
            }
            else if (month == 12)
            {
                return "December";
            }
            else
            {
                return "Unknown month";
            }
        }
        public static string ConventEngToGerman(string partOfSpeech)
        {
            if (partOfSpeech == "Noun")
            {
                return "Nomen";
            }
            else if (partOfSpeech == "Verb")
            {
                return "Verben";
            }
            else if (partOfSpeech == "Adjective")
            {
                return "Adjektiven";
            }
            else if (partOfSpeech == "None")
            {
                return "Kein Teil der Rede";
            }
            else if (partOfSpeech == "Phrase or Idiom")
            {
                return "Phrasen or Idioms";
            }
            else if (partOfSpeech == "Adverb")
            {
                return "Adverben";
            }
            else if (partOfSpeech == "Conjunction")
            {
                return "Konjunktionen";
            }
            else if (partOfSpeech == "Sentence")
            {
                return "Sätze";
            }
            else
            {
                return "Unbekannter Teil der Rede!";
            }
        }
        public static string ConventIntToMonthGerman(int month)
        {
            if (month == 1)
            {
                return "Januar";
            }
            else if (month == 2)
            {
                return "Februar";
            }
            else if (month == 3)
            {
                return "März";
            }
            else if (month == 4)
            {
                return "April";
            }
            else if (month == 5)
            {
                return "Mai";
            }
            else if (month == 6)
            {
                return "Juni";
            }
            else if (month == 7)
            {
                return "Juli";
            }
            else if (month == 8)
            {
                return "August";
            }
            else if (month == 9)
            {
                return "September";
            }
            else if (month == 10)
            {
                return "Oktober";
            }
            else if (month == 11)
            {
                return "November";
            }
            else if (month == 12)
            {
                return "Dezember";
            }
            else
            {
                return "Unbekannter Monat";
            }
        }

        public static string ConventIntToMonthRussian(int month)
        {
            if (month == 1)
            {
                return "Январь";
            }
            else if (month == 2)
            {
                return "Фeвраль";
            }
            else if (month == 3)
            {
                return "Марта";
            }
            else if (month == 4)
            {
                return "Апрель";
            }
            else if (month == 5)
            {
                return "Maй";
            }
            else if (month == 6)
            {
                return "Июнь";
            }
            else if (month == 7)
            {
                return "Июль";
            }
            else if (month == 8)
            {
                return "Август";
            }
            else if (month == 9)
            {
                return "Сентябрь";
            }
            else if (month == 10)
            {
                return "Октябрь";
            }
            else if (month == 11)
            {
                return "Ноябрь";
            }
            else if (month == 12)
            {
                return "Декабрь";
            }
            else
            {
                return "Такова месяца нету";
            }
        }
    }
}
