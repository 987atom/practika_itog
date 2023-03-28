using MahApps.Metro.Controls;
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
    public partial class tiketPage1 : Page
    {
        int whog = 0;
        int re = 0;
        int re1 = 0;

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
        public tiketPage1()
        {
            InitializeComponent();
            tiketGrid.ItemsSource = tiket.GetData();


            NameTbx.ItemsSource = rate.GetData();
            NameTbx.DisplayMemberPath = "id_rate";


            NameTbx_Copy.ItemsSource = benefits.GetData();
            NameTbx_Copy.DisplayMemberPath = "id_benefits";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tiket.InsertQuery(re, re1, NameTbx_Copy1.Text);
                tiketGrid.ItemsSource = tiket.GetData();
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
                NameTbx.SelectedItem = (tiketGrid.SelectedItem as DataRowView).Row[1];
                NameTbx_Copy.SelectedItem = (tiketGrid.SelectedItem as DataRowView).Row[2];
                NameTbx_Copy1.Text = (tiketGrid.SelectedItem as DataRowView).Row[3].ToString();

                whog = 1;
            }
            else
            {
                whog = 0;
            }
        }

        private void NameTbx_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (NameTbx.SelectedItem as DataRowView).Row[0];
            re = (int)cell;
        }

        private void NameTbx_Copy1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (NameTbx_Copy.SelectedItem as DataRowView).Row[0];
            re1 = (int)cell;
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (tiketGrid.SelectedItem as DataRowView).Row[0];
                tiket.DeleteQuery(Convert.ToInt32(id));

                tiketGrid.ItemsSource = tiket.GetData();
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
                object id = (tiketGrid.SelectedItem as DataRowView).Row[0];
                object cell = (NameTbx.SelectedItem as DataRowView).Row[0];
                int ccc = (int)cell;
                object celll = (NameTbx_Copy.SelectedItem as DataRowView).Row[1];
                int cccc = (int)cell;
                tiket.UpdateQuery(ccc, cccc, NameTbx_Copy1.Text, Convert.ToInt32(id));

                tiketGrid.ItemsSource = tiket.GetData();
            }
            catch
            {
                MessageBox.Show("Бфли введены не верные данные или произошел конфликт с таблицами");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).PageFrame.Content = new tillPage();
        }
    }
}