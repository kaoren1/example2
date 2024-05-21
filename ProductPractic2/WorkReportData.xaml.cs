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
    /// Логика взаимодействия для WorkReportData.xaml
    /// </summary>
    public partial class WorkReportData : Page
    {
        WorkReportTableAdapter workReportTableAdapter = new WorkReportTableAdapter();
        public WorkReportData()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(IDPeople.Text, out int PeopleID) && Int32.TryParse(IDWorkInfo.Text, out int WorkID))
            {
                workReportTableAdapter.Insert1(PeopleID, WorkID);
                WorkReportTable.ItemsSource = workReportTableAdapter.GetData();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (WorkReportTable.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)WorkReportTable.SelectedItem;
                if (selectedRow != null && selectedRow.Row != null)
                {
                    int id = (int)selectedRow.Row[0];
                    workReportTableAdapter.DeleteQuery(id);
                    WorkReportTable.ItemsSource = workReportTableAdapter.GetData();
                }
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (WorkReportTable.SelectedItem != null)
            {
                object id = (WorkReportTable.SelectedItem as DataRowView).Row[0];
                if (Int32.TryParse(IDPeople.Text, out int PeopleID) && Int32.TryParse(IDWorkInfo.Text, out int WorkID))
                {
                    workReportTableAdapter.UpdateQuery(PeopleID, WorkID, Convert.ToInt32(id));
                    WorkReportTable.ItemsSource = workReportTableAdapter.GetData();
                }
            }
        }
    }
}
