using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;

namespace HWID
{
    public partial class Form1 : Form
    {
        private string HWID;
        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitializeComponent();
            this.HWID = WindowsIdentity.GetCurrent().User.Value;
            WebClient webClient = new WebClient();
            Clipboard.SetText(this.HWID);
            MessageBox.Show("HWID Copied in your clipboard.", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            Application.Exit();
        }

        private void InitializeComponent()
        {
            base.SuspendLayout();
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(464, 332);
            base.Name = "Form1";
            this.Text = "Form1";
            base.Load += this.Form1_Load;
            base.ResumeLayout(false);
        }
    }
}
