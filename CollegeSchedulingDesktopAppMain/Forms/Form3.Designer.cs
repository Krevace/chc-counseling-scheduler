
namespace CollegeSchedulingDesktopAppMain
{
    partial class FormPending
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMeetings = new System.Windows.Forms.Panel();
            this.errorInternet = new System.Windows.Forms.Label();
            this.panelMeetings.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(6, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(662, 59);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Pending Meeting Requests";
            // 
            // panelMeetings
            // 
            this.panelMeetings.AutoScroll = true;
            this.panelMeetings.Controls.Add(this.errorInternet);
            this.panelMeetings.Location = new System.Drawing.Point(0, 79);
            this.panelMeetings.Name = "panelMeetings";
            this.panelMeetings.Size = new System.Drawing.Size(674, 513);
            this.panelMeetings.TabIndex = 1;
            // 
            // errorInternet
            // 
            this.errorInternet.AutoSize = true;
            this.errorInternet.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorInternet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(18)))), ((int)(((byte)(69)))));
            this.errorInternet.Location = new System.Drawing.Point(174, 474);
            this.errorInternet.Name = "errorInternet";
            this.errorInternet.Size = new System.Drawing.Size(317, 25);
            this.errorInternet.TabIndex = 1;
            this.errorInternet.Text = "Please Connect to the Internet";
            this.errorInternet.Visible = false;
            // 
            // FormPending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(673, 591);
            this.Controls.Add(this.panelMeetings);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPending";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelMeetings.ResumeLayout(false);
            this.panelMeetings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelMeetings;
        private System.Windows.Forms.Label errorInternet;
    }
}