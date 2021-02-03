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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EWI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            Start p1 = new Start();
            
            FrameStart.Navigate(p1);




        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            {

                Start p1 = new Start();
                FrameStart.Navigate(p1);

            }
        }
        public void Button2_Click(object sender, RoutedEventArgs e)
        {

            {

                FrameStart.Content = new Wpf.PieChart.DoughnutChartExample();
                

            }
        }
        private void Personalize_Type_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Properties["Type"] = 1;
            FrameStart.Source = new Uri("Startframe.xaml", UriKind.Relative);
        }




        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            {
               
                Form1 form = new Form1();
                form.ShowDialog();


            }
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            {
                MessageBox.Show("Pomoc");
            }
        }

       
        


    }
}
