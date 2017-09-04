namespace KRSClientApplication.Views
{
    partial class Management
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
            this.PalletManagingButton = new System.Windows.Forms.Button();
            this.BatchBrowsingButton = new System.Windows.Forms.Button();
            this.SkinTypeAddingButton = new System.Windows.Forms.Button();
            this.SchemeAddingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PalletManagingButton
            // 
            this.PalletManagingButton.BackColor = System.Drawing.Color.White;
            this.PalletManagingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PalletManagingButton.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PalletManagingButton.Image = global::KRSClientApplication.Properties.Resources.Поддоны;
            this.PalletManagingButton.Location = new System.Drawing.Point(1, 22);
            this.PalletManagingButton.Name = "PalletManagingButton";
            this.PalletManagingButton.Size = new System.Drawing.Size(300, 422);
            this.PalletManagingButton.TabIndex = 1;
            this.PalletManagingButton.Text = "Управление поддонами";
            this.PalletManagingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.PalletManagingButton.UseVisualStyleBackColor = false;
            this.PalletManagingButton.Click += new System.EventHandler(this.PalletManagingButtonOnClick);
            // 
            // BatchBrowsingButton
            // 
            this.BatchBrowsingButton.BackColor = System.Drawing.Color.White;
            this.BatchBrowsingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BatchBrowsingButton.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BatchBrowsingButton.Image = global::KRSClientApplication.Properties.Resources.Партия;
            this.BatchBrowsingButton.Location = new System.Drawing.Point(301, 22);
            this.BatchBrowsingButton.Name = "BatchBrowsingButton";
            this.BatchBrowsingButton.Size = new System.Drawing.Size(300, 422);
            this.BatchBrowsingButton.TabIndex = 2;
            this.BatchBrowsingButton.Text = "Просмотр партий";
            this.BatchBrowsingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BatchBrowsingButton.UseVisualStyleBackColor = false;
            this.BatchBrowsingButton.Click += new System.EventHandler(this.BatchBrowsingButtonOnClick);
            // 
            // SkinTypeAddingButton
            // 
            this.SkinTypeAddingButton.BackColor = System.Drawing.Color.White;
            this.SkinTypeAddingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SkinTypeAddingButton.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkinTypeAddingButton.Location = new System.Drawing.Point(601, 22);
            this.SkinTypeAddingButton.Name = "SkinTypeAddingButton";
            this.SkinTypeAddingButton.Size = new System.Drawing.Size(300, 422);
            this.SkinTypeAddingButton.TabIndex = 3;
            this.SkinTypeAddingButton.Text = "Добавление типа шкуры";
            this.SkinTypeAddingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SkinTypeAddingButton.UseVisualStyleBackColor = false;
            this.SkinTypeAddingButton.Click += new System.EventHandler(this.SkinTypeAddingButtonOnClick);
            // 
            // SchemeAddingButton
            // 
            this.SchemeAddingButton.BackColor = System.Drawing.Color.White;
            this.SchemeAddingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SchemeAddingButton.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SchemeAddingButton.Location = new System.Drawing.Point(901, 22);
            this.SchemeAddingButton.Name = "SchemeAddingButton";
            this.SchemeAddingButton.Size = new System.Drawing.Size(300, 422);
            this.SchemeAddingButton.TabIndex = 4;
            this.SchemeAddingButton.Text = "Добавление схемы сортировки";
            this.SchemeAddingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SchemeAddingButton.UseVisualStyleBackColor = false;
            this.SchemeAddingButton.Click += new System.EventHandler(this.SchemeAddingButtonOnClick);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 456);
            this.Controls.Add(this.SchemeAddingButton);
            this.Controls.Add(this.SkinTypeAddingButton);
            this.Controls.Add(this.BatchBrowsingButton);
            this.Controls.Add(this.PalletManagingButton);
            this.Name = "Management";
            this.Text = "Менеджер";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagingClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PalletManagingButton;
        private System.Windows.Forms.Button BatchBrowsingButton;
        private System.Windows.Forms.Button SkinTypeAddingButton;
        private System.Windows.Forms.Button SchemeAddingButton;
    }
}