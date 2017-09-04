namespace KRSClientApplication.Views
{
    partial class ProviderRegistration
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
            this.LabelField = new System.Windows.Forms.TextBox();
            this.AdressField = new System.Windows.Forms.TextBox();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.DiscountField = new System.Windows.Forms.TextBox();
            this.LabelLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelField
            // 
            this.LabelField.Location = new System.Drawing.Point(124, 35);
            this.LabelField.Name = "LabelField";
            this.LabelField.Size = new System.Drawing.Size(167, 20);
            this.LabelField.TabIndex = 0;
            // 
            // AdressField
            // 
            this.AdressField.Location = new System.Drawing.Point(124, 61);
            this.AdressField.Name = "AdressField";
            this.AdressField.Size = new System.Drawing.Size(167, 20);
            this.AdressField.TabIndex = 1;
            // 
            // PhoneField
            // 
            this.PhoneField.Location = new System.Drawing.Point(124, 87);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(167, 20);
            this.PhoneField.TabIndex = 2;
            // 
            // DiscountField
            // 
            this.DiscountField.Location = new System.Drawing.Point(124, 113);
            this.DiscountField.Name = "DiscountField";
            this.DiscountField.Size = new System.Drawing.Size(167, 20);
            this.DiscountField.TabIndex = 3;
            // 
            // LabelLabel
            // 
            this.LabelLabel.AutoSize = true;
            this.LabelLabel.Location = new System.Drawing.Point(13, 41);
            this.LabelLabel.Name = "LabelLabel";
            this.LabelLabel.Size = new System.Drawing.Size(83, 13);
            this.LabelLabel.TabIndex = 4;
            this.LabelLabel.Text = "Наименование";
            // 
            // AdressLabel
            // 
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(12, 64);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(38, 13);
            this.AdressLabel.TabIndex = 5;
            this.AdressLabel.Text = "Адрес";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(12, 90);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(52, 13);
            this.PhoneLabel.TabIndex = 6;
            this.PhoneLabel.Text = "Телефон";
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(12, 116);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(44, 13);
            this.DiscountLabel.TabIndex = 7;
            this.DiscountLabel.Text = "Скидка";
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(100, 156);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(112, 23);
            this.RegistrationButton.TabIndex = 8;
            this.RegistrationButton.Text = "Зарегистрировать";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            // 
            // ProviderRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 191);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.AdressLabel);
            this.Controls.Add(this.LabelLabel);
            this.Controls.Add(this.DiscountField);
            this.Controls.Add(this.PhoneField);
            this.Controls.Add(this.AdressField);
            this.Controls.Add(this.LabelField);
            this.Name = "ProviderRegistration";
            this.Text = "Регистрация поставщика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LabelField;
        private System.Windows.Forms.TextBox AdressField;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox DiscountField;
        private System.Windows.Forms.Label LabelLabel;
        private System.Windows.Forms.Label AdressLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Button RegistrationButton;
    }
}