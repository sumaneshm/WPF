﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicBindingStudy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void myCodeslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            myTextBlock.FontSize = myCodeslider.Value;
           // myLabel.Content = "Code is setting the FontSize to : " + myCodeslider.Value;
        }
    }
}