﻿using System;
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
    public partial class Aviary : Page
    {
        int whog = 0;
        int re = 0;
        int re1 = 0;

        animalsTableAdapter animals = new animalsTableAdapter();
        AviaryTableAdapter aviarys = new AviaryTableAdapter();
        benefitsTableAdapter benefits = new benefitsTableAdapter();
        environmentTableAdapter environment = new environmentTableAdapter();
        postTableAdapter post = new postTableAdapter();
        rateTableAdapter rate = new rateTableAdapter();
        tiketTableAdapter tiket = new tiketTableAdapter();
        tillTableAdapter till = new tillTableAdapter();
        type_of_animalsTableAdapter type_of_Animals = new type_of_animalsTableAdapter();
        usersTableAdapter users = new usersTableAdapter();
        workersTableAdapter workers = new workersTableAdapter();
        public Aviary()
        {
            InitializeComponent();
            AviaryGrid.ItemsSource = aviarys.GetData();


            NameTbx_Copy.ItemsSource = workers.GetData();
            NameTbx_Copy.DisplayMemberPath = "workers_id";


            NameTbx_Copy1.ItemsSource = aviarys.GetData();
            NameTbx_Copy1.DisplayMemberPath = "id_animal";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                aviarys.InsertQuery(re, re1);
                AviaryGrid.ItemsSource = aviarys.GetData();
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
                NameTbx_Copy.SelectedItem = (AviaryGrid.SelectedItem as DataRowView).Row[1];
                NameTbx_Copy1.SelectedItem = (AviaryGrid.SelectedItem as DataRowView).Row[2];

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
            object cell = (NameTbx_Copy1.SelectedItem as DataRowView).Row[2];
            re1 = (int)cell;
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (AviaryGrid.SelectedItem as DataRowView).Row[0];
                aviarys.DeleteQuery(Convert.ToInt32(id));

                AviaryGrid.ItemsSource = aviarys.GetData();
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
                object id = (AviaryGrid.SelectedItem as DataRowView).Row[0];
                object cell = (NameTbx_Copy.SelectedItem as DataRowView).Row[0];
                int ccc = (int)cell;
                object celll = (NameTbx_Copy1.SelectedItem as DataRowView).Row[0];
                int cccc = (int)cell;
                aviarys.UpdateQuery(cccc, ccc, Convert.ToInt32(id));

                AviaryGrid.ItemsSource = aviarys.GetData();
            }
            catch
            {
                MessageBox.Show("Бфли введены не верные данные");
            }

        }

        private void to_animals_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).PageFrame.Content = new animalsPage();
        }

        private void to_benefits_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).PageFrame.Content = new benefitsPage();
        }
    }
}
