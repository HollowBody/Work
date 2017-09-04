namespace KRSClientApplication.Views
{
    partial class SkinTypeAdding
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
            this.SkinTypeLabel = new System.Windows.Forms.Label();
            this.MaxWeightLabel = new System.Windows.Forms.Label();
            this.MinWeightLabel = new System.Windows.Forms.Label();
            this.MaxCountSkinsLabel = new System.Windows.Forms.Label();
            this.MaxCountSkinsField = new System.Windows.Forms.TextBox();
            this.MinWeightField = new System.Windows.Forms.TextBox();
            this.MaxWeightField = new System.Windows.Forms.TextBox();
            this.SkinTypeField = new System.Windows.Forms.TextBox();
            this.SkinTypeAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SkinTypeLabel
            // 
            this.SkinTypeLabel.AutoSize = true;
            this.SkinTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.SkinTypeLabel.Name = "SkinTypeLabel";
            this.SkinTypeLabel.Size = new System.Drawing.Size(83, 13);
            this.SkinTypeLabel.TabIndex = 0;
            this.SkinTypeLabel.Text = "Наименование";
            // 
            // MaxWeightLabel
            // 
            this.MaxWeightLabel.AutoSize = true;
            this.MaxWeightLabel.Location = new System.Drawing.Point(12, 89);
            this.MaxWeightLabel.Name = "MaxWeightLabel";
            this.MaxWeightLabel.Size = new System.Drawing.Size(107, 13);
            this.MaxWeightLabel.TabIndex = 1;
            this.MaxWeightLabel.Text = "Максимальный вес";
            // 
            // MinWeightLabel
            // 
            this.MinWeightLabel.AutoSize = true;
            this.MinWeightLabel.Location = new System.Drawing.Point(12, 49);
            this.MinWeightLabel.Name = "MinWeightLabel";
            this.MinWeightLabel.Size = new System.Drawing.Size(101, 13);
            this.MinWeightLabel.TabIndex = 2;
            this.MinWeightLabel.Text = "Минимальный вес";
            // 
            // MaxCountSkinsLabel
            // 
            this.MaxCountSkinsLabel.AutoSize = true;
            this.MaxCountSkinsLabel.Location = new System.Drawing.Point(12, 129);
            this.MaxCountSkinsLabel.Name = "MaxCountSkinsLabel";
            this.MaxCountSkinsLabel.Size = new System.Drawing.Size(173, 13);
            this.MaxCountSkinsLabel.TabIndex = 3;
            this.MaxCountSkinsLabel.Text = "Максимальное количество шкур";
            // 
            // MaxCountSkinsField
            // 
            this.MaxCountSkinsField.Location = new System.Drawing.Point(192, 126);
            this.MaxCountSkinsField.Name = "MaxCountSkinsField";
            this.MaxCountSkinsField.Size = new System.Drawing.Size(197, 20);
            this.MaxCountSkinsField.TabIndex = 4;
            // 
            // MinWeightField
            // 
            this.MinWeightField.Location = new System.Drawing.Point(192, 46);
            this.MinWeightField.Name = "MinWeightField";
            this.MinWeightField.Size = new System.Drawing.Size(197, 20);
            this.MinWeightField.TabIndex = 2;
            // 
            // MaxWeightField
            // 
            this.MaxWeightField.Location = new System.Drawing.Point(192, 86);
            this.MaxWeightField.Name = "MaxWeightField";
            this.MaxWeightField.Size = new System.Drawing.Size(197, 20);
            this.MaxWeightField.TabIndex = 3;
            // 
            // SkinTypeField
            // 
            this.SkinTypeField.Location = new System.Drawing.Point(192, 6);
            this.SkinTypeField.Name = "SkinTypeField";
            this.SkinTypeField.Size = new System.Drawing.Size(197, 20);
            this.SkinTypeField.TabIndex = 1;
            // 
            // SkinTypeAddButton
            // 
            this.SkinTypeAddButton.Location = new System.Drawing.Point(165, 165);
            this.SkinTypeAddButton.Name = "SkinTypeAddButton";
            this.SkinTypeAddButton.Size = new System.Drawing.Size(75, 25);
            this.SkinTypeAddButton.TabIndex = 5;
            this.SkinTypeAddButton.Text = "Добавить";
            this.SkinTypeAddButton.UseVisualStyleBackColor = true;
            this.SkinTypeAddButton.Click += new System.EventHandler(this.SkinTypeAddButtonOnClick);
            // 
            // SkinTypeAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 201);
            this.Controls.Add(this.SkinTypeAddButton);
            this.Controls.Add(this.SkinTypeField);
            this.Controls.Add(this.MaxWeightField);
            this.Controls.Add(this.MinWeightField);
            this.Controls.Add(this.MaxCountSkinsField);
            this.Controls.Add(this.MaxCountSkinsLabel);
            this.Controls.Add(this.MinWeightLabel);
            this.Controls.Add(this.MaxWeightLabel);
            this.Controls.Add(this.SkinTypeLabel);
            this.Name = "SkinTypeAdding";
            this.Text = "Добавление типа шкуры";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SkinTypeAddingClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SkinTypeLabel;
        private System.Windows.Forms.Label MaxWeightLabel;
        private System.Windows.Forms.Label MinWeightLabel;
        private System.Windows.Forms.Label MaxCountSkinsLabel;
        private System.Windows.Forms.TextBox MaxCountSkinsField;
        private System.Windows.Forms.TextBox MinWeightField;
        private System.Windows.Forms.TextBox MaxWeightField;
        private System.Windows.Forms.TextBox SkinTypeField;
        private System.Windows.Forms.Button SkinTypeAddButton;
    }
}