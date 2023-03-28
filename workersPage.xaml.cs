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
    public partial class workersPage : Page
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
        public workersPage()
        {
            InitializeComponent();
            workersGrid.ItemsSource = workers.GetData();


            NameTbx.ItemsSource = post.GetData();
            NameTbx.DisplayMemberPath = "id_post";

            NameTbx_Copy3.ItemsSource = users.GetData();
            NameTbx_Copy3.DisplayMemberPath = "id_users";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                workers.InsertQuery(re, NameTbx_Copy.Text, NameTbx_Copy1.Text, NameTbx_Copy2.Text, re1);
                workersGrid.ItemsSource = workers.GetData();
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
                NameTbx.SelectedItem = (workersGrid.SelectedItem as DataRowView).Row[1];
                NameTbx_Copy.Text = (workersGrid.SelectedItem as DataRowView).Row[2].ToString();
                NameTbx_Copy1.Text = (workersGrid.SelectedItem as DataRowView).Row[3].ToString();
                NameTbx_Copy2.Text = (workersGrid.SelectedItem as DataRowView).Row[4].ToString();
                NameTbx_Copy3.SelectedItem = (workersGrid.SelectedItem as DataRowView).Row[5];

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
        private void NameTbx_Copy3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (NameTbx_Copy3.SelectedItem as DataRowView).Row[0];
            re1 = (int)cell;
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (workersGrid.SelectedItem as DataRowView).Row[0];
                workers.DeleteQuery(Convert.ToInt32(id));

                workersGrid.ItemsSource = workers.GetData();
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
                object id = (workersGrid.SelectedItem as DataRowView).Row[0];
                object cell = (NameTbx.SelectedItem as DataRowView).Row[0];
                int ccc = (int)cell;
                object celll = (NameTbx_Copy3.SelectedItem as DataRowView).Row[0];
                int cccc = (int)cell;
                workers.UpdateQuery(ccc, NameTbx_Copy.Text, NameTbx_Copy1.Text, NameTbx_Copy2.Text, cccc, Convert.ToInt32(id));

                workersGrid.ItemsSource = workers.GetData();
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
    }
}