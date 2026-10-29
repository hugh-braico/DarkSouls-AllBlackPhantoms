namespace DarkSoulsAllBlackPhantoms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblGamePath = new System.Windows.Forms.Label();
            this.txtGamePath = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.checkBoxCosmetics = new System.Windows.Forms.CheckBox();
            this.btnOpenFolderDialog = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxBosses = new System.Windows.Forms.CheckBox();
            this.checkBoxNPCs = new System.Windows.Forms.CheckBox();
            this.checkBoxRegularEnemies = new System.Windows.Forms.CheckBox();
            this.gbWeaponCategory = new System.Windows.Forms.GroupBox();
            this.checkBoxBuffs = new System.Windows.Forms.CheckBox();
            this.radioButtonRemastered = new System.Windows.Forms.RadioButton();
            this.radioButtonPTDE = new System.Windows.Forms.RadioButton();
            this.groupGameVersion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbWeaponCategory.SuspendLayout();
            this.groupGameVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGamePath
            // 
            this.lblGamePath.AutoSize = true;
            this.lblGamePath.Location = new System.Drawing.Point(8, 9);
            this.lblGamePath.Name = "lblGamePath";
            this.lblGamePath.Size = new System.Drawing.Size(63, 13);
            this.lblGamePath.TabIndex = 2;
            this.lblGamePath.Text = "Game Path:";
            // 
            // txtGamePath
            // 
            this.txtGamePath.Location = new System.Drawing.Point(77, 6);
            this.txtGamePath.Name = "txtGamePath";
            this.txtGamePath.Size = new System.Drawing.Size(582, 20);
            this.txtGamePath.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(270, 203);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(140, 45);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Go";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(435, 194);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(243, 64);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "label1";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMessage.Visible = false;
            // 
            // checkBoxCosmetics
            // 
            this.checkBoxCosmetics.AutoSize = true;
            this.checkBoxCosmetics.Checked = true;
            this.checkBoxCosmetics.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCosmetics.Enabled = false;
            this.checkBoxCosmetics.Location = new System.Drawing.Point(15, 42);
            this.checkBoxCosmetics.Name = "checkBoxCosmetics";
            this.checkBoxCosmetics.Size = new System.Drawing.Size(459, 17);
            this.checkBoxCosmetics.TabIndex = 13;
            this.checkBoxCosmetics.Text = "Apply Black Phantom cosmetic effects (dark shader, ghostly sounds, disappearing o" +
    "n death)";
            this.checkBoxCosmetics.UseVisualStyleBackColor = true;
            // 
            // btnOpenFolderDialog
            // 
            this.btnOpenFolderDialog.Location = new System.Drawing.Point(665, 6);
            this.btnOpenFolderDialog.Name = "btnOpenFolderDialog";
            this.btnOpenFolderDialog.Size = new System.Drawing.Size(28, 20);
            this.btnOpenFolderDialog.TabIndex = 21;
            this.btnOpenFolderDialog.Text = "...";
            this.tooltip.SetToolTip(this.btnOpenFolderDialog, "Open Folder");
            this.btnOpenFolderDialog.UseVisualStyleBackColor = true;
            this.btnOpenFolderDialog.Click += new System.EventHandler(this.btnOpenFolderDialog_Click);
            // 
            // tooltip
            // 
            this.tooltip.AutoPopDelay = 32767;
            this.tooltip.InitialDelay = 500;
            this.tooltip.ReshowDelay = 100;
            // 
            // checkBoxBosses
            // 
            this.checkBoxBosses.AutoSize = true;
            this.checkBoxBosses.Checked = true;
            this.checkBoxBosses.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBosses.Enabled = false;
            this.checkBoxBosses.Location = new System.Drawing.Point(15, 88);
            this.checkBoxBosses.Name = "checkBoxBosses";
            this.checkBoxBosses.Size = new System.Drawing.Size(184, 17);
            this.checkBoxBosses.TabIndex = 24;
            this.checkBoxBosses.Text = "Turn bosses into Black Phantoms";
            this.checkBoxBosses.UseVisualStyleBackColor = true;
            // 
            // checkBoxNPCs
            // 
            this.checkBoxNPCs.AutoSize = true;
            this.checkBoxNPCs.Checked = true;
            this.checkBoxNPCs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNPCs.Enabled = false;
            this.checkBoxNPCs.Location = new System.Drawing.Point(15, 111);
            this.checkBoxNPCs.Name = "checkBoxNPCs";
            this.checkBoxNPCs.Size = new System.Drawing.Size(178, 17);
            this.checkBoxNPCs.TabIndex = 25;
            this.checkBoxNPCs.Text = "Turn NPCs into Black Phantoms";
            this.checkBoxNPCs.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegularEnemies
            // 
            this.checkBoxRegularEnemies.AutoSize = true;
            this.checkBoxRegularEnemies.Checked = true;
            this.checkBoxRegularEnemies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRegularEnemies.Enabled = false;
            this.checkBoxRegularEnemies.Location = new System.Drawing.Point(15, 65);
            this.checkBoxRegularEnemies.Name = "checkBoxRegularEnemies";
            this.checkBoxRegularEnemies.Size = new System.Drawing.Size(225, 17);
            this.checkBoxRegularEnemies.TabIndex = 27;
            this.checkBoxRegularEnemies.Text = "Turn regular enemies into Black Phantoms";
            this.checkBoxRegularEnemies.UseVisualStyleBackColor = true;
            // 
            // gbWeaponCategory
            // 
            this.gbWeaponCategory.AutoSize = true;
            this.gbWeaponCategory.Controls.Add(this.label1);
            this.gbWeaponCategory.Controls.Add(this.checkBoxRegularEnemies);
            this.gbWeaponCategory.Controls.Add(this.checkBoxBuffs);
            this.gbWeaponCategory.Controls.Add(this.checkBoxNPCs);
            this.gbWeaponCategory.Controls.Add(this.checkBoxBosses);
            this.gbWeaponCategory.Controls.Add(this.checkBoxCosmetics);
            this.gbWeaponCategory.Location = new System.Drawing.Point(8, 32);
            this.gbWeaponCategory.Name = "gbWeaponCategory";
            this.gbWeaponCategory.Size = new System.Drawing.Size(685, 147);
            this.gbWeaponCategory.TabIndex = 32;
            this.gbWeaponCategory.TabStop = false;
            this.gbWeaponCategory.Text = "Settings:";
            this.gbWeaponCategory.Enter += new System.EventHandler(this.gbWeaponCategory_Enter);
            // 
            // checkBoxBuffs
            // 
            this.checkBoxBuffs.AutoSize = true;
            this.checkBoxBuffs.Checked = true;
            this.checkBoxBuffs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBuffs.Enabled = false;
            this.checkBoxBuffs.Location = new System.Drawing.Point(15, 19);
            this.checkBoxBuffs.Name = "checkBoxBuffs";
            this.checkBoxBuffs.Size = new System.Drawing.Size(327, 17);
            this.checkBoxBuffs.TabIndex = 26;
            this.checkBoxBuffs.Text = "Apply Black Phantom buffs (bonus stats and respawn on reload)";
            this.checkBoxBuffs.UseVisualStyleBackColor = true;
            this.checkBoxBuffs.CheckedChanged += new System.EventHandler(this.checkBoxBuffs_CheckedChanged);
            // 
            // radioButtonRemastered
            // 
            this.radioButtonRemastered.AutoSize = true;
            this.radioButtonRemastered.Checked = true;
            this.radioButtonRemastered.Location = new System.Drawing.Point(18, 46);
            this.radioButtonRemastered.Name = "radioButtonRemastered";
            this.radioButtonRemastered.Size = new System.Drawing.Size(82, 17);
            this.radioButtonRemastered.TabIndex = 28;
            this.radioButtonRemastered.TabStop = true;
            this.radioButtonRemastered.Text = "Remastered";
            this.radioButtonRemastered.UseVisualStyleBackColor = true;
            this.radioButtonRemastered.CheckedChanged += new System.EventHandler(this.radioButtonRemastered_CheckedChanged);
            // 
            // radioButtonPTDE
            // 
            this.radioButtonPTDE.AutoSize = true;
            this.radioButtonPTDE.Location = new System.Drawing.Point(18, 23);
            this.radioButtonPTDE.Name = "radioButtonPTDE";
            this.radioButtonPTDE.Size = new System.Drawing.Size(54, 17);
            this.radioButtonPTDE.TabIndex = 29;
            this.radioButtonPTDE.Text = "PTDE";
            this.radioButtonPTDE.UseVisualStyleBackColor = true;
            this.radioButtonPTDE.CheckedChanged += new System.EventHandler(this.radioButtonPTDE_CheckedChanged);
            // 
            // groupGameVersion
            // 
            this.groupGameVersion.Controls.Add(this.radioButtonPTDE);
            this.groupGameVersion.Controls.Add(this.radioButtonRemastered);
            this.groupGameVersion.Location = new System.Drawing.Point(8, 185);
            this.groupGameVersion.Name = "groupGameVersion";
            this.groupGameVersion.Size = new System.Drawing.Size(240, 82);
            this.groupGameVersion.TabIndex = 30;
            this.groupGameVersion.TabStop = false;
            this.groupGameVersion.Text = "Game version:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "(BETA: options all enabled, disabling is WIP)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 285);
            this.Controls.Add(this.groupGameVersion);
            this.Controls.Add(this.btnOpenFolderDialog);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtGamePath);
            this.Controls.Add(this.lblGamePath);
            this.Controls.Add(this.gbWeaponCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Dark Souls - All Black Phantoms (by SeaJay)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbWeaponCategory.ResumeLayout(false);
            this.gbWeaponCategory.PerformLayout();
            this.groupGameVersion.ResumeLayout(false);
            this.groupGameVersion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGamePath;
        private System.Windows.Forms.TextBox txtGamePath;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.CheckBox checkBoxCosmetics;
        private System.Windows.Forms.Button btnOpenFolderDialog;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.GroupBox gbWeaponCategory;
        private System.Windows.Forms.CheckBox checkBoxNPCs;
        private System.Windows.Forms.CheckBox checkBoxBosses;
        private System.Windows.Forms.CheckBox checkBoxRegularEnemies;
        private System.Windows.Forms.CheckBox checkBoxBuffs;
        private System.Windows.Forms.RadioButton radioButtonPTDE;
        private System.Windows.Forms.RadioButton radioButtonRemastered;
        private System.Windows.Forms.GroupBox groupGameVersion;
        private System.Windows.Forms.Label label1;
    }
}

