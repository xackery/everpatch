namespace everpatch
{
    partial class everpatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(everpatch));
            this.serverGrid = new System.Windows.Forms.DataGridView();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.loginsLink = new System.Windows.Forms.LinkLabel();
            this.loginsDisplay = new System.Windows.Forms.Label();
            this.serverLink = new System.Windows.Forms.LinkLabel();
            this.serverDisplay = new System.Windows.Forms.Label();
            this.tabLogins = new System.Windows.Forms.TabPage();
            this.groupLoginDetails = new System.Windows.Forms.GroupBox();
            this.buttonSaveLogin = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.accountDisplay = new System.Windows.Forms.Label();
            this.groupLogins = new System.Windows.Forms.GroupBox();
            this.listLogins = new System.Windows.Forms.CheckedListBox();
            this.tabServerSelect = new System.Windows.Forms.TabPage();
            this.currentSelectedServer = new System.Windows.Forms.Label();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.checkAdmin = new System.Windows.Forms.CheckBox();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.systemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.systemTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.launchEverquestSystemTray = new System.Windows.Forms.ToolStripMenuItem();
            this.openEverPatchUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripLabel = new System.Windows.Forms.StatusStrip();
            this.statusDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.buttonLaunch = new System.Windows.Forms.ToolStripSplitButton();
            this.verifyPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.serverGrid)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.tabLogins.SuspendLayout();
            this.groupLoginDetails.SuspendLayout();
            this.groupLogins.SuspendLayout();
            this.tabServerSelect.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.systemTrayMenu.SuspendLayout();
            this.statusStripLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverGrid
            // 
            this.serverGrid.AllowUserToAddRows = false;
            this.serverGrid.AllowUserToDeleteRows = false;
            this.serverGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverGrid.Location = new System.Drawing.Point(7, 85);
            this.serverGrid.Name = "serverGrid";
            this.serverGrid.ReadOnly = true;
            this.serverGrid.Size = new System.Drawing.Size(445, 412);
            this.serverGrid.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabSummary);
            this.tabs.Controls.Add(this.tabLogins);
            this.tabs.Controls.Add(this.tabServerSelect);
            this.tabs.Controls.Add(this.tabLog);
            this.tabs.Controls.Add(this.tabOptions);
            this.tabs.Controls.Add(this.tabAdmin);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 3, 3, 300);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(780, 535);
            this.tabs.TabIndex = 1;
            this.tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.Tabs_Selected);
            this.tabs.TabIndexChanged += new System.EventHandler(this.Tabs_TabIndexChanged);
            // 
            // tabSummary
            // 
            this.tabSummary.BackColor = System.Drawing.SystemColors.Control;
            this.tabSummary.Controls.Add(this.loginsLink);
            this.tabSummary.Controls.Add(this.loginsDisplay);
            this.tabSummary.Controls.Add(this.serverLink);
            this.tabSummary.Controls.Add(this.serverDisplay);
            this.tabSummary.Location = new System.Drawing.Point(4, 22);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3, 3, 3, 150);
            this.tabSummary.Size = new System.Drawing.Size(772, 509);
            this.tabSummary.TabIndex = 0;
            this.tabSummary.Text = "Summary";
            // 
            // loginsLink
            // 
            this.loginsLink.AutoSize = true;
            this.loginsLink.Location = new System.Drawing.Point(53, 55);
            this.loginsLink.Name = "loginsLink";
            this.loginsLink.Size = new System.Drawing.Size(33, 13);
            this.loginsLink.TabIndex = 3;
            this.loginsLink.TabStop = true;
            this.loginsLink.Text = "None";
            this.loginsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginsLink_LinkClicked);
            // 
            // loginsDisplay
            // 
            this.loginsDisplay.AutoSize = true;
            this.loginsDisplay.Location = new System.Drawing.Point(6, 55);
            this.loginsDisplay.Name = "loginsDisplay";
            this.loginsDisplay.Size = new System.Drawing.Size(41, 13);
            this.loginsDisplay.TabIndex = 2;
            this.loginsDisplay.Text = "Logins:";
            // 
            // serverLink
            // 
            this.serverLink.AutoSize = true;
            this.serverLink.Location = new System.Drawing.Point(53, 22);
            this.serverLink.Name = "serverLink";
            this.serverLink.Size = new System.Drawing.Size(58, 13);
            this.serverLink.TabIndex = 1;
            this.serverLink.TabStop = true;
            this.serverLink.Text = "RebuildEQ";
            this.serverLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ServerLink_LinkClicked);
            // 
            // serverDisplay
            // 
            this.serverDisplay.AutoSize = true;
            this.serverDisplay.Location = new System.Drawing.Point(6, 22);
            this.serverDisplay.Name = "serverDisplay";
            this.serverDisplay.Size = new System.Drawing.Size(41, 13);
            this.serverDisplay.TabIndex = 0;
            this.serverDisplay.Text = "Server:";
            // 
            // tabLogins
            // 
            this.tabLogins.BackColor = System.Drawing.SystemColors.Control;
            this.tabLogins.Controls.Add(this.groupLoginDetails);
            this.tabLogins.Controls.Add(this.groupLogins);
            this.tabLogins.Location = new System.Drawing.Point(4, 22);
            this.tabLogins.Name = "tabLogins";
            this.tabLogins.Size = new System.Drawing.Size(772, 509);
            this.tabLogins.TabIndex = 4;
            this.tabLogins.Text = "Logins";
            // 
            // groupLoginDetails
            // 
            this.groupLoginDetails.Controls.Add(this.buttonSaveLogin);
            this.groupLoginDetails.Controls.Add(this.textPassword);
            this.groupLoginDetails.Controls.Add(this.labelPassword);
            this.groupLoginDetails.Controls.Add(this.textAccount);
            this.groupLoginDetails.Controls.Add(this.accountDisplay);
            this.groupLoginDetails.Location = new System.Drawing.Point(161, 4);
            this.groupLoginDetails.Name = "groupLoginDetails";
            this.groupLoginDetails.Size = new System.Drawing.Size(284, 352);
            this.groupLoginDetails.TabIndex = 2;
            this.groupLoginDetails.TabStop = false;
            this.groupLoginDetails.Text = "Login Details";
            // 
            // buttonSaveLogin
            // 
            this.buttonSaveLogin.Location = new System.Drawing.Point(10, 323);
            this.buttonSaveLogin.Name = "buttonSaveLogin";
            this.buttonSaveLogin.Size = new System.Drawing.Size(268, 23);
            this.buttonSaveLogin.TabIndex = 4;
            this.buttonSaveLogin.Text = "Save";
            this.buttonSaveLogin.UseVisualStyleBackColor = true;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(63, 43);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(134, 20);
            this.textPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(7, 46);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password:";
            // 
            // textAccount
            // 
            this.textAccount.Location = new System.Drawing.Point(63, 17);
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(134, 20);
            this.textAccount.TabIndex = 1;
            // 
            // accountDisplay
            // 
            this.accountDisplay.AutoSize = true;
            this.accountDisplay.Location = new System.Drawing.Point(7, 20);
            this.accountDisplay.Name = "accountDisplay";
            this.accountDisplay.Size = new System.Drawing.Size(50, 13);
            this.accountDisplay.TabIndex = 0;
            this.accountDisplay.Text = "Account:";
            // 
            // groupLogins
            // 
            this.groupLogins.Controls.Add(this.listLogins);
            this.groupLogins.Location = new System.Drawing.Point(3, 3);
            this.groupLogins.Name = "groupLogins";
            this.groupLogins.Size = new System.Drawing.Size(151, 516);
            this.groupLogins.TabIndex = 1;
            this.groupLogins.TabStop = false;
            this.groupLogins.Text = "Logins";
            // 
            // listLogins
            // 
            this.listLogins.BackColor = System.Drawing.SystemColors.Control;
            this.listLogins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLogins.FormattingEnabled = true;
            this.listLogins.Location = new System.Drawing.Point(6, 21);
            this.listLogins.Name = "listLogins";
            this.listLogins.Size = new System.Drawing.Size(139, 480);
            this.listLogins.TabIndex = 0;
            this.listLogins.SelectedIndexChanged += new System.EventHandler(this.ListLogins_SelectedIndexChanged);
            // 
            // tabServerSelect
            // 
            this.tabServerSelect.BackColor = System.Drawing.SystemColors.Control;
            this.tabServerSelect.Controls.Add(this.currentSelectedServer);
            this.tabServerSelect.Controls.Add(this.serverGrid);
            this.tabServerSelect.Location = new System.Drawing.Point(4, 22);
            this.tabServerSelect.Name = "tabServerSelect";
            this.tabServerSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabServerSelect.Size = new System.Drawing.Size(772, 509);
            this.tabServerSelect.TabIndex = 1;
            this.tabServerSelect.Text = "Server Select";
            // 
            // currentSelectedServer
            // 
            this.currentSelectedServer.AutoSize = true;
            this.currentSelectedServer.Location = new System.Drawing.Point(18, 14);
            this.currentSelectedServer.Name = "currentSelectedServer";
            this.currentSelectedServer.Size = new System.Drawing.Size(163, 13);
            this.currentSelectedServer.TabIndex = 1;
            this.currentSelectedServer.Text = "Choose which server to patch for";
            // 
            // tabLog
            // 
            this.tabLog.BackColor = System.Drawing.SystemColors.Control;
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Size = new System.Drawing.Size(772, 509);
            this.tabLog.TabIndex = 3;
            this.tabLog.Text = "Log";
            // 
            // tabOptions
            // 
            this.tabOptions.BackColor = System.Drawing.SystemColors.Control;
            this.tabOptions.Controls.Add(this.checkAdmin);
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Size = new System.Drawing.Size(772, 509);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Options";
            // 
            // checkAdmin
            // 
            this.checkAdmin.AutoSize = true;
            this.checkAdmin.Location = new System.Drawing.Point(8, 12);
            this.checkAdmin.Name = "checkAdmin";
            this.checkAdmin.Size = new System.Drawing.Size(150, 17);
            this.checkAdmin.TabIndex = 4;
            this.checkAdmin.Text = "Server Administrator Mode";
            this.checkAdmin.UseVisualStyleBackColor = true;
            this.checkAdmin.CheckedChanged += new System.EventHandler(this.CheckAdmin_CheckedChanged);
            // 
            // tabAdmin
            // 
            this.tabAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Size = new System.Drawing.Size(772, 509);
            this.tabAdmin.TabIndex = 5;
            this.tabAdmin.Text = "Admin";
            // 
            // bgWorker
            // 
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorker_DoWork);
            // 
            // systemTray
            // 
            this.systemTray.ContextMenuStrip = this.systemTrayMenu;
            this.systemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTray.Icon")));
            this.systemTray.Text = "System Tray";
            this.systemTray.Visible = true;
            this.systemTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SystemTray_MouseDoubleClick);
            // 
            // systemTrayMenu
            // 
            this.systemTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchEverquestSystemTray,
            this.openEverPatchUIToolStripMenuItem});
            this.systemTrayMenu.Name = "systemTrayMenu";
            this.systemTrayMenu.Size = new System.Drawing.Size(243, 48);
            this.systemTrayMenu.Text = "Test";
            // 
            // launchEverquestSystemTray
            // 
            this.launchEverquestSystemTray.Name = "launchEverquestSystemTray";
            this.launchEverquestSystemTray.Size = new System.Drawing.Size(242, 22);
            this.launchEverquestSystemTray.Text = "Launch Everquest (ServerName)";
            // 
            // openEverPatchUIToolStripMenuItem
            // 
            this.openEverPatchUIToolStripMenuItem.Name = "openEverPatchUIToolStripMenuItem";
            this.openEverPatchUIToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.openEverPatchUIToolStripMenuItem.Text = "Open EverPatch UI";
            // 
            // statusStripLabel
            // 
            this.statusStripLabel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDisplay,
            this.progressBar,
            this.buttonLaunch});
            this.statusStripLabel.Location = new System.Drawing.Point(0, 495);
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(780, 40);
            this.statusStripLabel.SizingGrip = false;
            this.statusStripLabel.TabIndex = 4;
            // 
            // statusDisplay
            // 
            this.statusDisplay.AutoSize = false;
            this.statusDisplay.Name = "statusDisplay";
            this.statusDisplay.Size = new System.Drawing.Size(250, 35);
            this.statusDisplay.Text = "Ready to Launch";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(400, 34);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.Value = 50;
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonLaunch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verifyPatchToolStripMenuItem});
            this.buttonLaunch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonLaunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(16, 38);
            this.buttonLaunch.Text = "Launch";
            // 
            // verifyPatchToolStripMenuItem
            // 
            this.verifyPatchToolStripMenuItem.Name = "verifyPatchToolStripMenuItem";
            this.verifyPatchToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.verifyPatchToolStripMenuItem.Text = "Verify Patch";
            // 
            // everpatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(780, 535);
            this.Controls.Add(this.statusStripLabel);
            this.Controls.Add(this.tabs);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 371);
            this.Name = "everpatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EverPatch";
            this.Load += new System.EventHandler(this.Everpatch_Load);
            this.Resize += new System.EventHandler(this.Everpatch_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.serverGrid)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            this.tabSummary.PerformLayout();
            this.tabLogins.ResumeLayout(false);
            this.groupLoginDetails.ResumeLayout(false);
            this.groupLoginDetails.PerformLayout();
            this.groupLogins.ResumeLayout(false);
            this.tabServerSelect.ResumeLayout(false);
            this.tabServerSelect.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.tabOptions.PerformLayout();
            this.systemTrayMenu.ResumeLayout(false);
            this.statusStripLabel.ResumeLayout(false);
            this.statusStripLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView serverGrid;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TabPage tabServerSelect;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.Label serverDisplay;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Label currentSelectedServer;
        private System.Windows.Forms.LinkLabel serverLink;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.TabPage tabLogins;
        private System.Windows.Forms.Label loginsDisplay;
        private System.Windows.Forms.LinkLabel loginsLink;
        private System.Windows.Forms.GroupBox groupLogins;
        private System.Windows.Forms.GroupBox groupLoginDetails;
        private System.Windows.Forms.Label accountDisplay;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonSaveLogin;
        private System.Windows.Forms.CheckedListBox listLogins;
        private System.Windows.Forms.NotifyIcon systemTray;
        private System.Windows.Forms.ContextMenuStrip systemTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem launchEverquestSystemTray;
        private System.Windows.Forms.ToolStripMenuItem openEverPatchUIToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusDisplay;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripSplitButton buttonLaunch;
        private System.Windows.Forms.ToolStripMenuItem verifyPatchToolStripMenuItem;
        private System.Windows.Forms.TabPage tabAdmin;
        private System.Windows.Forms.CheckBox checkAdmin;
    }
}

