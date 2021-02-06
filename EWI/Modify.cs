using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Data.SqlClient;

namespace EWI
{
    public partial class Modify : Form
    {

        
        public Modify()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection log = new SqlConnection(@"Data Source=LAPTOPP; Initial Catalog=EWI;  Integrated Security=True;");
            {
                if (log.State == ConnectionState.Closed)
                    log.Open();
                String query = "UPDATE Sprzet SET Typ=@Typ, Nazwa_ewidencyjna=@Nazwa_ewidencyjna, Producent=@Producent, Model=@Model," +
                    " Data_zakupu=@Data_zakupu, Przypisanie=@Przypisanie, Imie=@Imie, Nazwisko=@Nazwisko, Stanowisko=@Stanowisko, Dział=@Dział WHERE ID=@ID";
                SqlCommand sqlCmd = new SqlCommand(query, log);
                sqlCmd.Parameters.AddWithValue("@ID", box1.Text);
                sqlCmd.Parameters.AddWithValue("@Typ", box2.Text);
                sqlCmd.Parameters.AddWithValue("@Nazwa_ewidencyjna", box3.Text);
                sqlCmd.Parameters.AddWithValue("@Producent", box4.Text);
                sqlCmd.Parameters.AddWithValue("@Model", box5.Text);
                sqlCmd.Parameters.AddWithValue("@Data_zakupu", box6.Text);
                sqlCmd.Parameters.AddWithValue("@Przypisanie", box7.Text);
                sqlCmd.Parameters.AddWithValue("@Imie", box8.Text);
                sqlCmd.Parameters.AddWithValue("@Nazwisko", box9.Text);
                sqlCmd.Parameters.AddWithValue("@Stanowisko", box10.Text);
                sqlCmd.Parameters.AddWithValue("@Dział", box11.Text);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 0)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                }

            }
        }

        
    }
}
