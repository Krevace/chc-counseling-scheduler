using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Calendar.v3;
using Google.Apis.PeopleService.v1;
using Google.Apis.PeopleService.v1.Data;

namespace CollegeSchedulingDesktopAppMain
{
    public partial class FormMain : Form
    {
        bool nBar = false;
        string gMail = "";
        CalendarService service;
        PeopleServiceService service2;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FormMain(CalendarService servicePass, PeopleServiceService service2Pass)
        {
            InitializeComponent();
            service = servicePass;
            service2 = service2Pass;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormSettings)
                {
                    form.Close();
                    break;
                }
            }

            openChildForm(new FormPending(service, gMail));
            buttonDashboard.Image = Properties.Resources.dashboard2;
            buttonSettings.Image = Properties.Resources.settings;
            buttonSignOut.Image = Properties.Resources.logout;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is FormPending)
                {
                    form.Close();
                    break;
                }          
            }

            openChildForm(new FormSettings());
            buttonDashboard.Image = Properties.Resources.dashboard;
            buttonSettings.Image = Properties.Resources.settings2;
            buttonSignOut.Image = Properties.Resources.logout;
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            buttonDashboard.Image = Properties.Resources.dashboard;
            buttonSettings.Image = Properties.Resources.settings;
            buttonSignOut.Image = Properties.Resources.logout2;

            string startupPath = System.IO.Directory.GetCurrentDirectory();
            
            DirectoryInfo dir = new DirectoryInfo(startupPath + @"\token.json"); 

            if (!Properties.Settings.Default.signOut)
            {
                foreach (FileInfo fi in dir.GetFiles())
                {
                    fi.Delete();
                }
            }

            this.Close();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            nBar = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            nBar = false;
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState && nBar == true) 
            {
                notifyIcon1.Visible = true;
                this.Hide();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void panelTop_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PeopleResource.GetRequest peopleRequest = service2.People.Get("people/me");
            peopleRequest.PersonFields = "Names";
            Person user = peopleRequest.Execute();
            labelName.Text = user.Names[0].DisplayName.ToString();
            if (labelName.Text == "##############") {
                gMail = "##############";
                labelName.Location = new Point(19, 595);
            } else if (labelName.Text == "##############") {
                gMail = "##############";
                labelName.Location = new Point(-3, 595);
            } else if (labelName.Text == "##############") {
                gMail = "##############";
                labelName.Location = new Point(38, 595);
            } else if (labelName.Text == "##############") {
                gMail = "##############";
                labelName.Location = new Point(23, 595);
            } else if (labelName.Text == "##############") {
                gMail = "##############";
                labelName.Location = new Point(12, 595);
            }
            /*
            int num = 2;
            if (labelName.Text.Length >= 16)
            {
                num = 0;
            }
            labelName.Location = new Point(Convert.ToInt32((panelSideBar.Width - ((labelName.Text.Length + num) * 10.8125)) / 2), 595);
            */
            openChildForm(new FormPending(service, gMail));
        }
    }
}
