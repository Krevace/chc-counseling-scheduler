using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeSchedulingDesktopAppMain
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.signOut;
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.signOut = !Properties.Settings.Default.signOut;
            Properties.Settings.Default.Save();
        }
    }
}
