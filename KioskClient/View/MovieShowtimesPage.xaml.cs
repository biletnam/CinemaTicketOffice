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
using DataAccess;
using DataAccess.Model;
using DataAccess.Repository;
using KioskClient.Properties;
using KioskClient.ViewModel;

namespace KioskClient.View
{
    public partial class MovieShowtimesPage
    {
        private readonly MovieShowtimesPageViewModel viewModel;

        public MovieShowtimesPage(Movie movie)
        {
            InitializeComponent();

            var connectionString = ConnectionStringBuilder.Build(
                Settings.Default.server,
                Settings.Default.database,
                Settings.Default.user,
                Settings.Default.password);

            var repository = new ShowtimeRepository(connectionString);

            viewModel = new MovieShowtimesPageViewModel(this, repository, movie);
            DataContext = viewModel;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.GoBack();
        }
    }
}