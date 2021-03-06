﻿using PeopleViewer.Presentation;
using PersonRepository.Caching;
using PersonRepository.CSV;
using PersonRepository.Service;
using System.Windows;

namespace PeopleViewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Application.Current.MainWindow = new MainWindow(new PeopleViewModel(new CachingRepository(new ServiceRepository())));

            Application.Current.MainWindow.Show();
        }
    }
}
