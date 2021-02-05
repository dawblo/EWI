using System;
using System.Windows;
using System.Data;
using System.Data.SqlClient;


namespace EWI
{
    /// <summary>
    /// Interaction logic for DataWindow.xaml
    /// </summary>
    public partial class DataWindow : Window
    {
        public string[] types { get; set; }
        public string[] przypisanie { get; set; }


        public DataWindow()
        {
            InitializeComponent();
            types = new string[] { "Komputer", "Laptop", "Monitor", "Telefon", "Stacja dokująca", "Kamery" };
            przypisanie = new string[] { "1", "0"};
            DataContext = this;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection log = new SqlConnection(@"Data Source=LAPTOPP; Initial Catalog=EWI;  Integrated Security=True;");
            {
                if (log.State == ConnectionState.Closed)
                    log.Open();
                String query = "INSERT INTO Sprzet(ID, Nazwa_ewidencyjna, Producent, Model, Data_zakupu, Typ, Przypisanie, Imie, Nazwisko, Stanowisko, Dział) " +
  "VALUES ((SELECT ISNULL(MAX(ID) + 1, 1) FROM Sprzet), @Nazwa_ewidencyjna, @Producent, @Model, @Data_zakupu, @Typ, @Przypisanie, @Imie, @Nazwisko, @Stanowisko, @Dział)"; //automatyczny nowy numer ID (SELECT ISNULL(MAX(ID) + 1, 1) FROM Sprzet)
                SqlCommand sqlCmd = new SqlCommand(query, log);
                sqlCmd.Parameters.AddWithValue("@Typ", txtTyp.Text);
                sqlCmd.Parameters.AddWithValue("@Nazwa_ewidencyjna", txtNazwa.Text);
                sqlCmd.Parameters.AddWithValue("@Producent", txtProducent.Text);
                sqlCmd.Parameters.AddWithValue("@Model", txtModel.Text);
                sqlCmd.Parameters.AddWithValue("@Data_zakupu", txtData_zakupu.Text);
                sqlCmd.Parameters.AddWithValue("@Przypisanie", txtPrzypisanie.Text);
                sqlCmd.Parameters.AddWithValue("@Imie", txtImie.Text);
                sqlCmd.Parameters.AddWithValue("@Nazwisko", txtNazwisko.Text);
                sqlCmd.Parameters.AddWithValue("@Stanowisko", txtStanowisko.Text);
                sqlCmd.Parameters.AddWithValue("@Dział", txtDział.Text);

                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 0)
                {


                    //Process.Start(Process.GetCurrentProcess().MainModule.FileName);
                   // Application.Current.Shutdown();

                    this.Close();
                    


                }
                else
                {
                    MessageBox.Show("Blad");
                }

                
            }

        }

        private void txtPrzypisanie_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
