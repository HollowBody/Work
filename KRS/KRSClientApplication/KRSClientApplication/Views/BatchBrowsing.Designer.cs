namespace KRSClientApplication.Views
{
    partial class BatchBrowsing
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
            this.ProvidersList = new System.Windows.Forms.ComboBox();
            this.ProvidersLabel = new System.Windows.Forms.Label();
            this.BatchesInformationGrid = new System.Windows.Forms.DataGridView();
            this.SkinsInformationGrid = new System.Windows.Forms.DataGridView();
            this.ShowSkinsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BatchesInformationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkinsInformationGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProvidersList
            // 
            this.ProvidersList.FormattingEnabled = true;
            this.ProvidersList.Location = new System.Drawing.Point(141, 9);
            this.ProvidersList.Name = "ProvidersList";
            this.ProvidersList.Size = new System.Drawing.Size(436, 21);
            this.ProvidersList.TabIndex = 0;
            this.ProvidersList.ValueMemberChanged += new System.EventHandler(this.ProvidersListOnProviderChanged);
            this.ProvidersList.TextChanged += new System.EventHandler(this.ProvidersListOnProviderChanged);
            // 
            // ProvidersLabel
            // 
            this.ProvidersLabel.AutoSize = true;
            this.ProvidersLabel.Location = new System.Drawing.Point(13, 12);
            this.ProvidersLabel.Name = "ProvidersLabel";
            this.ProvidersLabel.Size = new System.Drawing.Size(122, 13);
            this.ProvidersLabel.TabIndex = 1;
            this.ProvidersLabel.Text = "Выберите поставщика";
            // 
            // BatchesInformationGrid
            // 
            this.BatchesInformationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BatchesInformationGrid.Location = new System.Drawing.Point(16, 36);
            this.BatchesInformationGrid.Name = "BatchesInformationGrid";
            this.BatchesInformationGrid.Size = new System.Drawing.Size(987, 244);
            this.BatchesInformationGrid.TabIndex = 2;
            // 
            // SkinsInformationGrid
            // 
            this.SkinsInformationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SkinsInformationGrid.Location = new System.Drawing.Point(16, 330);
            this.SkinsInformationGrid.Name = "SkinsInformationGrid";
            this.SkinsInformationGrid.Size = new System.Drawing.Size(987, 244);
            this.SkinsInformationGrid.TabIndex = 3;
            // 
            // ShowSkinsButton
            // 
            this.ShowSkinsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowSkinsButton.Location = new System.Drawing.Point(16, 286);
            this.ShowSkinsButton.Name = "ShowSkinsButton";
            this.ShowSkinsButton.Size = new System.Drawing.Size(987, 38);
            this.ShowSkinsButton.TabIndex = 4;
            this.ShowSkinsButton.Text = "Показать шкуры в партии";
            this.ShowSkinsButton.UseVisualStyleBackColor = true;
            this.ShowSkinsButton.Click += new System.EventHandler(this.ShowSkinsButtonOnClick);
            // 
            // BatchBrowsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 580);
            this.Controls.Add(this.ShowSkinsButton);
            this.Controls.Add(this.SkinsInformationGrid);
            this.Controls.Add(this.BatchesInformationGrid);
            this.Controls.Add(this.ProvidersLabel);
            this.Controls.Add(this.ProvidersList);
            this.Name = "BatchBrowsing";
            this.Text = "Просмотр партий";
            this.Load += new System.EventHandler(this.BatchBrowsingOnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.BatchesInformationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SkinsInformationGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProvidersList;
        private System.Windows.Forms.Label ProvidersLabel;
        private System.Windows.Forms.DataGridView BatchesInformationGrid;
        private System.Windows.Forms.DataGridView SkinsInformationGrid;
        private System.Windows.Forms.Button ShowSkinsButton;
    }
}