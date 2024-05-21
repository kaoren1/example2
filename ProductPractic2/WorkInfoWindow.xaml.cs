using ProductPractic2.PractisDataSetTableAdapters;
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

namespace ProductPractic2
{
    /// <summary>
    /// Логика взаимодействия для WorkInfoWindow.xaml
    /// </summary>
    public partial class WorkInfoWindow : Window
    {
        WorkInfoTableAdapter workInfoTableAdapter = new WorkInfoTableAdapter();

        PractisEntities p = new PractisEntities();
        public WorkInfoWindow()
        {
            InitializeComponent();
            this.Title = "Отчеты";
        }

        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            WorkInfoData page = new WorkInfoData();
            page.WorkInfoTable.ItemsSource = null;
            page.WorkInfoTable.Items.Clear();
            page.WorkInfoTable.ItemsSource = workInfoTableAdapter.GetData();
            Frame.Content = page;
        }

        private void EF_Click(object sender, RoutedEventArgs e)
        {
            WorkInfoEF page = new WorkInfoEF();
            page.WorkInfoTable.ItemsSource = null;
            page.WorkInfoTable.Items.Clear();
            page.WorkInfoTable.ItemsSource = p.WorkInfo.ToList();
            Frame.Content = page;
        }
    }
}
