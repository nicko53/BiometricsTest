﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricsTest.Controls
{
    public partial class StatusBar : UserControl
    {
        internal Color StatusBarForeColor;
        internal Color StatusBarBackColor;
        internal string Message;

        public StatusBar()
        {
            InitializeComponent();
        }
    }
}
