namespace KRSClientApplication.Views
{
    partial class SelectorMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectorMenu));
            this.SortingButton = new System.Windows.Forms.Button();
            this.CostingButton = new System.Windows.Forms.Button();
            this.ManagementButton = new System.Windows.Forms.Button();
            this.SelectorTopMenu = new System.Windows.Forms.MenuStrip();
            this.ФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CatalogsButton = new System.Windows.Forms.Button();
            this.SelectorTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SortingButton
            // 
            this.SortingButton.BackColor = System.Drawing.Color.White;
            this.SortingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SortingButton.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortingButton.Image = global::KRSClientApplication.Properties.Resources.Погрузчик;
            this.SortingButton.Location = new System.Drawing.Point(-1, 27);
            this.SortingButton.Name = "SortingButton";
            this.SortingButton.Size = new System.Drawing.Size(300, 422);
            this.SortingButton.TabIndex = 0;
            this.SortingButton.Text = "Сортировка";
            this.SortingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SortingButton.UseVisualStyleBackColor = false;
            this.SortingButton.Click += new System.EventHandler(this.SortingButtonOnClick);
            // 
            // CostingButton
            // 
            this.CostingButton.BackColor = System.Drawing.Color.White;
            this.CostingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CostingButton.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostingButton.Image = global::KRSClientApplication.Properties.Resources.Монетки;
            this.CostingButton.Location = new System.Drawing.Point(299, 27);
            this.CostingButton.Name = "CostingButton";
            this.CostingButton.Size = new System.Drawing.Size(300, 422);
            this.CostingButton.TabIndex = 1;
            this.CostingButton.Text = "Расценка";
            this.CostingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CostingButton.UseVisualStyleBackColor = false;
            this.CostingButton.Click += new System.EventHandler(this.CostingButtonOnClick);
            // 
            // ManagementButton
            // 
            this.ManagementButton.BackColor = System.Drawing.Color.White;
            this.ManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ManagementButton.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManagementButton.Image = global::KRSClientApplication.Properties.Resources.Управление;
            this.ManagementButton.Location = new System.Drawing.Point(599, 27);
            this.ManagementButton.Name = "ManagementButton";
            this.ManagementButton.Size = new System.Drawing.Size(300, 422);
            this.ManagementButton.TabIndex = 2;
            this.ManagementButton.Text = "Управление";
            this.ManagementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ManagementButton.UseVisualStyleBackColor = false;
            this.ManagementButton.Click += new System.EventHandler(this.ManagingButtonOnClick);
            // 
            // SelectorTopMenu
            // 
            this.SelectorTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ФайлToolStripMenuItem,
            this.AboutButton});
            this.SelectorTopMenu.Location = new System.Drawing.Point(0, 0);
            this.SelectorTopMenu.Name = "SelectorTopMenu";
            this.SelectorTopMenu.Size = new System.Drawing.Size(1199, 24);
            this.SelectorTopMenu.TabIndex = 3;
            this.SelectorTopMenu.Text = "SelectorTopMenu";
            // 
            // ФайлToolStripMenuItem
            // 
            this.ФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.ФайлToolStripMenuItem.Name = "ФайлToolStripMenuItem";
            this.ФайлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ФайлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // AboutButton
            // 
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(65, 20);
            this.AboutButton.Text = "Справка";
            this.AboutButton.Click += new System.EventHandler(this.AboutButtonOnClick);
            // 
            // CatalogsButton
            // 
            this.CatalogsButton.BackColor = System.Drawing.Color.White;
            this.CatalogsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CatalogsButton.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatalogsButton.Image = global::KRSClientApplication.Properties.Resources.Справочник;
            this.CatalogsButton.Location = new System.Drawing.Point(899, 27);
            this.CatalogsButton.Name = "CatalogsButton";
            this.CatalogsButton.Size = new System.Drawing.Size(300, 422);
            this.CatalogsButton.TabIndex = 4;
            this.CatalogsButton.Text = "Справочники";
            this.CatalogsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.CatalogsButton.UseVisualStyleBackColor = false;
            this.CatalogsButton.Click += new System.EventHandler(this.CatalogsButtonOnClick);
            // 
            // SelectorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 451);
            this.Controls.Add(this.CatalogsButton);
            this.Controls.Add(this.ManagementButton);
            this.Controls.Add(this.CostingButton);
            this.Controls.Add(this.SortingButton);
            this.Controls.Add(this.SelectorTopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.SelectorTopMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1215, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1215, 490);
            this.Name = "SelectorMenu";
            this.Text = "Учет сырья КРС";
            this.SelectorTopMenu.ResumeLayout(false);
            this.SelectorTopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SortingButton;
        private System.Windows.Forms.Button CostingButton;
        private System.Windows.Forms.Button ManagementButton;
        private System.Windows.Forms.MenuStrip SelectorTopMenu;
        private System.Windows.Forms.ToolStripMenuItem ФайлToolStripMenuItem;
        private System.Windows.Forms.Button CatalogsButton;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
    }
}

