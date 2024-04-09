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
using System.Windows.Threading;
using wpfNTPExample.Class;

namespace wpfNTPExample
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeUI();
        }
        
        private DispatcherTimer timer = new DispatcherTimer();

        public void InitializeUI()
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            DateTime dtSystemTime = DateTime.Now;
            DateTime dtServerTime = NTPClient.GetNetworkTime();

            tbSystemTime.Text = dtSystemTime.ToString();
            tbServerTime.Text = dtServerTime.ToString();
        }
    }
}
