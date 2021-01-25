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
    /// Interaction logic for Data.xaml
    /// </summary>
    public partial class Data : Page
    {
        public Data()
        {
            InitializeComponent();
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataWindow win1 = new DataWindow();
            win1.Show();


        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {



            DataWindow win1 = new DataWindow();
            win1.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Odświeżanie//
            this.NavigationService.Refresh();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            EWI.EWIDataSet eWIbisDataSet = ((EWI.EWIDataSet)(this.FindResource("eWIDataSet")));
            // Załaduj dane do tabeli Sprzet. Możesz modyfikować ten kod w razie potrzeby.
            EWI.EWIDataSetTableAdapters.SprzetTableAdapter eWIbisDataSetSprzetTableAdapter = new EWI.EWIDataSetTableAdapters.SprzetTableAdapter();
            eWIbisDataSetSprzetTableAdapter.Fill(eWIbisDataSet.Sprzet);
            System.Windows.Data.CollectionViewSource sprzetViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("sprzetViewSource")));
            sprzetViewSource.View.MoveCurrentToFirst();
            
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

    }
}
