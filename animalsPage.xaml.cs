using PRAktika_itog.praktika2DataSetTableAdapters;
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

using PRAktika_itog.praktika2DataSetTableAdapters;
using System.Data;

namespace PRAktika_itog
{
    public partial class animalsPage : Page
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
        public animalsPage()
        {
            InitializeComponent();

            animalsGrid.ItemsSource = animals.GetData();


            NameTbx_Copy.ItemsSource = environment.GetData();
            NameTbx_Copy.DisplayMemberPath = "id_environment";


            NameTbx_Copy1.ItemsSource = type_of_Animals.GetData();
            NameTbx_Copy1.DisplayMemberPath = "id_type_of_animals";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                animals.InsertQuery(NameTbx.Text, re, re1);
                animalsGrid.ItemsSource = animals.GetData();
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
                NameTbx.Text = (animalsGrid.SelectedItem as DataRowView).Row[1].ToString();
                NameTbx_Copy.SelectedItem = (animalsGrid.SelectedItem as DataRowView).Row[2];
                NameTbx_Copy1.SelectedItem = (animalsGrid.SelectedItem as DataRowView).Row[3];

                whog = 1;
            }
            else
            {
                whog = 0;
            }
        }

        private void NameTbx_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (NameTbx_Copy.SelectedItem as DataRowView).Row[0];
            re = (int)cell;
        }

        private void NameTbx_Copy1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (NameTbx_Copy1.SelectedItem as DataRowView).Row[0];
            re1 = (int)cell;
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (animalsGrid.SelectedItem as DataRowView).Row[0];
                animals.DeleteQuery(Convert.ToInt32(id));

                animalsGrid.ItemsSource = animals.GetData();
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
                object id = (animalsGrid.SelectedItem as DataRowView).Row[0];
                object cell = (NameTbx_Copy.SelectedItem as DataRowView).Row[0];
                int ccc = (int)cell;
                object celll = (NameTbx_Copy1.SelectedItem as DataRowView).Row[0];
                int cccc = (int)cell;
                animals.UpdateQuery(NameTbx.Text, cccc, ccc, Convert.ToInt32(id));

                animalsGrid.ItemsSource = animals.GetData();
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