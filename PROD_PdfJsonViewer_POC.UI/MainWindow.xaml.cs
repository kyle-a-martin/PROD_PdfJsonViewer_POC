﻿using System.Windows;
using PROD_PdfJsonViewer_POC.UI.ViewModel;

namespace PROD_PdfJsonViewer_POC.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(this);
        }
    }
}