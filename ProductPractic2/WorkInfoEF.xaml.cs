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
    /// Логика взаимодействия для WorkInfoEF.xaml
    /// </summary>
    public partial class WorkInfoEF : Page
    {
        PractisEntities pr = new PractisEntities();
        public WorkInfoEF()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WorkInfo work  = new WorkInfo()
            {
                WorkPost = Position.Text,
                DateStartOfWork = DateStart.Text,
                Salary = Salary.Text
            };
            pr.WorkInfo.Add(work);
            pr.SaveChanges();
            WorkInfoTable.ItemsSource = pr.WorkInfo.ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (WorkInfoTable.ItemsSource != null)
            {
                pr.WorkInfo.Remove(WorkInfoTable.SelectedItem as WorkInfo);
                pr.SaveChanges();
                WorkInfoTable.ItemsSource = pr.WorkInfo.ToList();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (WorkInfoTable.SelectedItem != null)
            {
                var selected = WorkInfoTable.SelectedItem as WorkInfo;
                selected.WorkPost = Position.Text;
                selected.DateStartOfWork = Salary.Text;
                selected.Salary = Salary.Text;
                pr.SaveChanges();
                WorkInfoTable.ItemsSource = pr.WorkInfo.ToList();
            }
        }

        private void ProjectTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WorkInfoTable.SelectedItem != null)
            {
                var selected = WorkInfoTable.SelectedItem as WorkInfo;
                Position.Text = selected.WorkPost;
                DateStart.Text = selected.DateStartOfWork;
                Salary.Text = selected.Salary;
            }
        }
    }
}
