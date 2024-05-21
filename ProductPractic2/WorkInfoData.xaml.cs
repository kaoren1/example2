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
    /// Логика взаимодействия для WorkInfoData.xaml
    /// </summary>
    public partial class WorkInfoData : Page
    {
        WorkInfoTableAdapter WorkInfoTableAdapter = new WorkInfoTableAdapter();
        public WorkInfoData()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WorkInfoTableAdapter.InsertQuery(Position.Text, DateStart.Text, Salary.Text);
            WorkInfoTable.ItemsSource = WorkInfoTableAdapter.GetData();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (WorkInfoTable.SelectedItem != null)
            {
                object id = (WorkInfoTable.SelectedItem as DataRowView).Row[0];
                WorkInfoTableAdapter.DeleteQuery(Convert.ToInt32(id));
                WorkInfoTable.ItemsSource = WorkInfoTableAdapter.GetData();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            object id = (WorkInfoTable.SelectedItem as DataRowView).Row[0];
            WorkInfoTableAdapter.UpdateQuery(Position.Text, DateStart.Text, Salary.Text, Convert.ToInt32(id));
            WorkInfoTable.ItemsSource = WorkInfoTableAdapter.GetData();
        }
    }
}
