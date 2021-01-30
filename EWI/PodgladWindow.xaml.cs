using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace EWI
{
    /// <summary>
    /// Interaction logic for PodgladWindow.xaml
    /// </summary>
    public partial class PodgladWindow : Window
    {
        public PodgladWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection log = new SqlConnection(@"Data Source=LAPTOPP; Initial Catalog=EWI;  Integrated Security=True;");
            {
                if (log.State == ConnectionState.Closed)
                    log.Open();
                String query = "INSERT INTO Sprzet(ID, Nazwa_ewidencyjna, Producent, Model, Data_zakupu) " +
  "VALUES ((SELECT ISNULL(MAX(ID) + 1, 1) FROM Sprzet), @Nazwa_ewidencyjna, @Producent, @Model, @Data_zakupu)"; //automatyczny nowy numer ID (SELECT ISNULL(MAX(ID) + 1, 1) FROM Sprzet)
                SqlCommand sqlCmd = new SqlCommand(query, log);
                sqlCmd.Parameters.AddWithValue("@Nazwa_ewidencyjna", txtNazwa.Text);
                sqlCmd.Parameters.AddWithValue("@Producent", txtProducent.Text);
                sqlCmd.Parameters.AddWithValue("@Model", txtModel.Text);
                sqlCmd.Parameters.AddWithValue("@Data_zakupu", txtData_zakupu.Text);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Blad");
                }

            }
        }

        private void txtNazwa_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
