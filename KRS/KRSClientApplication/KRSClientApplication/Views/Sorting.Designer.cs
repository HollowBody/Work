namespace KRSClientApplication.Views
{
    partial class Sorting
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
            this.SortingLabel = new System.Windows.Forms.Label();
            this.SortingTopMenu = new System.Windows.Forms.MenuStrip();
            this.FileSortingMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BatchRegistrationMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BatchParametersContainer = new System.Windows.Forms.GroupBox();
            this.SortingCountValueLabel = new System.Windows.Forms.Label();
            this.SortingSvhemeValueLabel = new System.Windows.Forms.Label();
            this.ConservationValueLabel = new System.Windows.Forms.Label();
            this.RawTypeValueLabel = new System.Windows.Forms.Label();
            this.RegionValueLabel = new System.Windows.Forms.Label();
            this.ProviderValueLabel = new System.Windows.Forms.Label();
            this.SortingCountLabel = new System.Windows.Forms.Label();
            this.SortingSchemeLabel = new System.Windows.Forms.Label();
            this.ConservationTypeLabel = new System.Windows.Forms.Label();
            this.RawTypeLabel = new System.Windows.Forms.Label();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.ProviderLabel = new System.Windows.Forms.Label();
            this.OwnerCompanyLabel = new System.Windows.Forms.Label();
            this.BatchList = new System.Windows.Forms.ComboBox();
            this.BatchNumberLabel = new System.Windows.Forms.Label();
            this.PalletsParametersContainer = new System.Windows.Forms.GroupBox();
            this.PalletNumberValueLabel = new System.Windows.Forms.Label();
            this.SortValueLabel = new System.Windows.Forms.Label();
            this.OpenPalletCountValueLabel = new System.Windows.Forms.Label();
            this.NormalSkinsCountValueLabel = new System.Windows.Forms.Label();
            this.CurrentSkinsCountValueLabel = new System.Windows.Forms.Label();
            this.PalletNumberLabel = new System.Windows.Forms.Label();
            this.SortLabel = new System.Windows.Forms.Label();
            this.OpenPalletCountLabel = new System.Windows.Forms.Label();
            this.NormalSkinsCountLabel = new System.Windows.Forms.Label();
            this.CurrentSkinsCountLabel = new System.Windows.Forms.Label();
            this.SkinsInformationGrid = new System.Windows.Forms.DataGridView();
            this.SkinAddingButton = new System.Windows.Forms.Button();
            this.SkinRemoveButton = new System.Windows.Forms.Button();
            this.ShowStatsButton = new System.Windows.Forms.Button();
            this.SkinParametersContainer = new System.Windows.Forms.GroupBox();
            this.NettoField = new System.Windows.Forms.TextBox();
            this.BruttoField = new System.Windows.Forms.TextBox();
            this.DiscountField = new System.Windows.Forms.TextBox();
            this.SortList = new System.Windows.Forms.ComboBox();
            this.ConfigurationsList = new System.Windows.Forms.ComboBox();
            this.SkinNettoLabel = new System.Windows.Forms.Label();
            this.SkinBruttoLabel = new System.Windows.Forms.Label();
            this.SkinDiscountLabel = new System.Windows.Forms.Label();
            this.SkinSortLabel = new System.Windows.Forms.Label();
            this.SkinConfigurationLabel = new System.Windows.Forms.Label();
            this.SortingTopMenu.SuspendLayout();
            this.BatchParametersContainer.SuspendLayout();
            this.PalletsParametersContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkinsInformationGrid)).BeginInit();
            this.SkinParametersContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SortingLabel
            // 
            this.SortingLabel.AutoSize = true;
            this.SortingLabel.BackColor = System.Drawing.SystemColors.Control;
            this.SortingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortingLabel.Location = new System.Drawing.Point(12, 32);
            this.SortingLabel.Name = "SortingLabel";
            this.SortingLabel.Size = new System.Drawing.Size(128, 24);
            this.SortingLabel.TabIndex = 0;
            this.SortingLabel.Text = "Сортировка";
            // 
            // SortingTopMenu
            // 
            this.SortingTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSortingMenuButton,
            this.BatchRegistrationMenuButton,
            this.операцииToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.SortingTopMenu.Location = new System.Drawing.Point(0, 0);
            this.SortingTopMenu.Name = "SortingTopMenu";
            this.SortingTopMenu.Size = new System.Drawing.Size(1090, 24);
            this.SortingTopMenu.TabIndex = 1;
            this.SortingTopMenu.Text = "Меню Сортировки";
            // 
            // FileSortingMenuButton
            // 
            this.FileSortingMenuButton.Name = "FileSortingMenuButton";
            this.FileSortingMenuButton.Size = new System.Drawing.Size(48, 20);
            this.FileSortingMenuButton.Text = "Файл";
            // 
            // BatchRegistrationMenuButton
            // 
            this.BatchRegistrationMenuButton.Name = "BatchRegistrationMenuButton";
            this.BatchRegistrationMenuButton.Size = new System.Drawing.Size(130, 20);
            this.BatchRegistrationMenuButton.Text = "Регистрация партии";
            this.BatchRegistrationMenuButton.Click += new System.EventHandler(this.BatchRegistrationMenuButtonOnClick);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // BatchParametersContainer
            // 
            this.BatchParametersContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BatchParametersContainer.BackColor = System.Drawing.SystemColors.Control;
            this.BatchParametersContainer.Controls.Add(this.SortingCountValueLabel);
            this.BatchParametersContainer.Controls.Add(this.SortingSvhemeValueLabel);
            this.BatchParametersContainer.Controls.Add(this.ConservationValueLabel);
            this.BatchParametersContainer.Controls.Add(this.RawTypeValueLabel);
            this.BatchParametersContainer.Controls.Add(this.RegionValueLabel);
            this.BatchParametersContainer.Controls.Add(this.ProviderValueLabel);
            this.BatchParametersContainer.Controls.Add(this.SortingCountLabel);
            this.BatchParametersContainer.Controls.Add(this.SortingSchemeLabel);
            this.BatchParametersContainer.Controls.Add(this.ConservationTypeLabel);
            this.BatchParametersContainer.Controls.Add(this.RawTypeLabel);
            this.BatchParametersContainer.Controls.Add(this.RegionLabel);
            this.BatchParametersContainer.Controls.Add(this.ProviderLabel);
            this.BatchParametersContainer.Controls.Add(this.OwnerCompanyLabel);
            this.BatchParametersContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BatchParametersContainer.Location = new System.Drawing.Point(0, 60);
            this.BatchParametersContainer.Name = "BatchParametersContainer";
            this.BatchParametersContainer.Size = new System.Drawing.Size(764, 165);
            this.BatchParametersContainer.TabIndex = 2;
            this.BatchParametersContainer.TabStop = false;
            this.BatchParametersContainer.Text = "Параметры завозной партии";
            // 
            // SortingCountValueLabel
            // 
            this.SortingCountValueLabel.AutoSize = true;
            this.SortingCountValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SortingCountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortingCountValueLabel.Location = new System.Drawing.Point(734, 32);
            this.SortingCountValueLabel.Name = "SortingCountValueLabel";
            this.SortingCountValueLabel.Size = new System.Drawing.Size(19, 20);
            this.SortingCountValueLabel.TabIndex = 12;
            this.SortingCountValueLabel.Text = "--";
            // 
            // SortingSvhemeValueLabel
            // 
            this.SortingSvhemeValueLabel.AutoSize = true;
            this.SortingSvhemeValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SortingSvhemeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortingSvhemeValueLabel.Location = new System.Drawing.Point(490, 106);
            this.SortingSvhemeValueLabel.Name = "SortingSvhemeValueLabel";
            this.SortingSvhemeValueLabel.Size = new System.Drawing.Size(264, 20);
            this.SortingSvhemeValueLabel.TabIndex = 11;
            this.SortingSvhemeValueLabel.Text = "Наименование схемы сортировки";
            // 
            // ConservationValueLabel
            // 
            this.ConservationValueLabel.AutoSize = true;
            this.ConservationValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ConservationValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConservationValueLabel.Location = new System.Drawing.Point(490, 68);
            this.ConservationValueLabel.Name = "ConservationValueLabel";
            this.ConservationValueLabel.Size = new System.Drawing.Size(263, 20);
            this.ConservationValueLabel.TabIndex = 10;
            this.ConservationValueLabel.Text = "Наименование типа консервации";
            // 
            // RawTypeValueLabel
            // 
            this.RawTypeValueLabel.AutoSize = true;
            this.RawTypeValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RawTypeValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RawTypeValueLabel.Location = new System.Drawing.Point(391, 32);
            this.RawTypeValueLabel.Name = "RawTypeValueLabel";
            this.RawTypeValueLabel.Size = new System.Drawing.Size(172, 20);
            this.RawTypeValueLabel.TabIndex = 9;
            this.RawTypeValueLabel.Text = "Наименование сырья";
            // 
            // RegionValueLabel
            // 
            this.RegionValueLabel.AutoSize = true;
            this.RegionValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RegionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionValueLabel.Location = new System.Drawing.Point(111, 106);
            this.RegionValueLabel.Name = "RegionValueLabel";
            this.RegionValueLabel.Size = new System.Drawing.Size(148, 20);
            this.RegionValueLabel.TabIndex = 8;
            this.RegionValueLabel.Text = "Название региона";
            // 
            // ProviderValueLabel
            // 
            this.ProviderValueLabel.AutoSize = true;
            this.ProviderValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ProviderValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderValueLabel.Location = new System.Drawing.Point(111, 68);
            this.ProviderValueLabel.Name = "ProviderValueLabel";
            this.ProviderValueLabel.Size = new System.Drawing.Size(218, 20);
            this.ProviderValueLabel.TabIndex = 7;
            this.ProviderValueLabel.Text = "Наименование поставщика";
            // 
            // SortingCountLabel
            // 
            this.SortingCountLabel.AutoSize = true;
            this.SortingCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortingCountLabel.Location = new System.Drawing.Point(586, 32);
            this.SortingCountLabel.Name = "SortingCountLabel";
            this.SortingCountLabel.Size = new System.Drawing.Size(150, 20);
            this.SortingCountLabel.TabIndex = 6;
            this.SortingCountLabel.Text = "Отсортированных:";
            // 
            // SortingSchemeLabel
            // 
            this.SortingSchemeLabel.AutoSize = true;
            this.SortingSchemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortingSchemeLabel.Location = new System.Drawing.Point(341, 106);
            this.SortingSchemeLabel.Name = "SortingSchemeLabel";
            this.SortingSchemeLabel.Size = new System.Drawing.Size(152, 20);
            this.SortingSchemeLabel.TabIndex = 5;
            this.SortingSchemeLabel.Text = "Схема сортировки:";
            // 
            // ConservationTypeLabel
            // 
            this.ConservationTypeLabel.AutoSize = true;
            this.ConservationTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConservationTypeLabel.Location = new System.Drawing.Point(341, 68);
            this.ConservationTypeLabel.Name = "ConservationTypeLabel";
            this.ConservationTypeLabel.Size = new System.Drawing.Size(148, 20);
            this.ConservationTypeLabel.TabIndex = 4;
            this.ConservationTypeLabel.Text = "Консервирование:";
            // 
            // RawTypeLabel
            // 
            this.RawTypeLabel.AutoSize = true;
            this.RawTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RawTypeLabel.Location = new System.Drawing.Point(295, 32);
            this.RawTypeLabel.Name = "RawTypeLabel";
            this.RawTypeLabel.Size = new System.Drawing.Size(94, 20);
            this.RawTypeLabel.TabIndex = 3;
            this.RawTypeLabel.Text = "Вид сырья:";
            // 
            // RegionLabel
            // 
            this.RegionLabel.AutoSize = true;
            this.RegionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegionLabel.Location = new System.Drawing.Point(12, 106);
            this.RegionLabel.Name = "RegionLabel";
            this.RegionLabel.Size = new System.Drawing.Size(66, 20);
            this.RegionLabel.TabIndex = 2;
            this.RegionLabel.Text = "Регион:";
            // 
            // ProviderLabel
            // 
            this.ProviderLabel.AutoSize = true;
            this.ProviderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderLabel.Location = new System.Drawing.Point(12, 68);
            this.ProviderLabel.Name = "ProviderLabel";
            this.ProviderLabel.Size = new System.Drawing.Size(99, 20);
            this.ProviderLabel.TabIndex = 1;
            this.ProviderLabel.Text = "Поставщик:";
            // 
            // OwnerCompanyLabel
            // 
            this.OwnerCompanyLabel.AutoSize = true;
            this.OwnerCompanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerCompanyLabel.Location = new System.Drawing.Point(12, 32);
            this.OwnerCompanyLabel.Name = "OwnerCompanyLabel";
            this.OwnerCompanyLabel.Size = new System.Drawing.Size(151, 20);
            this.OwnerCompanyLabel.TabIndex = 0;
            this.OwnerCompanyLabel.Text = "ООО \"Альфа-Чел\"";
            // 
            // BatchList
            // 
            this.BatchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BatchList.FormattingEnabled = true;
            this.BatchList.Items.AddRange(new object[] {
            "1"});
            this.BatchList.Location = new System.Drawing.Point(957, 31);
            this.BatchList.Name = "BatchList";
            this.BatchList.Size = new System.Drawing.Size(130, 21);
            this.BatchList.TabIndex = 8;
            this.BatchList.SelectedValueChanged += new System.EventHandler(this.BatchListUpdate);
            // 
            // BatchNumberLabel
            // 
            this.BatchNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BatchNumberLabel.AutoSize = true;
            this.BatchNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BatchNumberLabel.Location = new System.Drawing.Point(854, 32);
            this.BatchNumberLabel.Name = "BatchNumberLabel";
            this.BatchNumberLabel.Size = new System.Drawing.Size(101, 16);
            this.BatchNumberLabel.TabIndex = 4;
            this.BatchNumberLabel.Text = "Номер партии";
            // 
            // PalletsParametersContainer
            // 
            this.PalletsParametersContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PalletsParametersContainer.BackColor = System.Drawing.SystemColors.Control;
            this.PalletsParametersContainer.Controls.Add(this.PalletNumberValueLabel);
            this.PalletsParametersContainer.Controls.Add(this.SortValueLabel);
            this.PalletsParametersContainer.Controls.Add(this.OpenPalletCountValueLabel);
            this.PalletsParametersContainer.Controls.Add(this.NormalSkinsCountValueLabel);
            this.PalletsParametersContainer.Controls.Add(this.CurrentSkinsCountValueLabel);
            this.PalletsParametersContainer.Controls.Add(this.PalletNumberLabel);
            this.PalletsParametersContainer.Controls.Add(this.SortLabel);
            this.PalletsParametersContainer.Controls.Add(this.OpenPalletCountLabel);
            this.PalletsParametersContainer.Controls.Add(this.NormalSkinsCountLabel);
            this.PalletsParametersContainer.Controls.Add(this.CurrentSkinsCountLabel);
            this.PalletsParametersContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PalletsParametersContainer.Location = new System.Drawing.Point(770, 60);
            this.PalletsParametersContainer.Name = "PalletsParametersContainer";
            this.PalletsParametersContainer.Size = new System.Drawing.Size(320, 165);
            this.PalletsParametersContainer.TabIndex = 5;
            this.PalletsParametersContainer.TabStop = false;
            this.PalletsParametersContainer.Text = "Параметры поддонов";
            // 
            // PalletNumberValueLabel
            // 
            this.PalletNumberValueLabel.AutoSize = true;
            this.PalletNumberValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PalletNumberValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PalletNumberValueLabel.Location = new System.Drawing.Point(177, 106);
            this.PalletNumberValueLabel.Name = "PalletNumberValueLabel";
            this.PalletNumberValueLabel.Size = new System.Drawing.Size(19, 20);
            this.PalletNumberValueLabel.TabIndex = 17;
            this.PalletNumberValueLabel.Text = "--";
            // 
            // SortValueLabel
            // 
            this.SortValueLabel.AutoSize = true;
            this.SortValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SortValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortValueLabel.Location = new System.Drawing.Point(250, 65);
            this.SortValueLabel.Name = "SortValueLabel";
            this.SortValueLabel.Size = new System.Drawing.Size(19, 20);
            this.SortValueLabel.TabIndex = 16;
            this.SortValueLabel.Text = "--";
            // 
            // OpenPalletCountValueLabel
            // 
            this.OpenPalletCountValueLabel.AutoSize = true;
            this.OpenPalletCountValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OpenPalletCountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenPalletCountValueLabel.Location = new System.Drawing.Point(158, 66);
            this.OpenPalletCountValueLabel.Name = "OpenPalletCountValueLabel";
            this.OpenPalletCountValueLabel.Size = new System.Drawing.Size(19, 20);
            this.OpenPalletCountValueLabel.TabIndex = 15;
            this.OpenPalletCountValueLabel.Text = "--";
            // 
            // NormalSkinsCountValueLabel
            // 
            this.NormalSkinsCountValueLabel.AutoSize = true;
            this.NormalSkinsCountValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NormalSkinsCountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NormalSkinsCountValueLabel.Location = new System.Drawing.Point(250, 42);
            this.NormalSkinsCountValueLabel.Name = "NormalSkinsCountValueLabel";
            this.NormalSkinsCountValueLabel.Size = new System.Drawing.Size(19, 20);
            this.NormalSkinsCountValueLabel.TabIndex = 14;
            this.NormalSkinsCountValueLabel.Text = "--";
            // 
            // CurrentSkinsCountValueLabel
            // 
            this.CurrentSkinsCountValueLabel.AutoSize = true;
            this.CurrentSkinsCountValueLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CurrentSkinsCountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentSkinsCountValueLabel.Location = new System.Drawing.Point(250, 19);
            this.CurrentSkinsCountValueLabel.Name = "CurrentSkinsCountValueLabel";
            this.CurrentSkinsCountValueLabel.Size = new System.Drawing.Size(19, 20);
            this.CurrentSkinsCountValueLabel.TabIndex = 13;
            this.CurrentSkinsCountValueLabel.Text = "--";
            // 
            // PalletNumberLabel
            // 
            this.PalletNumberLabel.AutoSize = true;
            this.PalletNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PalletNumberLabel.Location = new System.Drawing.Point(6, 106);
            this.PalletNumberLabel.Name = "PalletNumberLabel";
            this.PalletNumberLabel.Size = new System.Drawing.Size(165, 20);
            this.PalletNumberLabel.TabIndex = 11;
            this.PalletNumberLabel.Text = "Рег. номер поддона:";
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortLabel.Location = new System.Drawing.Point(198, 65);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(51, 20);
            this.SortLabel.TabIndex = 10;
            this.SortLabel.Text = "Сорт:";
            // 
            // OpenPalletCountLabel
            // 
            this.OpenPalletCountLabel.AutoSize = true;
            this.OpenPalletCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenPalletCountLabel.Location = new System.Drawing.Point(6, 66);
            this.OpenPalletCountLabel.Name = "OpenPalletCountLabel";
            this.OpenPalletCountLabel.Size = new System.Drawing.Size(146, 20);
            this.OpenPalletCountLabel.TabIndex = 9;
            this.OpenPalletCountLabel.Text = "Открыто отвесов:";
            // 
            // NormalSkinsCountLabel
            // 
            this.NormalSkinsCountLabel.AutoSize = true;
            this.NormalSkinsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NormalSkinsCountLabel.Location = new System.Drawing.Point(6, 43);
            this.NormalSkinsCountLabel.Name = "NormalSkinsCountLabel";
            this.NormalSkinsCountLabel.Size = new System.Drawing.Size(218, 20);
            this.NormalSkinsCountLabel.TabIndex = 8;
            this.NormalSkinsCountLabel.Text = "Количество шкур по норме:";
            // 
            // CurrentSkinsCountLabel
            // 
            this.CurrentSkinsCountLabel.AutoSize = true;
            this.CurrentSkinsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentSkinsCountLabel.Location = new System.Drawing.Point(6, 20);
            this.CurrentSkinsCountLabel.Name = "CurrentSkinsCountLabel";
            this.CurrentSkinsCountLabel.Size = new System.Drawing.Size(211, 20);
            this.CurrentSkinsCountLabel.TabIndex = 7;
            this.CurrentSkinsCountLabel.Text = "Текущее количество шкур:";
            // 
            // SkinsInformationGrid
            // 
            this.SkinsInformationGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkinsInformationGrid.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.SkinsInformationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SkinsInformationGrid.Location = new System.Drawing.Point(0, 232);
            this.SkinsInformationGrid.Name = "SkinsInformationGrid";
            this.SkinsInformationGrid.Size = new System.Drawing.Size(1090, 334);
            this.SkinsInformationGrid.TabIndex = 6;
            // 
            // SkinAddingButton
            // 
            this.SkinAddingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkinAddingButton.Location = new System.Drawing.Point(482, 603);
            this.SkinAddingButton.Name = "SkinAddingButton";
            this.SkinAddingButton.Size = new System.Drawing.Size(179, 42);
            this.SkinAddingButton.TabIndex = 14;
            this.SkinAddingButton.Text = "ВВОД";
            this.SkinAddingButton.UseVisualStyleBackColor = true;
            this.SkinAddingButton.Click += new System.EventHandler(this.SkinAddingButtonOnClick);
            // 
            // SkinRemoveButton
            // 
            this.SkinRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkinRemoveButton.Location = new System.Drawing.Point(482, 651);
            this.SkinRemoveButton.Name = "SkinRemoveButton";
            this.SkinRemoveButton.Size = new System.Drawing.Size(179, 42);
            this.SkinRemoveButton.TabIndex = 15;
            this.SkinRemoveButton.Text = "ВОЗВРАТ";
            this.SkinRemoveButton.UseVisualStyleBackColor = true;
            this.SkinRemoveButton.Click += new System.EventHandler(this.SkinRemoveButtonOnClick);
            // 
            // ShowStatsButton
            // 
            this.ShowStatsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowStatsButton.Location = new System.Drawing.Point(482, 699);
            this.ShowStatsButton.Name = "ShowStatsButton";
            this.ShowStatsButton.Size = new System.Drawing.Size(179, 42);
            this.ShowStatsButton.TabIndex = 16;
            this.ShowStatsButton.Text = "Фиксация параметров завозной партии";
            this.ShowStatsButton.UseVisualStyleBackColor = true;
            this.ShowStatsButton.Click += new System.EventHandler(this.ShowStatsButtonOnClick);
            // 
            // SkinParametersContainer
            // 
            this.SkinParametersContainer.BackColor = System.Drawing.SystemColors.Control;
            this.SkinParametersContainer.Controls.Add(this.NettoField);
            this.SkinParametersContainer.Controls.Add(this.BruttoField);
            this.SkinParametersContainer.Controls.Add(this.DiscountField);
            this.SkinParametersContainer.Controls.Add(this.SortList);
            this.SkinParametersContainer.Controls.Add(this.ConfigurationsList);
            this.SkinParametersContainer.Controls.Add(this.SkinNettoLabel);
            this.SkinParametersContainer.Controls.Add(this.SkinBruttoLabel);
            this.SkinParametersContainer.Controls.Add(this.SkinDiscountLabel);
            this.SkinParametersContainer.Controls.Add(this.SkinSortLabel);
            this.SkinParametersContainer.Controls.Add(this.SkinConfigurationLabel);
            this.SkinParametersContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkinParametersContainer.Location = new System.Drawing.Point(0, 570);
            this.SkinParametersContainer.Name = "SkinParametersContainer";
            this.SkinParametersContainer.Size = new System.Drawing.Size(385, 205);
            this.SkinParametersContainer.TabIndex = 10;
            this.SkinParametersContainer.TabStop = false;
            this.SkinParametersContainer.Text = "Параметры шкуры";
            // 
            // NettoField
            // 
            this.NettoField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NettoField.Location = new System.Drawing.Point(158, 131);
            this.NettoField.Name = "NettoField";
            this.NettoField.Size = new System.Drawing.Size(221, 26);
            this.NettoField.TabIndex = 13;
            this.NettoField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NettoFieldOnKeyDown);
            this.NettoField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NettoFieldOnKeyPress);
            // 
            // BruttoField
            // 
            this.BruttoField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BruttoField.Location = new System.Drawing.Point(158, 167);
            this.BruttoField.Name = "BruttoField";
            this.BruttoField.Size = new System.Drawing.Size(221, 26);
            this.BruttoField.TabIndex = 12;
            // 
            // DiscountField
            // 
            this.DiscountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountField.Location = new System.Drawing.Point(158, 97);
            this.DiscountField.Name = "DiscountField";
            this.DiscountField.Size = new System.Drawing.Size(221, 26);
            this.DiscountField.TabIndex = 11;
            this.DiscountField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscountFieldOnKeyDown);
            this.DiscountField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DiscountFieldOnKeyPress);
            // 
            // SortList
            // 
            this.SortList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortList.FormattingEnabled = true;
            this.SortList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.SortList.Location = new System.Drawing.Point(158, 62);
            this.SortList.Name = "SortList";
            this.SortList.Size = new System.Drawing.Size(221, 28);
            this.SortList.TabIndex = 10;
            this.SortList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SortListOnKeyDown);
            this.SortList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SortListOnKeyPress);
            // 
            // ConfigurationsList
            // 
            this.ConfigurationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfigurationsList.FormattingEnabled = true;
            this.ConfigurationsList.Location = new System.Drawing.Point(158, 27);
            this.ConfigurationsList.Name = "ConfigurationsList";
            this.ConfigurationsList.Size = new System.Drawing.Size(221, 28);
            this.ConfigurationsList.TabIndex = 9;
            this.ConfigurationsList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfigurationsListOnKeyDown);
            // 
            // SkinNettoLabel
            // 
            this.SkinNettoLabel.AutoSize = true;
            this.SkinNettoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkinNettoLabel.Location = new System.Drawing.Point(6, 135);
            this.SkinNettoLabel.Name = "SkinNettoLabel";
            this.SkinNettoLabel.Size = new System.Drawing.Size(90, 20);
            this.SkinNettoLabel.TabIndex = 8;
            this.SkinNettoLabel.Text = "Вес нетто:";
            // 
            // SkinBruttoLabel
            // 
            this.SkinBruttoLabel.AutoSize = true;
            this.SkinBruttoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkinBruttoLabel.Location = new System.Drawing.Point(6, 170);
            this.SkinBruttoLabel.Name = "SkinBruttoLabel";
            this.SkinBruttoLabel.Size = new System.Drawing.Size(97, 20);
            this.SkinBruttoLabel.TabIndex = 7;
            this.SkinBruttoLabel.Text = "Вес брутто:";
            // 
            // SkinDiscountLabel
            // 
            this.SkinDiscountLabel.AutoSize = true;
            this.SkinDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkinDiscountLabel.Location = new System.Drawing.Point(6, 100);
            this.SkinDiscountLabel.Name = "SkinDiscountLabel";
            this.SkinDiscountLabel.Size = new System.Drawing.Size(139, 20);
            this.SkinDiscountLabel.TabIndex = 6;
            this.SkinDiscountLabel.Text = "Скидка/Накидка:";
            // 
            // SkinSortLabel
            // 
            this.SkinSortLabel.AutoSize = true;
            this.SkinSortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkinSortLabel.Location = new System.Drawing.Point(6, 65);
            this.SkinSortLabel.Name = "SkinSortLabel";
            this.SkinSortLabel.Size = new System.Drawing.Size(51, 20);
            this.SkinSortLabel.TabIndex = 5;
            this.SkinSortLabel.Text = "Сорт:";
            // 
            // SkinConfigurationLabel
            // 
            this.SkinConfigurationLabel.AutoSize = true;
            this.SkinConfigurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkinConfigurationLabel.Location = new System.Drawing.Point(6, 30);
            this.SkinConfigurationLabel.Name = "SkinConfigurationLabel";
            this.SkinConfigurationLabel.Size = new System.Drawing.Size(124, 20);
            this.SkinConfigurationLabel.TabIndex = 4;
            this.SkinConfigurationLabel.Text = "Конфигурация:";
            // 
            // Sorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1090, 777);
            this.Controls.Add(this.SkinParametersContainer);
            this.Controls.Add(this.ShowStatsButton);
            this.Controls.Add(this.SkinRemoveButton);
            this.Controls.Add(this.SkinAddingButton);
            this.Controls.Add(this.SkinsInformationGrid);
            this.Controls.Add(this.PalletsParametersContainer);
            this.Controls.Add(this.BatchNumberLabel);
            this.Controls.Add(this.BatchList);
            this.Controls.Add(this.BatchParametersContainer);
            this.Controls.Add(this.SortingLabel);
            this.Controls.Add(this.SortingTopMenu);
            this.MainMenuStrip = this.SortingTopMenu;
            this.Name = "Sorting";
            this.Text = "Сортировка";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SortingClosing);
            this.Load += new System.EventHandler(this.SortingOnLoad);
            this.SortingTopMenu.ResumeLayout(false);
            this.SortingTopMenu.PerformLayout();
            this.BatchParametersContainer.ResumeLayout(false);
            this.BatchParametersContainer.PerformLayout();
            this.PalletsParametersContainer.ResumeLayout(false);
            this.PalletsParametersContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SkinsInformationGrid)).EndInit();
            this.SkinParametersContainer.ResumeLayout(false);
            this.SkinParametersContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SortingLabel;
        private System.Windows.Forms.MenuStrip SortingTopMenu;
        private System.Windows.Forms.ToolStripMenuItem FileSortingMenuButton;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.GroupBox BatchParametersContainer;
        private System.Windows.Forms.ComboBox BatchList;
        private System.Windows.Forms.Label BatchNumberLabel;
        private System.Windows.Forms.Label OwnerCompanyLabel;
        private System.Windows.Forms.Label SortingSchemeLabel;
        private System.Windows.Forms.Label ConservationTypeLabel;
        private System.Windows.Forms.Label RawTypeLabel;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.Label ProviderLabel;
        private System.Windows.Forms.Label SortingCountLabel;
        private System.Windows.Forms.GroupBox PalletsParametersContainer;
        private System.Windows.Forms.Label NormalSkinsCountLabel;
        private System.Windows.Forms.Label CurrentSkinsCountLabel;
        private System.Windows.Forms.Label PalletNumberLabel;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label OpenPalletCountLabel;
        private System.Windows.Forms.ToolStripMenuItem BatchRegistrationMenuButton;
        private System.Windows.Forms.Label SortingCountValueLabel;
        private System.Windows.Forms.Label SortingSvhemeValueLabel;
        private System.Windows.Forms.Label ConservationValueLabel;
        private System.Windows.Forms.Label RawTypeValueLabel;
        private System.Windows.Forms.Label RegionValueLabel;
        private System.Windows.Forms.Label ProviderValueLabel;
        private System.Windows.Forms.Label NormalSkinsCountValueLabel;
        private System.Windows.Forms.Label CurrentSkinsCountValueLabel;
        private System.Windows.Forms.Label OpenPalletCountValueLabel;
        private System.Windows.Forms.Label PalletNumberValueLabel;
        private System.Windows.Forms.Label SortValueLabel;
        private System.Windows.Forms.DataGridView SkinsInformationGrid;
        private System.Windows.Forms.Button SkinAddingButton;
        private System.Windows.Forms.Button SkinRemoveButton;
        private System.Windows.Forms.Button ShowStatsButton;
        private System.Windows.Forms.GroupBox SkinParametersContainer;
        private System.Windows.Forms.TextBox NettoField;
        private System.Windows.Forms.TextBox BruttoField;
        private System.Windows.Forms.TextBox DiscountField;
        private System.Windows.Forms.ComboBox SortList;
        private System.Windows.Forms.ComboBox ConfigurationsList;
        private System.Windows.Forms.Label SkinNettoLabel;
        private System.Windows.Forms.Label SkinBruttoLabel;
        private System.Windows.Forms.Label SkinDiscountLabel;
        private System.Windows.Forms.Label SkinSortLabel;
        private System.Windows.Forms.Label SkinConfigurationLabel;
    }
}