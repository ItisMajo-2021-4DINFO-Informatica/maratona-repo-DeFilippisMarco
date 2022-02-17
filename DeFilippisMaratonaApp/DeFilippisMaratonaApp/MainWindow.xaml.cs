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

namespace DeFilippisMaratonaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Maratone maratone;
        public MainWindow()
        {
            InitializeComponent();
            maratone = new Maratone();
            DgElencoMaratone.ItemsSource = maratone.elencoMaratone;
        }

        private void BtnLeggiDaFile_Click(object sender, RoutedEventArgs e)
        {
            maratone.Leggi();
            DgElencoMaratone.Items.Refresh();
        }
    }
}
