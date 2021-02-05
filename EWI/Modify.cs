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
                String query = "UPDATE Sprzet SET Nazwa_ewidencyjna=@Nazwa_ewidencyjna, Producent=@Producent, Model=@Model, Data_zakupu=@Data_zakupu WHERE ID=@ID";
                SqlCommand sqlCmd = new SqlCommand(query, log);
                sqlCmd.Parameters.AddWithValue("@ID", box1.Text);
                sqlCmd.Parameters.AddWithValue("@Nazwa_ewidencyjna", box2.Text);
                sqlCmd.Parameters.AddWithValue("@Producent", box3.Text);
                sqlCmd.Parameters.AddWithValue("@Model", box4.Text);
                sqlCmd.Parameters.AddWithValue("@Data_zakupu", box5.Text);
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

        private void box1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
