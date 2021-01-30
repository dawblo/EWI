using System;
using System.Linq;
using System.Windows;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Data;
using System.Data.SqlClient;

namespace Wpf.PieChart
{
    public partial class DoughnutChartExample
    {

        public DoughnutChartExample()
        {
            InitializeComponent();

            SqlConnection log = new SqlConnection(@"Data Source=LAPTOPP; Initial Catalog=EWI;  Integrated Security=True;");
            {
                if (log.State == ConnectionState.Closed)
                    log.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlCmd = new SqlDataAdapter("select count(1) from Sprzet where Typ='Monitor'", log);

                sqlCmd.Fill(dt);

                log.Close();

                

                






                SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Komputer",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(2) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Laptop",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(6) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Monitor",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(11) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Telefon",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(3) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Stacja dokująca",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(4) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Kamery",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(1) },
                    DataLabels = true
                }

            };


                DataContext = this;
            }
        }

        public SeriesCollection SeriesCollection { get; set; }

    }
}





