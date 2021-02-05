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
    /// Interaction logic for ModifyWindow.xaml
    /// </summary>
    public partial class ModifyWindow : Window
    {
        public string[] przypisanie { get; set; }


        public ModifyWindow()
        {
            InitializeComponent();
            

            przypisanie = new string[] { "1", "0" };
            

           




        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection log = new SqlConnection(@"Data Source=LAPTOPP; Initial Catalog=EWI;  Integrated Security=True;");
            {
                if (log.State == ConnectionState.Closed)
                    log.Open();
                String query = "UPDATE Sprzet SET Nazwa_ewidencyjna=@Nazwa_ewidencyjna, Producent=@Producent, Model=@Model, Data_zakupu=@Data_zakupu, Przypisanie=@Przypisanie," +
                    " Imie-@Imie, Nazwisko=@Nazwisko, Stanowisko=@Stanowisko, Dzi WHERE ID=@ID"; 
                SqlCommand sqlCmd = new SqlCommand(query, log);
                sqlCmd.Parameters.AddWithValue("@ID", txtID1.Text);
                sqlCmd.Parameters.AddWithValue("@Nazwa_ewidencyjna", txtNazwa1.Text);
                sqlCmd.Parameters.AddWithValue("@Producent", txtProducent1.Text);
                sqlCmd.Parameters.AddWithValue("@Model", txtModel1.Text);
                sqlCmd.Parameters.AddWithValue("@Data_zakupu", txtData_zakupu1.Text);
                sqlCmd.Parameters.AddWithValue("@Przypisanie", txtPrzypisanie1.Text);
                sqlCmd.Parameters.AddWithValue("@Imie", txtImie1.Text);
                sqlCmd.Parameters.AddWithValue("@Nazwisko", txtNazwisko1.Text);
                sqlCmd.Parameters.AddWithValue("@Stanowisko", txtStanowisko1.Text);
                sqlCmd.Parameters.AddWithValue("@Dział", txtDział1.Text);
                int count = 0;
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

       
    }
}
