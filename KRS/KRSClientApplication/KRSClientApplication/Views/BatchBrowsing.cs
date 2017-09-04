using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KRSClientApplication.Proxy;
using KRSServerApplication.Models;

namespace KRSClientApplication.Views
{
    public partial class BatchBrowsing : Form
    {
        private HttpClient _httpClient = new HttpClient();
        private ResponseReader _responseReader = new ResponseReader();
        BindingSource _providersBindingSource = new BindingSource();
        private ProviderProxy _providerProxy = new ProviderProxy();
        private bool _marker = false;
        public BatchBrowsing()
        {
            InitializeComponent();
            _httpClient.BaseAddress = new Uri("http://localhost:9000");
        }

        private async Task ProvidersLoad()
        {
            var providers = await _providerProxy.GetSelectedProvider();
            _providersBindingSource.DataSource = providers;
            ProvidersList.DataSource = _providersBindingSource;
            ProvidersList.DisplayMember = "ProviderLabel";
            ProvidersList.ValueMember = "IdProvider";
        }

        private async void BatchBrowsingOnLoad(object sender, EventArgs e)
        {
            await ProvidersLoad();
            _marker = true;
            ProvidersListOnProviderChanged(sender, e);
        }

        private void ProvidersListOnProviderChanged(object sender, EventArgs e)
        {
            if (_marker)
            {
                BatchProxy batchProxy = new BatchProxy();
                BindingSource batchesBindingSource = new BindingSource();
                var batches = batchProxy.GetBatches();
                var idProvider = Convert.ToInt32(ProvidersList.SelectedValue.ToString());
                batches = batches.Select(b => b).Where(b => b.IdProvider == idProvider);
                batchesBindingSource.DataSource = batches;
                BatchesInformationGrid.DataSource = batchesBindingSource;
                BatchesInformationGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void ShowSkinsButtonOnClick(object sender, EventArgs e)
        {
            SkinProxy skinProxy = new SkinProxy();
            BindingSource skinBindingSource = new BindingSource();
            var skins = skinProxy.GetSkins();
            var idBatch = Convert.ToInt32(BatchesInformationGrid.CurrentRow.Cells[0].Value);
            skins = skins.Select(s => s).Where(s => s.IdBatch == idBatch);
            skinBindingSource.DataSource = skins;
            SkinsInformationGrid.DataSource = skinBindingSource;
            SkinsInformationGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
