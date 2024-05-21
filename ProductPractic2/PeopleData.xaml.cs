using ProductPractic2.PractisDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace ProductPractic2
{
    /// <summary>
    /// Логика взаимодействия для PeopleData.xaml
    /// </summary>
    public partial class PeopleData : Page
    {
        PeopleTableAdapter peopleTableAdapter = new PeopleTableAdapter();
        public PeopleData()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            peopleTableAdapter.InsertQuery(Surname.Text, Name.Text, MiddleName.Text);
            PeopleTable.ItemsSource = peopleTableAdapter.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (PeopleTable.SelectedItem != null)
            {
                object id = (PeopleTable.SelectedItem as DataRowView).Row[0];
                peopleTableAdapter.DeleteQuery(Convert.ToInt32(id));
                PeopleTable.ItemsSource = peopleTableAdapter.GetData();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            object id = (PeopleTable.SelectedItem as DataRowView).Row[0];
            peopleTableAdapter.UpdateQuery(Surname.Text,Name.Text, MiddleName.Text, Convert.ToInt32(id));
            PeopleTable.ItemsSource = peopleTableAdapter.GetData();
        }
    }
}
