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

namespace ProductPractic2
{
    /// <summary>
    /// Логика взаимодействия для WorkReportEF.xaml
    /// </summary>
    public partial class WorkReportEF : Page
    {
        PractisEntities pr = new PractisEntities();
        public WorkReportEF()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(IDPeople.Text, out int PeopleID) && Int32.TryParse(IDWorkInfo.Text, out int WorkID))
            {
                WorkReport workReport = new WorkReport()
                {
                    People_ID = PeopleID,
                    WorkInfo_ID = WorkID
                };
                pr.WorkReport.Add(workReport);
                pr.SaveChanges();
                WorkReportTable.ItemsSource = pr.WorkReport.ToList();
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (WorkReportTable.ItemsSource != null)
            {
                pr.WorkReport.Remove(WorkReportTable.SelectedItem as WorkReport);
                pr.SaveChanges();
                WorkReportTable.ItemsSource = pr.WorkReport.ToList();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (WorkReportTable.SelectedItem != null && Int32.TryParse(IDPeople.Text, out int PeopleID) && Int32.TryParse(IDWorkInfo.Text, out int WorkID))
            {
                var selected = WorkReportTable.SelectedItem as WorkReport;
                selected.People_ID = PeopleID;
                selected.WorkInfo_ID = WorkID;
                pr.SaveChanges();
                WorkReportTable.ItemsSource = pr.WorkReport.ToList();
            }
        }
    }
}
