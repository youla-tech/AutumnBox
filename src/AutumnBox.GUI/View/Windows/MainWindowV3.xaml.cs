﻿using AutumnBox.GUI.Services;
using AutumnBox.GUI.Services.Impl.OS;
using AutumnBox.GUI.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace AutumnBox.GUI.View.Windows
{
    /// <summary>
    /// MainWindowV3.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindowV3
    {
        public MainWindowV3()
        {
            InitializeComponent();
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            this.GetComponent<INotificationManager>().Token = "mainv3";
            NativeMethods.SetForegroundWindow(Process.GetCurrentProcess().MainWindowHandle);
        }
    }
}
