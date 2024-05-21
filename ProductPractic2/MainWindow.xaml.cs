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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void People_Click(object sender, RoutedEventArgs e)
        {
            PeopleWindow peopleWindow = new PeopleWindow();
            peopleWindow.Show();
        }

        private void WorkInfo_Click(object sender, RoutedEventArgs e)
        {
            WorkInfoWindow workInfoWindow = new WorkInfoWindow();
            workInfoWindow.Show();
        }

        private void WorkReport_Click(object sender, RoutedEventArgs e)
        {
            WorkReportWindow workReportWindow = new WorkReportWindow();
            workReportWindow.Show();
        }
    }
}
