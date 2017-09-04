namespace KRSClientApplication.Views
{
    partial class SortingSchemeAdding
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
            this.SkinTypeCheckList = new System.Windows.Forms.CheckedListBox();
            this.SchemeAddButton = new System.Windows.Forms.Button();
            this.SortingSchemeLabel = new System.Windows.Forms.Label();
            this.SortingSchemeField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SkinTypeCheckList
            // 
            this.SkinTypeCheckList.FormattingEnabled = true;
            this.SkinTypeCheckList.Location = new System.Drawing.Point(12, 45);
            this.SkinTypeCheckList.Name = "SkinTypeCheckList";
            this.SkinTypeCheckList.Size = new System.Drawing.Size(431, 379);
            this.SkinTypeCheckList.TabIndex = 0;
            // 
            // SchemeAddButton
            // 
            this.SchemeAddButton.Location = new System.Drawing.Point(12, 426);
            this.SchemeAddButton.Name = "SchemeAddButton";
            this.SchemeAddButton.Size = new System.Drawing.Size(431, 40);
            this.SchemeAddButton.TabIndex = 1;
            this.SchemeAddButton.Text = "Добавить";
            this.SchemeAddButton.UseVisualStyleBackColor = true;
            // 
            // SortingSchemeLabel
            // 
            this.SortingSchemeLabel.AutoSize = true;
            this.SortingSchemeLabel.Location = new System.Drawing.Point(12, 13);
            this.SortingSchemeLabel.Name = "SortingSchemeLabel";
            this.SortingSchemeLabel.Size = new System.Drawing.Size(155, 13);
            this.SortingSchemeLabel.TabIndex = 2;
            this.SortingSchemeLabel.Text = "Название схемы сортировки";
            // 
            // SortingSchemeField
            // 
            this.SortingSchemeField.Location = new System.Drawing.Point(173, 10);
            this.SortingSchemeField.Name = "SortingSchemeField";
            this.SortingSchemeField.Size = new System.Drawing.Size(270, 20);
            this.SortingSchemeField.TabIndex = 3;
            // 
            // SortingSchemeAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 478);
            this.Controls.Add(this.SortingSchemeField);
            this.Controls.Add(this.SortingSchemeLabel);
            this.Controls.Add(this.SchemeAddButton);
            this.Controls.Add(this.SkinTypeCheckList);
            this.Name = "SortingSchemeAdding";
            this.Text = "Добавление схемы сортировки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SortingSchemeAddingClosing);
            this.Load += new System.EventHandler(this.SortingSchemeAddingOnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox SkinTypeCheckList;
        private System.Windows.Forms.Button SchemeAddButton;
        private System.Windows.Forms.Label SortingSchemeLabel;
        private System.Windows.Forms.TextBox SortingSchemeField;
    }
}