using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace Fika_Launcher
{
    public partial class mainForm : Form
    {
        public string currentEnv = Environment.CurrentDirectory;
        public string? SPTServer = null;
        public string? SPTLauncher = null;
        public string? SPTData = null;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            bool doesEnvExist = Directory.Exists(currentEnv);
            SPTServer = Path.Join(currentEnv, "..", "..", "..", "SPT.Server.exe");
            SPTLauncher = Path.Join(currentEnv, "..", "..", "..", "SPT.Launcher.exe");
            SPTData = Path.Join(currentEnv, "..", "..", "..", "SPT_Data");

            bool doesServerExist = File.Exists(SPTServer);
            bool doesLauncherExist = File.Exists(SPTLauncher);
            bool doesDataExist = Directory.Exists(SPTData);

            if (doesEnvExist && doesLauncherExist && doesDataExist)
            {
                string? package = "package.json";
                string? displayParentName = Path.GetFileName(currentEnv);
                string? joinedPackage = Path.Join(currentEnv, package);

                if (displayParentName == "LaunchFikaProfile" && File.Exists(joinedPackage))
                {
                    mainPanel.BringToFront();
                }
            }
            else
            {
                string content = "We could not detect critical SPT files, place this app in `user/mods/LaunchFikaProfile`  and try again.";
                if (MessageBox.Show(content, Text, MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnStatus_MouseDown(object sender, MouseEventArgs e)
        {
            if (btnStatus.Text.Contains("✔️"))
            {
                btnStatus.Text = "DISABLED" + Environment.NewLine + Environment.NewLine +
                                 "✖️";
                btnStatus.ForeColor = Color.IndianRed;
            }
            else
            {
                btnStatus.Text = "ENABLED" + Environment.NewLine + Environment.NewLine +
                                 "✔️";
                btnStatus.ForeColor = Color.DodgerBlue;
            }
        }

        private void btnRunLauncher_Click(object sender, EventArgs e)
        {

        }

        private void btnRunLauncher_MouseDown(object sender, MouseEventArgs e)
        {
            if (btnRunLauncher.Text.Contains("✔️"))
            {
                btnRunLauncher.Text = "RUN LAUNCHER" + Environment.NewLine + Environment.NewLine +
                                 "✖️";
                btnRunLauncher.ForeColor = Color.IndianRed;
            }
            else
            {
                btnRunLauncher.Text = "RUN LAUNCHER" + Environment.NewLine + Environment.NewLine +
                                 "✔️";
                btnRunLauncher.ForeColor = Color.DodgerBlue;
            }
        }

        private void btnPlayerDir_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayerDir_MouseDown(object sender, MouseEventArgs e)
        {
            dirPanel.BringToFront();
        }

        private void btnLaunchDelay_Click(object sender, EventArgs e)
        {

        }

        private void btnLaunchDelay_MouseDown(object sender, MouseEventArgs e)
        {
            switch (btnLaunchDelay.Text)
            {
                case "LAUNCH DELAY\r\n\r\n4s":
                    btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n5s";
                    break;
                case "LAUNCH DELAY\r\n\r\n5s":
                    btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n1s";
                    break;
                case "LAUNCH DELAY\r\n\r\n1s":
                    btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n2s";
                    break;
                case "LAUNCH DELAY\r\n\r\n2s":
                    btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n3s";
                    break;
                case "LAUNCH DELAY\r\n\r\n3s":
                    btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n4s";
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainPanel.BringToFront();
        }

        private void gamePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void gamePath_MouseDown(object sender, MouseEventArgs e)
        {
            browseForDirectory();
            panelSeparator.Select();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        public void browseForDirectory()
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = Environment.CurrentDirectory;
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedPath = dialog.SelectedPath;
                    bool doesItExist = Directory.Exists(selectedPath);
                    if (doesItExist)
                    {
                        gamePath.Text = selectedPath;
                    }
                }
            }
        }

        private void btnBrowse_MouseDown(object sender, MouseEventArgs e)
        {
            browseForDirectory();
            panelSeparator.Select();
        }
    }
}
