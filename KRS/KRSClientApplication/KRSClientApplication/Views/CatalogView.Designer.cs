namespace KRSClientApplication.Views
{
    partial class CatalogView
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
            this.CatalogsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CatalogsGrid
            // 
            this.CatalogsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatalogsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CatalogsGrid.Location = new System.Drawing.Point(0, 0);
            this.CatalogsGrid.Name = "CatalogsGrid";
            this.CatalogsGrid.Size = new System.Drawing.Size(1048, 458);
            this.CatalogsGrid.TabIndex = 0;
            // 
            // CatalogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 458);
            this.Controls.Add(this.CatalogsGrid);
            this.Name = "CatalogView";
            this.Text = "CatalogView";
            ((System.ComponentModel.ISupportInitialize)(this.CatalogsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CatalogsGrid;
    }
}