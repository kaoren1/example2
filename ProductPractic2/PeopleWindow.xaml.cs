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
using ProductPractic2.PractisDataSetTableAdapters;

namespace ProductPractic2
{
    /// <summary>
    /// Логика взаимодействия для PeopleWindow.xaml
    /// </summary>
    public partial class PeopleWindow : Window
    {
        PeopleTableAdapter PeopleTableAdapter = new PeopleTableAdapter();

        PractisEntities p = new PractisEntities();
        
        public PeopleWindow()
        {
            InitializeComponent();
            this.Title = "Работники";
        }

        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            PeopleData page = new PeopleData();
            page.PeopleTable.ItemsSource = null;
            page.PeopleTable.Items.Clear();
            page.PeopleTable.ItemsSource = PeopleTableAdapter.GetData();
            Frame.Content = page;
        }

        private void EF_Click(object sender, RoutedEventArgs e)
        {
            PeopleEF page = new PeopleEF();
            page.PeopleTable.ItemsSource = null;
            page.PeopleTable.Items.Clear();
            page.PeopleTable.ItemsSource = p.People.ToList();
            Frame.Content = page;
        }

    }
}
