﻿using System.Windows.Media;
using UiDesktopAppTest.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace UiDesktopAppTest.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            viewModel.PropertyChanged += ViewModel_PropertyChanged;

            InitializeComponent();
        }

        private void ViewModel_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Text":
                    this.btnClickMe.Background = new SolidColorBrush(Colors.White);
                    break;
            }
        }
    }
}
