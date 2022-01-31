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

namespace Video87
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void eRojo_Click(object sender, RoutedEventArgs e)
        {
            eRojo.Visibility = Visibility.Visible;
            eAmarillo.Visibility = Visibility.Hidden;
            eVerde.Visibility = Visibility.Hidden;


        }

        private void eAmarillo_Click(object sender, RoutedEventArgs e)
        {
            eRojo.Visibility = Visibility.Hidden;
            eAmarillo.Visibility = Visibility.Visible;
            eVerde.Visibility = Visibility.Hidden;
        }

        private void eVerde_Click(object sender, RoutedEventArgs e)
        {
            eRojo.Visibility = Visibility.Hidden;
            eAmarillo.Visibility = Visibility.Hidden;
            eVerde.Visibility = Visibility.Visible;
        }
    }
}
