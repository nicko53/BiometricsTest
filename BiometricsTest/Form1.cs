using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiometricsTest.Controls;

namespace BiometricsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UCAdd uc = new UCAdd();
            AddControls(uc);   
        }

        private void AddControls(UserControl controls)
        {
            controls.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(controls);
            controls.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UCAdd uc = new UCAdd();
            AddControls(uc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UCRegBio uc = new UCRegBio();
            AddControls(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FingerPrintControl uc = new FingerPrintControl();
            AddControls(uc);
        }
    }
}
