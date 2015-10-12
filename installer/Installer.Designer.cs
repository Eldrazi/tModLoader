﻿namespace Installer
{
    partial class Installer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installer));
            this.install = new System.Windows.Forms.Button();
            this.devSetup = new System.Windows.Forms.Button();
            this.choosePath = new System.Windows.Forms.Button();
            this.restoreVanilla = new System.Windows.Forms.Button();
            this.restoreMod = new System.Windows.Forms.Button();
            this.setup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // install
            // 
            this.install.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.install.Location = new System.Drawing.Point(12, 41);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(260, 23);
            this.install.TabIndex = 0;
            this.install.Text = "Install tModLoader";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.Install);
            // 
            // devSetup
            // 
            this.devSetup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devSetup.Location = new System.Drawing.Point(12, 70);
            this.devSetup.Name = "devSetup";
            this.devSetup.Size = new System.Drawing.Size(260, 23);
            this.devSetup.TabIndex = 1;
            this.devSetup.Text = "Setup Modder Environment";
            this.devSetup.UseVisualStyleBackColor = true;
            this.devSetup.Click += new System.EventHandler(this.SetupDevEnv);
            // 
            // choosePath
            // 
            this.choosePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choosePath.Location = new System.Drawing.Point(12, 12);
            this.choosePath.Name = "choosePath";
            this.choosePath.Size = new System.Drawing.Size(260, 23);
            this.choosePath.TabIndex = 2;
            this.choosePath.Text = "Choose Terraria File";
            this.choosePath.UseVisualStyleBackColor = true;
            this.choosePath.Click += new System.EventHandler(this.ChoosePath);
            // 
            // restoreVanilla
            // 
            this.restoreVanilla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreVanilla.Location = new System.Drawing.Point(12, 100);
            this.restoreVanilla.Name = "restoreVanilla";
            this.restoreVanilla.Size = new System.Drawing.Size(260, 23);
            this.restoreVanilla.TabIndex = 3;
            this.restoreVanilla.Text = "Restore Vanilla Terraria";
            this.restoreVanilla.UseVisualStyleBackColor = true;
            this.restoreVanilla.Click += new System.EventHandler(this.RestoreVanilla);
            // 
            // restoreMod
            // 
            this.restoreMod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreMod.Location = new System.Drawing.Point(12, 130);
            this.restoreMod.Name = "restoreMod";
            this.restoreMod.Size = new System.Drawing.Size(260, 23);
            this.restoreMod.TabIndex = 4;
            this.restoreMod.Text = "Restore tModLoader";
            this.restoreMod.UseVisualStyleBackColor = true;
            this.restoreMod.Click += new System.EventHandler(this.RestoreMod);
            // 
            // setup
            // 
            this.setup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setup.Location = new System.Drawing.Point(12, 159);
            this.setup.Name = "setup";
            this.setup.Size = new System.Drawing.Size(260, 23);
            this.setup.TabIndex = 5;
            this.setup.Text = "Setup Resources";
            this.setup.UseVisualStyleBackColor = true;
            this.setup.Click += new System.EventHandler(this.Setup);
            // 
            // Installer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.setup);
            this.Controls.Add(this.restoreMod);
            this.Controls.Add(this.restoreVanilla);
            this.Controls.Add(this.choosePath);
            this.Controls.Add(this.devSetup);
            this.Controls.Add(this.install);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "Installer";
            this.Text = "tModLoader Installer";
            this.Load += new System.EventHandler(this.Init);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button devSetup;
        private System.Windows.Forms.Button choosePath;
        private System.Windows.Forms.Button restoreVanilla;
        private System.Windows.Forms.Button restoreMod;
        private System.Windows.Forms.Button setup;
    }
}

