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
                SqlCommand sqlCmd = new SqlCommand("select count(1) from Sprzet where Typ='Komputer'", log);
                double komputer = (Int32)sqlCmd.ExecuteScalar();
                SqlCommand sqlCmd1 = new SqlCommand("select count(1) from Sprzet where Typ='Monitor'", log);
                double monitor = (Int32)sqlCmd1.ExecuteScalar();
                SqlCommand sqlCmd2 = new SqlCommand("select count(1) from Sprzet where Typ='Laptop'", log);
                double laptop = (Int32)sqlCmd2.ExecuteScalar();
                SqlCommand sqlCmd3 = new SqlCommand("select count(1) from Sprzet where Typ='Telefon'", log);
                double telefon = (Int32)sqlCmd3.ExecuteScalar();
                SqlCommand sqlCmd4 = new SqlCommand("select count(1) from Sprzet where Typ='Stacja dokująca'", log);
                double stacja_dokujaca = (Int32)sqlCmd4.ExecuteScalar();
                SqlCommand sqlCmd5 = new SqlCommand("select count(1) from Sprzet where Typ='Kamery'", log);
                double kamery = (Int32)sqlCmd5.ExecuteScalar();
                SqlCommand sqlCmd6 = new SqlCommand("select count(1) from Sprzet where Przypisanie=1", log);
                double przypisanie = (Int32)sqlCmd6.ExecuteScalar();
                SqlCommand sqlCmd7 = new SqlCommand("select count(1) from Sprzet where Przypisanie=0", log);
                double przypisanie1 = (Int32)sqlCmd7.ExecuteScalar();
                log.Close();




                SeriesCollection  = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Komputer",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(komputer) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Laptop",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(laptop) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Monitor",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(monitor) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Telefon",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(telefon) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Stacja dokująca",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(stacja_dokujaca) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Kamery",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(kamery) },
                    DataLabels = true
                }


            };

                SeriesCollection2 = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Zajęty",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(przypisanie) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "Wolny",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(przypisanie1) },
                    DataLabels = true
                },
                


            };



            }
            
            
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public SeriesCollection SeriesCollection2 { get; set; }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Refresh();
            this.NavigationService.Navigate(new Uri("Data.xaml", UriKind.Relative));

            

        }
       
        
        
        
       

    }
}





