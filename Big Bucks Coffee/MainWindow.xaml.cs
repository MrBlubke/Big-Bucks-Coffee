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

namespace Big_Bucks_Coffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int aantalkeer = 3;
            Content = ShowMyControl(aantalkeer);
        }

        private StackPanel ShowMyControl(int aantalkeer)
        {
            var stackPanel = new StackPanel { Orientation = Orientation.Horizontal };
            for (int i = 0; i < aantalkeer; i++)
            {
                stackPanel.Children.Add(new UserControl1());
            }
            return stackPanel;
        }
    }
}