using PRAktika_itog.praktika2DataSetTableAdapters;
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

namespace PRAktika_itog
{
    public partial class benefitsPage : Page
    {
        int whog = 0;

        animalsTableAdapter animals = new animalsTableAdapter();
        AviaryTableAdapter Aviary = new AviaryTableAdapter();
        benefitsTableAdapter benefits = new benefitsTableAdapter();
        environmentTableAdapter environment = new environmentTableAdapter();
        postTableAdapter post = new postTableAdapter();
        rateTableAdapter rate = new rateTableAdapter();
        tiketTableAdapter tiket = new tiketTableAdapter();
        tillTableAdapter till = new tillTableAdapter();
        type_of_animalsTableAdapter type_of_Animals = new type_of_animalsTableAdapter();
        usersTableAdapter users = new usersTableAdapter();
        workersTableAdapter workers = new workersTableAdapter();
        public benefitsPage()
        {
            InitializeComponent();
            benefitsGrid.ItemsSource = benefits.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                benefits.InsertQuery(NameTbx.Text, NameTbx_Copy.Text);
                benefitsGrid.ItemsSource = benefits.GetData();
            }
            catch
            {
                MessageBox.Show("Бфли введены не верные данные");
            }

        }

        private void animalsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (whog != 1)
            {
                NameTbx.Text = (benefitsGrid.SelectedItem as DataRowView).Row[1].ToString();
                NameTbx_Copy.Text = (benefitsGrid.SelectedItem as DataRowView).Row[2].ToString();

                whog = 1;
            }
            else
            {
                whog = 0;
            }
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (benefitsGrid.SelectedItem as DataRowView).Row[0];
                benefits.DeleteQuery(Convert.ToInt32(id));

                benefitsGrid.ItemsSource = benefits.GetData();
            }
            catch
            {
                MessageBox.Show("выберете строку");
            }

        }

        private void Chang_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (benefitsGrid.SelectedItem as DataRowView).Row[0];
                benefits.UpdateQuery(NameTbx.Text, NameTbx_Copy.Text, Convert.ToInt32(id));

                benefitsGrid.ItemsSource = benefits.GetData();
            }
            catch
            {
                MessageBox.Show("Бфли введены не верные данные");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).PageFrame.Content = new Aviary();
        }

        private void to_users_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).PageFrame.Content = new usersPage();
        }
    }
}
