using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EWI
{
    public partial class Form1 : Form



    {
        public Form1()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOPP; Initial Catalog=EWI;  Integrated Security=True;");
            SqlCommand com = new SqlCommand("Select * from Sprzet", con);
            SqlDataAdapter d = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            PodgladWindow win3 = new PodgladWindow();
            win3.Show();
            win3.txtNazwa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            win3.txtProducent.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            win3.txtModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            win3.txtData_zakupu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.Refresh();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection log = new SqlConnection(@"Data Source=LAPTOPP; Initial Catalog=EWI;  Integrated Security=True;");
            {

                if (log.State == ConnectionState.Closed)
                    log.Open();
                String query = "DELETE from Sprzet where ID=@ID_delete";
                SqlCommand sqlCmd = new SqlCommand(query, log);
                sqlCmd.Parameters.AddWithValue("@ID_delete", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            }
            
            }

        private void button1_Click(object sender, EventArgs e)
        {
            DataWindow win = new DataWindow();
            win.ShowDialog();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOPP; Initial Catalog=EWI;  Integrated Security=True;");
            SqlCommand com = new SqlCommand("Select * from Sprzet", con);
            SqlDataAdapter d = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PodgladWindow win3 = new PodgladWindow();
            win3.Show();
            win3.txtNazwa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            win3.txtProducent.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            win3.txtModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            win3.txtData_zakupu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            this.Refresh();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            
            ModifyWindow win3 = new ModifyWindow();
            win3.txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            win3.txtNazwa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            win3.txtProducent.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            win3.txtModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            win3.txtData_zakupu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           
            win3.Show();
            this.Refresh();
            
        }
    }
}
