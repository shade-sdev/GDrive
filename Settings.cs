using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GDrive
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            misc.setSetting("GDrive.ini", 0, "clientId="+txtClientId.Text);
            misc.setSetting("GDrive.ini", 1, "clientSecret=" + txtSecret.Text);
            Application.Restart();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtClientId.Text = constants.clientId;
            txtSecret.Text = constants.clientSecret;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("index.html");
        }
    }
}
