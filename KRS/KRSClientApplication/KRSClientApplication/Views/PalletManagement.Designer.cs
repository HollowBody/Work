namespace KRSClientApplication.Views
{
    partial class PalletManagement
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
            this.PalletManagementMenu = new System.Windows.Forms.MenuStrip();
            this.OpenedMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ClosedMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SendMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.PalletManagementMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PalletManagementMenu
            // 
            this.PalletManagementMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenedMenuButton,
            this.ClosedMenuButton,
            this.SendMenuButton});
            this.PalletManagementMenu.Location = new System.Drawing.Point(0, 0);
            this.PalletManagementMenu.Name = "PalletManagementMenu";
            this.PalletManagementMenu.Size = new System.Drawing.Size(1132, 24);
            this.PalletManagementMenu.TabIndex = 1;
            this.PalletManagementMenu.Text = "Меню";
            // 
            // OpenedMenuButton
            // 
            this.OpenedMenuButton.Name = "OpenedMenuButton";
            this.OpenedMenuButton.Size = new System.Drawing.Size(75, 20);
            this.OpenedMenuButton.Text = "Открытые";
            this.OpenedMenuButton.Click += new System.EventHandler(this.OpenedMenuButtonOnClick);
            // 
            // ClosedMenuButton
            // 
            this.ClosedMenuButton.Name = "ClosedMenuButton";
            this.ClosedMenuButton.Size = new System.Drawing.Size(74, 20);
            this.ClosedMenuButton.Text = "Закрытые";
            this.ClosedMenuButton.Click += new System.EventHandler(this.ClosedMenuButtonOnClick);
            // 
            // SendMenuButton
            // 
            this.SendMenuButton.Name = "SendMenuButton";
            this.SendMenuButton.Size = new System.Drawing.Size(101, 20);
            this.SendMenuButton.Text = "Отправленные";
            this.SendMenuButton.Click += new System.EventHandler(this.SendMenuButtonOnClick);
            // 
            // PalletManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 473);
            this.Controls.Add(this.PalletManagementMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.PalletManagementMenu;
            this.Name = "PalletManagement";
            this.Text = "Управление поддонами";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PalletManagementMenu.ResumeLayout(false);
            this.PalletManagementMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip PalletManagementMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenedMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ClosedMenuButton;
        private System.Windows.Forms.ToolStripMenuItem SendMenuButton;
    }
}