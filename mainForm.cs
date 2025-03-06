using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        public string? configFile = null;

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
                configFile = Path.Join(currentEnv, "config", "config.json");
                string? package = "package.json";
                string? displayParentName = Path.GetFileName(currentEnv);
                string? joinedPackage = Path.Join(currentEnv, package);

                if (displayParentName == "LaunchFikaProfile" && File.Exists(joinedPackage) && File.Exists(configFile))
                {
                    initializeApp();
                }
                else
                {
                    shutdownPopup();
                }
            }
            else
            {
                shutdownPopup();
            }
        }

        public void initializeApp()
        {
            if (doesConfigExist())
            {
                loadFeatures();
            }
            else
            {
                createConfig(false);
                initializeApp();
            }
        }

        public void loadFeatures()
        {
            mainPanel.BringToFront();

            if (doesConfigExist())
            {
                if (configFile != null)
                {
                    string json = File.ReadAllText(configFile);
                    Config? loadedConfig = JsonConvert.DeserializeObject<Config>(json);

                    if (loadedConfig != null)
                    {
                        if (loadedConfig.EnableMod)
                        {
                            btnStatus.ForeColor = Color.DodgerBlue;
                            btnStatus.Text = "MOD ENABLED" + Environment.NewLine + Environment.NewLine +
                                             "✔️";
                        }
                        else
                        {
                            btnStatus.ForeColor = Color.IndianRed;
                            btnStatus.Text = "MOD DISABLED" + Environment.NewLine + Environment.NewLine +
                                             "✖️";
                        }

                        if (loadedConfig.RunLauncher)
                        {
                            btnRunLauncher.ForeColor = Color.DodgerBlue;
                            btnRunLauncher.Text = "RUN LAUNCHER" + Environment.NewLine + Environment.NewLine +
                                             "✔️";
                        }
                        else
                        {
                            btnRunLauncher.ForeColor = Color.IndianRed;
                            btnRunLauncher.Text = "RUN LAUNCHER" + Environment.NewLine + Environment.NewLine +
                                             "✖️";
                        }

                        if (!string.IsNullOrEmpty(loadedConfig.PlayerDir))
                        {
                            gamePath.Text = loadedConfig.PlayerDir.ToString();
                        }
                        else
                        {
                            gamePath.Text = "Unrecognized string format, please reset the application";
                        }

                        btnLaunchDelay.Text = "LAUNCH DELAY" + Environment.NewLine + Environment.NewLine +
                                              $"{loadedConfig.TimeoutSeconds.ToString()}s";
                    }

                    File.WriteAllText(configFile, JsonConvert.SerializeObject(loadedConfig, Formatting.Indented));
                }
            }
            else
            {
                initializeApp();
            }
        }

        public void createConfig(bool regenerate)
        {
            string configFile = Path.Join(currentEnv, "config", "config.json");
            var newConfig = new Config
            {
                EnableMod = true,
                RunLauncher = true,
                PlayerDir = "",
                TimeoutSeconds = 5
            };
            string json = JsonConvert.SerializeObject(newConfig, Formatting.Indented);

            if (regenerate)
            {
                try
                {
                    File.Delete(configFile);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Regen: Failed ({ex.Message.ToString()})");
                }
            }

            if (!File.Exists(configFile))
            {
                File.WriteAllText(configFile, json);
                Debug.WriteLine("WriteTo: success");
            }
        }

        public bool doesConfigExist()
        {
            return File.Exists(configFile);
        }

        public void shutdownPopup()
        {
            string content = "We could not detect critical SPT files, place this app in `user/mods/LaunchFikaProfile`  and try again.";
            if (MessageBox.Show(content, Text, MessageBoxButtons.OK) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void toggleMod(bool toggle)
        {
            if (doesConfigExist())
            {
                if (configFile != null)
                {
                    string json = File.ReadAllText(configFile);
                    Config? loadedConfig = JsonConvert.DeserializeObject<Config>(json);

                    if (loadedConfig != null)
                    {
                        loadedConfig.EnableMod = toggle;
                    }

                    File.WriteAllText(configFile, JsonConvert.SerializeObject(loadedConfig, Formatting.Indented));
                }
            }
            else
            {
                initializeApp();
            }
        }

        public void toggleLauncher(bool toggle)
        {
            if (doesConfigExist())
            {
                if (configFile != null)
                {
                    string json = File.ReadAllText(configFile);
                    Config? loadedConfig = JsonConvert.DeserializeObject<Config>(json);

                    if (loadedConfig != null)
                    {
                        loadedConfig.RunLauncher = toggle;
                    }

                    File.WriteAllText(configFile, JsonConvert.SerializeObject(loadedConfig, Formatting.Indented));
                }
            }
            else
            {
                initializeApp();
            }
        }

        public void setPlayerDir(string value)
        {
            if (doesConfigExist())
            {
                if (configFile != null)
                {
                    string json = File.ReadAllText(configFile);
                    Config? loadedConfig = JsonConvert.DeserializeObject<Config>(json);

                    if (loadedConfig != null)
                    {
                        loadedConfig.PlayerDir = value;
                    }

                    File.WriteAllText(configFile, JsonConvert.SerializeObject(loadedConfig, Formatting.Indented));
                }
            }
            else
            {
                initializeApp();
            }
        }

        public void setTimeoutSeconds(int value)
        {
            if (doesConfigExist())
            {
                if (configFile != null)
                {
                    string json = File.ReadAllText(configFile);
                    Config? loadedConfig = JsonConvert.DeserializeObject<Config>(json);

                    if (loadedConfig != null)
                    {
                        loadedConfig.TimeoutSeconds = value;
                    }

                    File.WriteAllText(configFile, JsonConvert.SerializeObject(loadedConfig, Formatting.Indented));
                }
            }
            else
            {
                initializeApp();
            }
        }

        public void toggleButtonStatus(Button target)
        {
            if (target.ForeColor == Color.DodgerBlue)
            {
                target.ForeColor = Color.IndianRed;
                target.Text = target.Text.Replace("✔️", "✖️");
                target.Text = target.Text.Replace("ENABLED", "DISABLED");

                if (target == btnStatus)
                    toggleMod(false);
                if (target == btnRunLauncher)
                    toggleLauncher(false);
            }
            else
            {
                target.Text = target.Text.Replace("✖️", "✔️");
                target.Text = target.Text.Replace("DISABLED", "ENABLED");
                target.ForeColor = Color.DodgerBlue;

                if (target == btnStatus)
                    toggleMod(true);
                if (target == btnRunLauncher)
                    toggleLauncher(true);
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            toggleButtonStatus(btnStatus);
        }

        private void btnStatus_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnRunLauncher_Click(object sender, EventArgs e)
        {
            toggleButtonStatus(btnRunLauncher);
        }

        private void btnRunLauncher_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnPlayerDir_Click(object sender, EventArgs e)
        {
            dirPanel.BringToFront();
        }

        private void btnPlayerDir_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnLaunchDelay_Click(object sender, EventArgs e)
        {
            switch (btnLaunchDelay.Text)
            {
                case "LAUNCH DELAY\r\n\r\n5s":
                    btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n10s";
                    setTimeoutSeconds(10);
                    break;
                case "LAUNCH DELAY\r\n\r\n10s":
                    btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n15s";
                    setTimeoutSeconds(15);
                    break;
                case "LAUNCH DELAY\r\n\r\n15s":
                    btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n2s";
                    setTimeoutSeconds(2);
                    break;
                case "LAUNCH DELAY\r\n\r\n2s":
                    btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n4s";
                    setTimeoutSeconds(4);
                    break;
                case "LAUNCH DELAY\r\n\r\n4s":
                    btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n5s";
                    setTimeoutSeconds(5);
                    break;
            }
        }

        private void btnLaunchDelay_MouseDown(object sender, MouseEventArgs e)
        {
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
            browseForDirectory();
            panelSeparator.Select();
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
                        string SPTLauncher = Path.Join(selectedPath, "SPT.Launcher.exe");
                        string EFTExecutable = Path.Join(selectedPath, "EscapeFromTarkov.exe");
                        bool sptExists = File.Exists(SPTLauncher);
                        bool EFTExecutableExists = File.Exists(EFTExecutable);

                        if (sptExists && EFTExecutableExists)
                        {
                            string content = "Are you sure you want to use this path for launching the game?" + Environment.NewLine + Environment.NewLine +
                                         selectedPath;

                            if (MessageBox.Show(content, Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                gamePath.Text = selectedPath;
                                setPlayerDir(selectedPath);
                            }
                            else
                            {
                                gamePath.Clear();
                            }
                        }
                        else
                        {
                            string content = "We could not detect the SPT launcher or Escape From Tarkov executable, please try again with another installation.";

                            if (MessageBox.Show(content, Text, MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                gamePath.Clear();
                            }
                        }
                    }
                }
            }
        }

        private void btnBrowse_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string content = "Are you sure you want to use reset the application and all mod settings?";

            if (MessageBox.Show(content, Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                createConfig(true);
                Application.Restart();
            }
        }
    }

    class Config
    {
        public bool EnableMod { get; set; }
        public bool RunLauncher { get; set; }
        public string? PlayerDir { get; set; }
        public int TimeoutSeconds { get; set; }
    }
}
