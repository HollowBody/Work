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

    public partial class BatchRegistration : Form
    {
        private ProviderProxy _providerProxy = new ProviderProxy();
        private BindingSource _providersBindingSource = new BindingSource();
        private SchemeProxy _schemeProxy = new SchemeProxy();
        private BindingSource _sortingSchemeBindingSource = new BindingSource();
        private BatchProxy _batchProxy = new BatchProxy();

        public BatchRegistration()
        {
            InitializeComponent();
        }

        private async void BatchRegistrationOnLoad(object sender, EventArgs e)
        {
            DateTimeSelector.Value = DateTime.Now;

            await ProvidersLoad();

            await SchemesLoad();


        }

        private async Task ProvidersLoad()
        {
            var providers = await _providerProxy.GetSelectedProvider();
            _providersBindingSource.DataSource = providers;
            ProvidersList.DataSource = _providersBindingSource;
            ProvidersList.DisplayMember = "ProviderLabel";
            ProvidersList.ValueMember = "IdProvider";
        }

        private async Task SchemesLoad()
        {
            var schemes = await _schemeProxy.GetSchemes();
            _sortingSchemeBindingSource.DataSource = schemes;
            SortingSchemeList.DataSource = _sortingSchemeBindingSource;
            SortingSchemeList.DisplayMember = "SchemeLabel";
            SortingSchemeList.ValueMember = "IdScheme";
        }

        private void RegistrationButtonOnClick(object sender, EventArgs e)
        {
            Batch newBatch = new Batch { BatchStatus = StatusField.Text, OpeningDate = DateTime.Now, IdProvider = Convert.ToInt32(ProvidersList.SelectedValue.ToString()), IdScheme = Convert.ToInt32(SortingSchemeList.SelectedValue.ToString()), DebitCount = 0, SortingCount = 0 };

            try
            {
                _batchProxy.AddBatch(newBatch);
                Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }


        }

        private void BatchRegistrationOnClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
            //Owner.BatchLoad Вызвать для обновления списка партий
        }
    }
}
