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
    /// Логика взаимодействия для WorkReportWindow.xaml
    /// </summary>
    public partial class WorkReportWindow : Window
    {
        WorkReportTableAdapter workReportTableAdapter = new WorkReportTableAdapter();

        PractisEntities p = new PractisEntities();
            
        public WorkReportWindow()
        {
            InitializeComponent();
            this.Title = "Отчеты работников";
        }

        private void DataSet_Click(object sender, RoutedEventArgs e)
        {
            WorkReportData page = new WorkReportData();
            page.WorkReportTable.ItemsSource = null;
            page.WorkReportTable.ItemsSource = null;
            page.WorkReportTable.Items.Clear();
            page.WorkReportTable.ItemsSource = workReportTableAdapter.GetData();
            Frame.Content = page;
        }

        private void EF_Click(object sender, RoutedEventArgs e)
        {
            WorkReportEF page = new WorkReportEF();
            page.WorkReportTable.ItemsSource = null;
            page.WorkReportTable.Items.Clear();
            page.WorkReportTable.ItemsSource = p.WorkReport.ToList();
            Frame.Content = page;
        }
    }
}
