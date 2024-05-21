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
    /// Логика взаимодействия для PeopleEF.xaml
    /// </summary>
    public partial class PeopleEF : Page
    {
        PractisEntities pr = new PractisEntities();
        public PeopleEF()
        {
            InitializeComponent();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            People people = new People()
            {
                NamePeople = Name.Text,
                SurnamePeople = Surname.Text,
                MiddleNamePeople = MiddleName.Text,
            };
            pr.People.Add(people);
            pr.SaveChanges();
            PeopleTable.ItemsSource = pr.People.ToList();

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (PeopleTable.ItemsSource != null)
            {
                pr.People.Remove(PeopleTable.SelectedItem as People);
                pr.SaveChanges();
                PeopleTable.ItemsSource = pr.People.ToList();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (PeopleTable.SelectedItem != null)
            {
                var selected = PeopleTable.SelectedItem as People;
                selected.NamePeople = Name.Text;
                selected.SurnamePeople = Surname.Text;
                selected.MiddleNamePeople = MiddleName.Text;
                pr.SaveChanges();
                PeopleTable.ItemsSource = pr.People.ToList();
            }
        }
    }
}
