namespace Fika_Launcher
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            mainPanel = new Panel();
            btnPlayerDir = new Button();
            btnLaunchDelay = new Button();
            btnRunLauncher = new Button();
            btnStatus = new Button();
            dirPanel = new Panel();
            panelSeparator = new Panel();
            btnBrowse = new Button();
            gamePath = new RichTextBox();
            btnBack = new Button();
            mainPanel.SuspendLayout();
            dirPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(btnPlayerDir);
            mainPanel.Controls.Add(btnLaunchDelay);
            mainPanel.Controls.Add(btnRunLauncher);
            mainPanel.Controls.Add(btnStatus);
            mainPanel.Location = new Point(13, 13);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(362, 362);
            mainPanel.TabIndex = 0;
            // 
            // btnPlayerDir
            // 
            btnPlayerDir.BackColor = Color.FromArgb(32, 34, 36);
            btnPlayerDir.Cursor = Cursors.Hand;
            btnPlayerDir.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnPlayerDir.FlatAppearance.BorderSize = 0;
            btnPlayerDir.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 38, 40);
            btnPlayerDir.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 38, 40);
            btnPlayerDir.FlatStyle = FlatStyle.Flat;
            btnPlayerDir.Font = new Font("Bahnschrift", 14F);
            btnPlayerDir.Location = new Point(184, 3);
            btnPlayerDir.Name = "btnPlayerDir";
            btnPlayerDir.Size = new Size(175, 175);
            btnPlayerDir.TabIndex = 4;
            btnPlayerDir.Text = "PLAYER FOLDER\r\n\r\n🔍";
            btnPlayerDir.UseVisualStyleBackColor = false;
            btnPlayerDir.Click += btnPlayerDir_Click;
            btnPlayerDir.MouseDown += btnPlayerDir_MouseDown;
            // 
            // btnLaunchDelay
            // 
            btnLaunchDelay.BackColor = Color.FromArgb(32, 34, 36);
            btnLaunchDelay.Cursor = Cursors.Hand;
            btnLaunchDelay.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnLaunchDelay.FlatAppearance.BorderSize = 0;
            btnLaunchDelay.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 38, 40);
            btnLaunchDelay.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 38, 40);
            btnLaunchDelay.FlatStyle = FlatStyle.Flat;
            btnLaunchDelay.Font = new Font("Bahnschrift", 14F);
            btnLaunchDelay.Location = new Point(184, 184);
            btnLaunchDelay.Name = "btnLaunchDelay";
            btnLaunchDelay.Size = new Size(175, 175);
            btnLaunchDelay.TabIndex = 3;
            btnLaunchDelay.Text = "LAUNCH DELAY\r\n\r\n4s";
            btnLaunchDelay.UseVisualStyleBackColor = false;
            btnLaunchDelay.Click += btnLaunchDelay_Click;
            btnLaunchDelay.MouseDown += btnLaunchDelay_MouseDown;
            // 
            // btnRunLauncher
            // 
            btnRunLauncher.BackColor = Color.FromArgb(32, 34, 36);
            btnRunLauncher.Cursor = Cursors.Hand;
            btnRunLauncher.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnRunLauncher.FlatAppearance.BorderSize = 0;
            btnRunLauncher.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 38, 40);
            btnRunLauncher.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 38, 40);
            btnRunLauncher.FlatStyle = FlatStyle.Flat;
            btnRunLauncher.Font = new Font("Bahnschrift", 14F);
            btnRunLauncher.Location = new Point(3, 184);
            btnRunLauncher.Name = "btnRunLauncher";
            btnRunLauncher.Size = new Size(175, 175);
            btnRunLauncher.TabIndex = 2;
            btnRunLauncher.Text = "RUN LAUNCHER\r\n\r\n✔️";
            btnRunLauncher.UseVisualStyleBackColor = false;
            btnRunLauncher.Click += btnRunLauncher_Click;
            btnRunLauncher.MouseDown += btnRunLauncher_MouseDown;
            // 
            // btnStatus
            // 
            btnStatus.BackColor = Color.FromArgb(32, 34, 36);
            btnStatus.Cursor = Cursors.Hand;
            btnStatus.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnStatus.FlatAppearance.BorderSize = 0;
            btnStatus.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 38, 40);
            btnStatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 38, 40);
            btnStatus.FlatStyle = FlatStyle.Flat;
            btnStatus.Font = new Font("Bahnschrift", 14F);
            btnStatus.Location = new Point(3, 3);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(175, 175);
            btnStatus.TabIndex = 1;
            btnStatus.Text = "ENABLED\r\n\r\n✔️";
            btnStatus.UseVisualStyleBackColor = false;
            btnStatus.Click += btnStatus_Click;
            btnStatus.MouseDown += btnStatus_MouseDown;
            // 
            // dirPanel
            // 
            dirPanel.Controls.Add(panelSeparator);
            dirPanel.Controls.Add(btnBrowse);
            dirPanel.Controls.Add(gamePath);
            dirPanel.Controls.Add(btnBack);
            dirPanel.Location = new Point(13, 13);
            dirPanel.Name = "dirPanel";
            dirPanel.Size = new Size(362, 362);
            dirPanel.TabIndex = 1;
            // 
            // panelSeparator
            // 
            panelSeparator.BorderStyle = BorderStyle.FixedSingle;
            panelSeparator.Location = new Point(3, 193);
            panelSeparator.Name = "panelSeparator";
            panelSeparator.Size = new Size(356, 1);
            panelSeparator.TabIndex = 8;
            panelSeparator.Visible = false;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.FromArgb(32, 34, 36);
            btnBrowse.Cursor = Cursors.Hand;
            btnBrowse.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 38, 40);
            btnBrowse.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 38, 40);
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Bahnschrift", 14F);
            btnBrowse.Location = new Point(3, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(175, 175);
            btnBrowse.TabIndex = 7;
            btnBrowse.Text = "BROWSE\r\n\r\n🔍";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            btnBrowse.MouseDown += btnBrowse_MouseDown;
            // 
            // gamePath
            // 
            gamePath.BackColor = Color.FromArgb(26, 28, 30);
            gamePath.BorderStyle = BorderStyle.None;
            gamePath.Cursor = Cursors.Hand;
            gamePath.Font = new Font("Bahnschrift Light", 12F);
            gamePath.ForeColor = Color.LightGray;
            gamePath.Location = new Point(3, 214);
            gamePath.Name = "gamePath";
            gamePath.ReadOnly = true;
            gamePath.Size = new Size(356, 145);
            gamePath.TabIndex = 6;
            gamePath.Text = "";
            gamePath.TextChanged += gamePath_TextChanged;
            gamePath.MouseDown += gamePath_MouseDown;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(32, 34, 36);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = SystemColors.WindowFrame;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 38, 40);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 38, 40);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Bahnschrift", 14F);
            btnBack.Location = new Point(184, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(175, 175);
            btnBack.TabIndex = 5;
            btnBack.Text = "GO BACK\r\n\r\n⬅️";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 28, 30);
            ClientSize = new Size(388, 388);
            Controls.Add(dirPanel);
            Controls.Add(mainPanel);
            DoubleBuffered = true;
            Font = new Font("Bahnschrift Light", 16F);
            ForeColor = Color.LightGray;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "[LaunchFikaProfile] Settings";
            Load += mainForm_Load;
            mainPanel.ResumeLayout(false);
            dirPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Button btnStatus;
        private Button btnRunLauncher;
        private Button btnLaunchDelay;
        private Button btnPlayerDir;
        private Panel dirPanel;
        private Button btnBack;
        private RichTextBox gamePath;
        private Button btnBrowse;
        private Panel panelSeparator;
    }
}
