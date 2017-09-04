using KRSClientApplication.Proxy;
using KRSServerApplication.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRSClientApplication.Views
{
    public partial class Sorting : Form
    {
        private HttpClient _httpClient = new HttpClient();
        private ResponseReader _responseReader = new ResponseReader();
        private BatchProxy _batchProxy;
        private SortingProxy _sortingProxy;
        private ConfigurationProxy _configurationProxy;
        private SkinProxy _skinProxy;
        private PalletProxy _palletProxy;
        List<string> enabledTypesList = new List<string>();

        public Sorting()
        {

            InitializeComponent();
            _httpClient.BaseAddress = new Uri("http://localhost:9000");
            _batchProxy = new BatchProxy();
            _sortingProxy = new SortingProxy();
            _configurationProxy = new ConfigurationProxy();
            _skinProxy = new SkinProxy();
            _palletProxy = new PalletProxy();
        }

        private void SortingClosing(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }

        private void BatchRegistrationMenuButtonOnClick(object sender, EventArgs e)
        {
            BatchRegistration batchRegistration = new BatchRegistration();
            batchRegistration.Show(this);
        }

        private async void SortingOnLoad(object sender, EventArgs e)
        {
            await BatchesLoad();
            await ConfigurationsLoad();
        }

        //private void BatchesLoad2()
        //{
        //    var worker = new BackgroundWorker();

        //    worker.DoWork += (s, e) =>
        //    {
        //        var batches = _batchProxy.GetOpenBatches();
        //        e.Result = batches;
        //    };

        //    worker.RunWorkerCompleted += (s, e) =>
        //    {
        //        if (e.Error == null)
        //        {
        //            var batches = (IEnumerable<int>)e.Result;
        //            BindingSource batchesBindingSource = new BindingSource();
        //            batchesBindingSource.DataSource = batches;
        //            BatchList.DataSource = batchesBindingSource;
        //        }
        //        else
        //        {
        //            MessageBox.Show(e.Error.Message);
        //        }
        //    };

        //    worker.RunWorkerAsync();
        //}
        public async Task BatchesLoad()
        {
            var batches = await _batchProxy.GetOpenBatchesAsync();
            BindingSource batchesBindingSource = new BindingSource();
            batchesBindingSource.DataSource = batches;
            BatchList.DataSource = batchesBindingSource;
        }

        private async Task ConfigurationsLoad()
        {
            BindingSource configurationsBindingSource = new BindingSource();
            var configurations = await _configurationProxy.GetConfigurations();
            configurationsBindingSource.DataSource = configurations;
            ConfigurationsList.DataSource = configurationsBindingSource;
            ConfigurationsList.DisplayMember = "ConfigurationLabel";
            ConfigurationsList.ValueMember = "IdConfiguration";
            //Додумать горячие клавиши
        }

        private async void BatchListUpdate(object sender, EventArgs e)
        {
            await BatchListUpd();
            //При закрытии выдает исключение ИСПРАВИТЬ
        }

        private async Task BatchListUpd()
        {
            string batchNumber = BatchList.SelectedItem.ToString();
            enabledTypesList.Clear();
            BindingSource sortingBindingSource = new BindingSource();
            var skins = await _sortingProxy.GetAllSkins(batchNumber);
            var sid = "";
            var schemeid = await _sortingProxy.GetSchemeID(batchNumber); // Получаем ID Схемы
            foreach (var ids in schemeid)
            {
                sid = ids.ToString();
            }

            var enabledSkinTypes = await _sortingProxy.GetEnabledTypeSkins(sid); // Определяем доступные типы шкур

            // в форич добавлять все доступные типы в лист, чтоб потом выбирать из этого листа

            foreach (var eST in enabledSkinTypes)
            {
                enabledTypesList.Add(eST.ToString());
            }

            // переписать определение по весу и типу шкуры.

            //var skin1 = await _skinProxy.GetSkin("2");
            //var skin2 = await _skinProxy.GetSkin("43");

            sortingBindingSource.DataSource = skins;
            SkinsInformationGrid.DataSource = sortingBindingSource;
            SkinsInformationGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SkinsInformationGrid.Columns[0].HeaderText = @"Номер поддона";
            SkinsInformationGrid.Columns[1].HeaderText = @"Сорт";
            SkinsInformationGrid.Columns[2].HeaderText = @"Вес Брутто (кг)";
            SkinsInformationGrid.Columns[3].HeaderText = @"Вес Нетто (кг)";
            SkinsInformationGrid.Columns[4].HeaderText = @"Скидка (кг)";
            SkinsInformationGrid.Columns[5].HeaderText = @"Диапазон весов";
            //SkinsInformationGrid.Columns[6].Visible = false;
            //SkinsInformationGrid.Columns[7].Visible = false;
            //SkinsInformationGrid.Columns[8].Visible = false;
            SkinsInformationGrid.Columns[9].Visible = false;
            //SkinsInformationGrid.Columns[10].Visible = false;
            //SkinsInformationGrid.Columns[11].Visible = false;
        }

        private async Task<int> GetPalletID(int idtypeskin)
        {

            var idPalletResponse = await _sortingProxy.GetTypeSkinPallet(idtypeskin);
            // Если палет существует то добавляем 
            var idp = "";
            foreach (var id in idPalletResponse)
            {
                idp = id.ToString();
            }
            if (idp == "")
            {
                //Открыть новый поддон
                var newPallet = new Pallet { CurrentCountSkins = 0, OpeningDate = DateTime.Now, IdTypeSkin = idtypeskin, Status = "Открыт" };
                await _palletProxy.AddPallet(newPallet);
                idPalletResponse = await _sortingProxy.GetTypeSkinPallet(idtypeskin);
                foreach (var id in idPalletResponse)
                {
                    idp = id.ToString();
                }
                // На новый Сказать
            }
            int idpallet = Convert.ToInt32(idp);
            return idpallet;
        }

        private async void SkinAddingButtonOnClick(object sender, EventArgs e)
        {
            var format = new System.Globalization.NumberFormatInfo();
            format.NumberDecimalSeparator = ".";

            decimal brutto = Convert.ToDecimal(BruttoField.Text);
            decimal netto = Convert.ToDecimal(NettoField.Text);
            decimal discount;
            if (DiscountField.TextLength > 0)
            {
                discount = Convert.ToDecimal(DiscountField.Text);
            }
            else
                discount = 0;
            int idsort = Convert.ToInt32(SortList.Text);

            var idconfigurationResponse = await _sortingProxy.GetConfigurationID(ConfigurationsList.Text);
            int idconfiguration = 0;

            foreach (var id in idconfigurationResponse)
            {
                idconfiguration = id;
            }

            int idbatch = Convert.ToInt32(BatchList.Text);
            var idtypeskinResponse = _sortingProxy.GetConfigurationTypeSkin(brutto, idconfiguration);
            int idtypeskin = 0;

            foreach (var id in idtypeskinResponse)
            {
                if (enabledTypesList.Contains(id.ToString()))
                    idtypeskin = id;
            }

            var getpalletResponse = GetPalletID(idtypeskin);
            var idpallet = await getpalletResponse;
            var newSkin = new Skin { IdSort = idsort, Brutto = (float)brutto, Netto = (float)netto, Discount = (float)discount, IdBatch = idbatch, IdTypeSkin = idtypeskin, IdConfiguration = idconfiguration, IdPallet = idpallet };

            //получить по ID паллета количество шкур на нем, потом прибавить одну и отправить
            var palletCurrentCountResponse = await _sortingProxy.GetPalletCountSkins(idpallet.ToString());
            var CurrentCountSkins = 0;
            foreach (var CurrentCount in palletCurrentCountResponse)
            {
                CurrentCountSkins = CurrentCount;
            }
            CurrentCountSkins += 1;

            var maxCountResponse = await _sortingProxy.GetMaxCountSkins(idtypeskin.ToString());
            int MaxCountSkins = 0;
            foreach (var MaxCount in maxCountResponse)
            {
                MaxCountSkins = MaxCount;
            }

            var palletOpeningDateResponse = await _sortingProxy.GetPalletOpeningDate(idpallet.ToString());
            DateTime PalletOpeningDate = DateTime.MinValue;
            foreach (var OpeningDate in palletOpeningDateResponse)
            {
                PalletOpeningDate = OpeningDate;
            }


            Pallet newPallet = new Pallet();
            if (CurrentCountSkins < MaxCountSkins)
            {
                newPallet = new Pallet
                {
                    IdPallet = idpallet,
                    CurrentCountSkins = CurrentCountSkins,
                    Status = "Открыт",
                    IdTypeSkin = idtypeskin,
                    OpeningDate = PalletOpeningDate
                };
            }
            else if (CurrentCountSkins == MaxCountSkins)
            {
                newPallet = new Pallet
                {
                    IdPallet = idpallet,
                    CurrentCountSkins = CurrentCountSkins,
                    Status = "Закрыт",
                    IdTypeSkin = idtypeskin,
                    OpeningDate = PalletOpeningDate,
                    ClosingDate = DateTime.Now
                };
            }
            _skinProxy.AddSkin(newSkin);
            _palletProxy.ChangePallets(newPallet);
            await BatchListUpd();
            ConfigurationsList.Focus();
        }


        private void ConfigurationsListOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad6)
            {
                ConfigurationsList.Text = "";
                ConfigurationsList.Text = @" - Яловка";
                //ConfigurationsList.SelectedValue = 1;
            }
            if (e.KeyCode == Keys.X)
            {
                ConfigurationsList.Text = "";
                ConfigurationsList.Text = @" - Яловка свищевая";
                //ConfigurationsList.SelectedValue = 2;
            }
            if (e.KeyCode == Keys.NumPad1)
            {
                ConfigurationsList.Text = "";
                ConfigurationsList.Text = @" - Бык";
                //ConfigurationsList.SelectedValue = 3;
            }
            if (e.KeyCode == Keys.B)
            {
                ConfigurationsList.Text = "";
                ConfigurationsList.Text = @" - Бык свищевой";
                //ConfigurationsList.SelectedValue = 4;
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                ConfigurationsList.Text = "";
                ConfigurationsList.Text = @" - Лоскут";
                //ConfigurationsList.SelectedValue = 5;
            }
            SortList.Focus();

        }

        private bool isNumberEntered;

        private bool isEnter;

        private void SortListOnKeyDown(object sender, KeyEventArgs e)
        {
            isNumberEntered = false;
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                isNumberEntered = true;
            }
        }

        private void SortListOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNumberEntered == true)
            {
                e.Handled = true;
            }
            DiscountField.Focus();
        }

        private void DiscountFieldOnKeyDown(object sender, KeyEventArgs e)
        {
            isNumberEntered = false;
            isEnter = false;
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                isNumberEntered = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                isEnter = true;
            }
        }

        private void DiscountFieldOnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNumberEntered == true)
            {
                e.Handled = true;
            }
            if (isEnter == true)
            {
                NettoField.Focus();
            }

        }

        private void NettoFieldOnKeyDown(object sender, KeyEventArgs e)
        {
            isNumberEntered = false;
            isEnter = false;
            if ((e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9) || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                isNumberEntered = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                isEnter = true;
            }
        }

        private void NettoFieldOnKeyPress(object sender, KeyPressEventArgs e)
        {
            decimal netto = 0;
            decimal discount = 0;
            decimal brutto = 0;
            if (isNumberEntered == true)
            {
                e.Handled = true;
            }
            if (isEnter == true)
            {
                netto = Convert.ToDecimal(NettoField.Text);
                if (DiscountField.TextLength > 0)
                {
                    discount = Convert.ToDecimal(DiscountField.Text);
                }
                brutto = netto - discount;
                BruttoField.Text = brutto.ToString();
                SkinAddingButton.Focus();
            }
        }

        private async void SkinRemoveButtonOnClick(object sender, EventArgs e)
        {
            //Последнюю шкуру удалить
            var skin = await _skinProxy.GetLastSkin();

            await _skinProxy.DeleteSkin(skin.IdSkin.ToString());
            //вычитать ее с поддона спрашивать удаление
        }

        private async void ShowStatsButtonOnClick(object sender, EventArgs e)
        {
            var batchOpeningDateResponse = await _batchProxy.GetBatchesOpeningDate(BatchList.Text);
            var batchDebitCountResponse = await _batchProxy.GetBatchesDebitCount(BatchList.Text);
            var batchProviderIdResponse = await _batchProxy.GetBatchesProviderId(BatchList.Text);

            var batchId = Convert.ToInt32(BatchList.Text);

            var openingDate = DateTime.MinValue;
            var providerId = 0;
            var debitCount = 0;
            foreach (var od in batchOpeningDateResponse)
            {
                openingDate = od;
            }
            foreach (var dc in batchDebitCountResponse)
            {
                debitCount = dc;
            }
            foreach (var pid in batchProviderIdResponse)
            {
                providerId = pid;
            }
            Batch newBatch = new Batch();
            newBatch = new Batch
            {
                IdBatch = batchId,
                OpeningDate = openingDate,
                DebitCount = debitCount,
                IdProvider = providerId,
                BatchStatus = "Закрыта",
                ClosingDate = DateTime.Now
            };
            _sortingProxy.ChangeBatch(newBatch);
            BatchesLoad();
        }
    }
}

