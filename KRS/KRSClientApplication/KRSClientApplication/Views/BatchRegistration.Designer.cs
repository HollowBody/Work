namespace KRSClientApplication.Views
{
    partial class BatchRegistration
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
            this.ProviderLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusField = new System.Windows.Forms.TextBox();
            this.DateTimeSelector = new System.Windows.Forms.DateTimePicker();
            this.SortingSchemeLabel = new System.Windows.Forms.Label();
            this.SortingSchemeList = new System.Windows.Forms.ComboBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProvidersList
            // 
            this.ProvidersList.FormattingEnabled = true;
            this.ProvidersList.Location = new System.Drawing.Point(118, 37);
            this.ProvidersList.Name = "ProvidersList";
            this.ProvidersList.Size = new System.Drawing.Size(214, 21);
            this.ProvidersList.TabIndex = 0;
            // 
            // ProviderLabel
            // 
            this.ProviderLabel.AutoSize = true;
            this.ProviderLabel.Location = new System.Drawing.Point(12, 40);
            this.ProviderLabel.Name = "ProviderLabel";
            this.ProviderLabel.Size = new System.Drawing.Size(65, 13);
            this.ProviderLabel.TabIndex = 1;
            this.ProviderLabel.Text = "Поставщик";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(13, 72);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(41, 13);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Статус";
            // 
            // StatusField
            // 
            this.StatusField.Enabled = false;
            this.StatusField.Location = new System.Drawing.Point(118, 69);
            this.StatusField.Name = "StatusField";
            this.StatusField.Size = new System.Drawing.Size(214, 20);
            this.StatusField.TabIndex = 3;
            this.StatusField.Text = "Открыта";
            // 
            // DateTimeSelector
            // 
            this.DateTimeSelector.Location = new System.Drawing.Point(12, 107);
            this.DateTimeSelector.Name = "DateTimeSelector";
            this.DateTimeSelector.Size = new System.Drawing.Size(320, 20);
            this.DateTimeSelector.TabIndex = 4;
            this.DateTimeSelector.Value = new System.DateTime(2017, 4, 30, 11, 10, 59, 0);
            // 
            // SortingSchemeLabel
            // 
            this.SortingSchemeLabel.AutoSize = true;
            this.SortingSchemeLabel.Location = new System.Drawing.Point(12, 147);
            this.SortingSchemeLabel.Name = "SortingSchemeLabel";
            this.SortingSchemeLabel.Size = new System.Drawing.Size(101, 13);
            this.SortingSchemeLabel.TabIndex = 6;
            this.SortingSchemeLabel.Text = "Схема сортировки";
            // 
            // SortingSchemeList
            // 
            this.SortingSchemeList.FormattingEnabled = true;
            this.SortingSchemeList.Location = new System.Drawing.Point(118, 144);
            this.SortingSchemeList.Name = "SortingSchemeList";
            this.SortingSchemeList.Size = new System.Drawing.Size(214, 21);
            this.SortingSchemeList.TabIndex = 5;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(16, 197);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(316, 53);
            this.RegistrationButton.TabIndex = 7;
            this.RegistrationButton.Text = "Зарегистрировать";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButtonOnClick);
            // 
            // BatchRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 262);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.SortingSchemeLabel);
            this.Controls.Add(this.SortingSchemeList);
            this.Controls.Add(this.DateTimeSelector);
            this.Controls.Add(this.StatusField);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ProviderLabel);
            this.Controls.Add(this.ProvidersList);
            this.Name = "BatchRegistration";
            this.Text = "Регистрация парии";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BatchRegistrationOnClosing);
            this.Load += new System.EventHandler(this.BatchRegistrationOnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProvidersList;
        private System.Windows.Forms.Label ProviderLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox StatusField;
        private System.Windows.Forms.DateTimePicker DateTimeSelector;
        private System.Windows.Forms.Label SortingSchemeLabel;
        private System.Windows.Forms.ComboBox SortingSchemeList;
        private System.Windows.Forms.Button RegistrationButton;
    }
}