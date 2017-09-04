namespace KRSClientApplication.Views
{
    partial class CatalogsMDI
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
            this.CatalogsMenu = new System.Windows.Forms.MenuStrip();
            this.CatalogsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProvidersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdresseesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SkinTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SchemesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigurationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CatalogsMenu
            // 
            this.CatalogsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CatalogsMenuItem});
            this.CatalogsMenu.Location = new System.Drawing.Point(0, 0);
            this.CatalogsMenu.Name = "CatalogsMenu";
            this.CatalogsMenu.Size = new System.Drawing.Size(912, 24);
            this.CatalogsMenu.TabIndex = 5;
            this.CatalogsMenu.Text = "menuStrip1";
            // 
            // CatalogsMenuItem
            // 
            this.CatalogsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProvidersMenuItem,
            this.AdresseesMenuItem,
            this.SkinTypeMenuItem,
            this.SchemesMenuItem,
            this.ConfigurationsMenuItem});
            this.CatalogsMenuItem.Name = "CatalogsMenuItem";
            this.CatalogsMenuItem.Size = new System.Drawing.Size(94, 20);
            this.CatalogsMenuItem.Text = "Справочники";
            // 
            // ProvidersMenuItem
            // 
            this.ProvidersMenuItem.Name = "ProvidersMenuItem";
            this.ProvidersMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ProvidersMenuItem.Text = "Поставщики";
            this.ProvidersMenuItem.Click += new System.EventHandler(this.ProvidersMenuItemOnClick);
            // 
            // AdresseesMenuItem
            // 
            this.AdresseesMenuItem.Name = "AdresseesMenuItem";
            this.AdresseesMenuItem.Size = new System.Drawing.Size(179, 22);
            this.AdresseesMenuItem.Text = "Получатели";
            this.AdresseesMenuItem.Click += new System.EventHandler(this.AdresseesMenuItemOnClick);
            // 
            // SkinTypeMenuItem
            // 
            this.SkinTypeMenuItem.Name = "SkinTypeMenuItem";
            this.SkinTypeMenuItem.Size = new System.Drawing.Size(179, 22);
            this.SkinTypeMenuItem.Text = "Типы шкур";
            this.SkinTypeMenuItem.Click += new System.EventHandler(this.SkinTypeMenuItemOnClick);
            // 
            // SchemesMenuItem
            // 
            this.SchemesMenuItem.Name = "SchemesMenuItem";
            this.SchemesMenuItem.Size = new System.Drawing.Size(179, 22);
            this.SchemesMenuItem.Text = "Схемы сортировки";
            this.SchemesMenuItem.Click += new System.EventHandler(this.SchemesMenuItemOnClick);
            // 
            // ConfigurationsMenuItem
            // 
            this.ConfigurationsMenuItem.Name = "ConfigurationsMenuItem";
            this.ConfigurationsMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ConfigurationsMenuItem.Text = "Конфигурации";
            this.ConfigurationsMenuItem.Click += new System.EventHandler(this.ConfigurationsMenuItemOnClick);
            // 
            // CatalogsMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 520);
            this.Controls.Add(this.CatalogsMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.CatalogsMenu;
            this.Name = "CatalogsMDI";
            this.Text = "Справочники";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CatalogsClosing);
            this.CatalogsMenu.ResumeLayout(false);
            this.CatalogsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip CatalogsMenu;
        private System.Windows.Forms.ToolStripMenuItem CatalogsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProvidersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdresseesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SkinTypeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SchemesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConfigurationsMenuItem;
    }
}