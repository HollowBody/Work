namespace KRSClientApplication.Views
{
    partial class PalletView
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
            this.PalletsGrid = new System.Windows.Forms.DataGridView();
            this.ClosePalletButton = new System.Windows.Forms.Button();
            this.SendPalletButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PalletsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PalletsGrid
            // 
            this.PalletsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PalletsGrid.Location = new System.Drawing.Point(12, 12);
            this.PalletsGrid.Name = "PalletsGrid";
            this.PalletsGrid.Size = new System.Drawing.Size(811, 412);
            this.PalletsGrid.TabIndex = 0;
            // 
            // ClosePalletButton
            // 
            this.ClosePalletButton.Location = new System.Drawing.Point(12, 430);
            this.ClosePalletButton.Name = "ClosePalletButton";
            this.ClosePalletButton.Size = new System.Drawing.Size(811, 37);
            this.ClosePalletButton.TabIndex = 3;
            this.ClosePalletButton.Text = "Закрыть";
            this.ClosePalletButton.UseVisualStyleBackColor = true;
            this.ClosePalletButton.Click += new System.EventHandler(this.ClosePalletButtonOnClick);
            // 
            // SendPalletButton
            // 
            this.SendPalletButton.Location = new System.Drawing.Point(12, 430);
            this.SendPalletButton.Name = "SendPalletButton";
            this.SendPalletButton.Size = new System.Drawing.Size(811, 37);
            this.SendPalletButton.TabIndex = 4;
            this.SendPalletButton.Text = "Отправить";
            this.SendPalletButton.UseVisualStyleBackColor = true;
            this.SendPalletButton.Click += new System.EventHandler(this.SendPalletButtonOnClick);
            // 
            // PalletView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 471);
            this.Controls.Add(this.SendPalletButton);
            this.Controls.Add(this.ClosePalletButton);
            this.Controls.Add(this.PalletsGrid);
            this.Name = "PalletView";
            this.Text = "PalletView";
            ((System.ComponentModel.ISupportInitialize)(this.PalletsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PalletsGrid;
        private System.Windows.Forms.Button ClosePalletButton;
        private System.Windows.Forms.Button SendPalletButton;
    }
}