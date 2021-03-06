﻿namespace ProxyActivator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.WLanCheck = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.L_Connected = new System.Windows.Forms.Label();
            this.L_Proxy_System = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.L_Proxy_Owncloud = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.L_Proxy_Spotify = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.L_Proxy_Github = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmMitWindowsStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmNichtMitWindowsStartenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.manuellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyAktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyDeaktivierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aufUpdatesPrüfenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.VersionCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Proxy Activator";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick_1);
            // 
            // WLanCheck
            // 
            this.WLanCheck.Enabled = true;
            this.WLanCheck.Interval = 2000;
            this.WLanCheck.Tick += new System.EventHandler(this.WLanCheck_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "W-Lan Status";
            // 
            // L_Connected
            // 
            this.L_Connected.AutoSize = true;
            this.L_Connected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Connected.Location = new System.Drawing.Point(142, 20);
            this.L_Connected.Name = "L_Connected";
            this.L_Connected.Size = new System.Drawing.Size(47, 13);
            this.L_Connected.TabIndex = 1;
            this.L_Connected.Text = "Lade...";
            // 
            // L_Proxy_System
            // 
            this.L_Proxy_System.AutoSize = true;
            this.L_Proxy_System.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Proxy_System.Location = new System.Drawing.Point(142, 49);
            this.L_Proxy_System.Name = "L_Proxy_System";
            this.L_Proxy_System.Size = new System.Drawing.Size(47, 13);
            this.L_Proxy_System.TabIndex = 3;
            this.L_Proxy_System.Text = "Lade...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Systemproxy Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Created by Marcel Kallen ( Fursystems.de )";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.L_Proxy_Owncloud);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.L_Proxy_Spotify);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.L_Proxy_Github);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.L_Connected);
            this.groupBox1.Controls.Add(this.L_Proxy_System);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informationen";
            // 
            // L_Proxy_Owncloud
            // 
            this.L_Proxy_Owncloud.AutoSize = true;
            this.L_Proxy_Owncloud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Proxy_Owncloud.Location = new System.Drawing.Point(142, 88);
            this.L_Proxy_Owncloud.Name = "L_Proxy_Owncloud";
            this.L_Proxy_Owncloud.Size = new System.Drawing.Size(47, 13);
            this.L_Proxy_Owncloud.TabIndex = 9;
            this.L_Proxy_Owncloud.Text = "Lade...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Owncloud Proxy Status";
            // 
            // L_Proxy_Spotify
            // 
            this.L_Proxy_Spotify.AutoSize = true;
            this.L_Proxy_Spotify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Proxy_Spotify.Location = new System.Drawing.Point(142, 75);
            this.L_Proxy_Spotify.Name = "L_Proxy_Spotify";
            this.L_Proxy_Spotify.Size = new System.Drawing.Size(47, 13);
            this.L_Proxy_Spotify.TabIndex = 7;
            this.L_Proxy_Spotify.Text = "Lade...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Spotify Proxy Status";
            // 
            // L_Proxy_Github
            // 
            this.L_Proxy_Github.AutoSize = true;
            this.L_Proxy_Github.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Proxy_Github.Location = new System.Drawing.Point(142, 62);
            this.L_Proxy_Github.Name = "L_Proxy_Github";
            this.L_Proxy_Github.Size = new System.Drawing.Size(47, 13);
            this.L_Proxy_Github.TabIndex = 5;
            this.L_Proxy_Github.Text = "Lade...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Github Proxy Status";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmMitWindowsStartenToolStripMenuItem,
            this.programmNichtMitWindowsStartenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // programmMitWindowsStartenToolStripMenuItem
            // 
            this.programmMitWindowsStartenToolStripMenuItem.Name = "programmMitWindowsStartenToolStripMenuItem";
            this.programmMitWindowsStartenToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.programmMitWindowsStartenToolStripMenuItem.Text = "Programm mit Windows starten";
            this.programmMitWindowsStartenToolStripMenuItem.Click += new System.EventHandler(this.programmMitWindowsStartenToolStripMenuItem_Click);
            // 
            // programmNichtMitWindowsStartenToolStripMenuItem
            // 
            this.programmNichtMitWindowsStartenToolStripMenuItem.Name = "programmNichtMitWindowsStartenToolStripMenuItem";
            this.programmNichtMitWindowsStartenToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.programmNichtMitWindowsStartenToolStripMenuItem.Text = "Automatischen Programmstart löschen";
            this.programmNichtMitWindowsStartenToolStripMenuItem.Click += new System.EventHandler(this.programmNichtMitWindowsStartenToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.manuellToolStripMenuItem,
            this.überToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(810, 24);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // manuellToolStripMenuItem
            // 
            this.manuellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proxyAktivierenToolStripMenuItem,
            this.proxyDeaktivierenToolStripMenuItem,
            this.aufUpdatesPrüfenToolStripMenuItem});
            this.manuellToolStripMenuItem.Name = "manuellToolStripMenuItem";
            this.manuellToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manuellToolStripMenuItem.Text = "Manuell";
            this.manuellToolStripMenuItem.Click += new System.EventHandler(this.manuellToolStripMenuItem_Click);
            // 
            // proxyAktivierenToolStripMenuItem
            // 
            this.proxyAktivierenToolStripMenuItem.Name = "proxyAktivierenToolStripMenuItem";
            this.proxyAktivierenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.proxyAktivierenToolStripMenuItem.Text = "Proxy aktivieren";
            this.proxyAktivierenToolStripMenuItem.Click += new System.EventHandler(this.proxyAktivierenToolStripMenuItem_Click);
            // 
            // proxyDeaktivierenToolStripMenuItem
            // 
            this.proxyDeaktivierenToolStripMenuItem.Name = "proxyDeaktivierenToolStripMenuItem";
            this.proxyDeaktivierenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.proxyDeaktivierenToolStripMenuItem.Text = "Proxy deaktivieren";
            this.proxyDeaktivierenToolStripMenuItem.Click += new System.EventHandler(this.proxyDeaktivierenToolStripMenuItem_Click);
            // 
            // aufUpdatesPrüfenToolStripMenuItem
            // 
            this.aufUpdatesPrüfenToolStripMenuItem.Name = "aufUpdatesPrüfenToolStripMenuItem";
            this.aufUpdatesPrüfenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aufUpdatesPrüfenToolStripMenuItem.Text = "Auf Updates prüfen";
            this.aufUpdatesPrüfenToolStripMenuItem.Click += new System.EventHandler(this.aufUpdatesPrüfenToolStripMenuItem_Click);
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem1});
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.überToolStripMenuItem.Text = "Hilfe";
            // 
            // überToolStripMenuItem1
            // 
            this.überToolStripMenuItem1.Name = "überToolStripMenuItem1";
            this.überToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
            this.überToolStripMenuItem1.Text = "Über";
            this.überToolStripMenuItem1.Click += new System.EventHandler(this.überToolStripMenuItem1_Click);
            // 
            // VersionCheckTimer
            // 
            this.VersionCheckTimer.Enabled = true;
            this.VersionCheckTimer.Interval = 600000;
            this.VersionCheckTimer.Tick += new System.EventHandler(this.VersionCheckTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(810, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(316, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 211);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Access Points";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 185);
            this.dataGridView1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "No defined accesspoints yet.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 265);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Proxy Activator";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer WLanCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Connected;
        private System.Windows.Forms.Label L_Proxy_System;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmMitWindowsStartenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmNichtMitWindowsStartenToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem1;
        private System.Windows.Forms.Label L_Proxy_Github;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L_Proxy_Spotify;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label L_Proxy_Owncloud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem manuellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyAktivierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyDeaktivierenToolStripMenuItem;
        private System.Windows.Forms.Timer VersionCheckTimer;
        private System.Windows.Forms.ToolStripMenuItem aufUpdatesPrüfenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
    }
}

