﻿using System;
using System.Windows;
using System.Windows.Controls;


namespace Actividad4_Calculadora
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            numerostextBlock.Text +=(sender as Button).Tag.ToString();
        }
    }
}
