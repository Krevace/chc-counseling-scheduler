
namespace CollegeSchedulingDesktopAppMain
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.pictureBoxCompass = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompass)).BeginInit();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.Image = global::CollegeSchedulingDesktopAppMain.Properties.Resources.dashboard2;
            this.buttonDashboard.Location = new System.Drawing.Point(28, 243);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(145, 110);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "Pending";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.Location = new System.Drawing.Point(43, 355);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(112, 110);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.FlatAppearance.BorderSize = 0;
            this.buttonSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignOut.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonSignOut.Image")));
            this.buttonSignOut.Location = new System.Drawing.Point(41, 471);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(117, 109);
            this.buttonSignOut.TabIndex = 3;
            this.buttonSignOut.Text = "Exit";
            this.buttonSignOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(18)))), ((int)(((byte)(69)))));
            this.panelTop.Controls.Add(this.buttonMin);
            this.panelTop.Controls.Add(this.buttonX);
            this.panelTop.Controls.Add(this.pictureBoxCompass);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Location = new System.Drawing.Point(-1, -1);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(873, 49);
            this.panelTop.TabIndex = 6;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // buttonMin
            // 
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMin.ForeColor = System.Drawing.Color.White;
            this.buttonMin.Location = new System.Drawing.Point(787, 0);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(43, 49);
            this.buttonMin.TabIndex = 11;
            this.buttonMin.Text = "-";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonX
            // 
            this.buttonX.FlatAppearance.BorderSize = 0;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.ForeColor = System.Drawing.Color.White;
            this.buttonX.Location = new System.Drawing.Point(830, 0);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(43, 49);
            this.buttonX.TabIndex = 10;
            this.buttonX.Text = "x";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // pictureBoxCompass
            // 
            this.pictureBoxCompass.Image = global::CollegeSchedulingDesktopAppMain.Properties.Resources.CHCWebBannerApr19;
            this.pictureBoxCompass.InitialImage = global::CollegeSchedulingDesktopAppMain.Properties.Resources.CHCWebBannerApr19;
            this.pictureBoxCompass.Location = new System.Drawing.Point(19, 8);
            this.pictureBoxCompass.Name = "pictureBoxCompass";
            this.pictureBoxCompass.Size = new System.Drawing.Size(35, 34);
            this.pictureBoxCompass.TabIndex = 9;
            this.pictureBoxCompass.TabStop = false;
            this.pictureBoxCompass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(55, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(245, 23);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "CHC Meeting Scheduler";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(234)))));
            this.panelSideBar.Controls.Add(this.labelName);
            this.panelSideBar.Controls.Add(this.buttonSignOut);
            this.panelSideBar.Controls.Add(this.buttonSettings);
            this.panelSideBar.Controls.Add(this.pictureBoxLogo);
            this.panelSideBar.Controls.Add(this.buttonDashboard);
            this.panelSideBar.Location = new System.Drawing.Point(-1, -1);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(200, 652);
            this.panelSideBar.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Cambria", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(23, 595);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(162, 27);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "############";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::CollegeSchedulingDesktopAppMain.Properties.Resources.calendar_icons;
            this.pictureBoxLogo.InitialImage = global::CollegeSchedulingDesktopAppMain.Properties.Resources.calendar_icons;
            this.pictureBoxLogo.Location = new System.Drawing.Point(13, 58);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(174, 182);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CHC Meeting Scheduler";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(199, 48);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(673, 591);
            this.panelChildForm.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(871, 639);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "CHC Meeting Scheduler";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompass)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.panelSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.PictureBox pictureBoxCompass;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Label labelName;
    }
}

