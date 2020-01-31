using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace everpatch
{
    public partial class everpatch : Form
    {
        public everpatch()
        {
            InitializeComponent();
        }

        private void Everpatch_Load(object sender, EventArgs e)
        {
            serverGrid.ColumnCount = 3;
            serverGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            serverGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            serverGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            serverGrid.GridColor = Color.Black;
            serverGrid.RowHeadersVisible = false;

            serverGrid.Columns[0].Name = "Server";
            serverGrid.Columns[1].Name = "Population";
            serverGrid.Columns[2].Name = "Supported";


            string[] row0 = { "RebuildEQ", "29", "Yes" };
            string[] row1 = { "Project EQ", "29", "No (client)" };

            serverGrid.Rows.Add(row0);
            serverGrid.Rows.Add(row1);
            
            serverGrid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            serverGrid.MultiSelect = false;
            serverGrid.Rows[1].Selected = true;
            //serverGrid.Dock = DockStyle.Fill;

            /*serverGrid.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                serverGrid_CellFormatting);*/
            listLogins.Items.Add("(new login)");
            listLogins.Items.Add("xackery");
            listLogins.Items.Add("xackery2");
            listLogins.SelectedItem = "(new login)";

            statusDisplay.Spring = true;
            RefreshSelections();
            progressBar.Width = Width;
            tabs.TabPages.Remove(tabAdmin);
        }


        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void ServerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabs.SelectedTab = tabServerSelect;
        }

        private void LoginsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabs.SelectedTab = tabLogins;
        }

        private void ListLogins_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
        }

        private void Tabs_TabIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender);
        }

        private void Tabs_Selected(object sender, TabControlEventArgs e)
        {
            RefreshSelections();
            
            Console.WriteLine(tabs.SelectedTab);
        }

        private void RefreshSelections()
        {
            int loginCount = 0;
            loginsLink.Text = "";
            for (int i = 0; i < listLogins.Items.Count; i++)
            {
                if (!listLogins.GetItemChecked(i))
                {
                    continue;
                }
                loginsLink.Text += listLogins.Items[i] + ", ";
                loginCount++;

            }
            if (loginsLink.Text == "")
            {
                loginsLink.Text = "None";
            } else {
                loginsLink.Text = loginsLink.Text.Substring(0, loginsLink.Text.Length - 2);
            }

            for (int i = 0; i < serverGrid.RowCount; i ++)
            {
                if (!serverGrid.Rows[i].Selected)
                {
                    continue;
                }
                serverLink.Text = serverGrid.Rows[i].Cells[0].Value.ToString();
                break;
            }

            if (loginCount == 0) {
                loginCount = 1;
            }
            launchEverquestSystemTray.Text = "Launch Everquest (" + loginCount + " logins) for " + serverLink.Text;
            Text = "EverPatch (" + loginCount + " logins) - " + serverLink.Text;
            buttonLaunch.Image = Properties.Resources.button_launch;
            if (checkAdmin.Checked && tabs.TabPages.IndexOf(tabAdmin) < 1)
            {
                Console.WriteLine("added admin");
                tabs.TabPages.Add(tabAdmin);
            }
            if (!checkAdmin.Checked && tabs.TabPages.IndexOf(tabAdmin) > 1)
            {
                Console.WriteLine("removed admin");
                tabs.TabPages.Remove(tabAdmin);
            }
           
        }

        private void Everpatch_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
            }
            else
            {
                ShowInTaskbar = true;
                progressBar.Width = Width;
            }
        }

        private void SystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!ShowInTaskbar)
            {
                ShowInTaskbar = true;
            }
        }

        private void CheckAdmin_CheckedChanged(object sender, EventArgs e)
        {
            RefreshSelections();
        }
    }
}
