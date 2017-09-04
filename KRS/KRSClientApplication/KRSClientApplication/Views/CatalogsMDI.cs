using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KRSClientApplication.Proxy;

namespace KRSClientApplication.Views
{
    public partial class CatalogsMDI : Form
    {
        public CatalogsMDI()
        {
            InitializeComponent();
        }

        private void CatalogsClosing(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }

        private void ProvidersMenuItemOnClick(object sender, EventArgs e)
        {
            ProviderProxy providerProxy = new ProviderProxy();
            var strategy = new ProvidersCatalogStrategy(providerProxy);
            CatalogView catalogViewChild = new CatalogView(strategy);
            catalogViewChild.MdiParent = this;
            catalogViewChild.Text = "Поставщики";
            catalogViewChild.Show();
        }

        private void AdresseesMenuItemOnClick(object sender, EventArgs e)
        {
            AdresseeProxy adresseeProxy = new AdresseeProxy();
            var strategy = new AdresseesCatalogStrategy(adresseeProxy);
            CatalogView catalogViewChild = new CatalogView(strategy);
            catalogViewChild.MdiParent = this;
            catalogViewChild.Text = "Получатели";
            catalogViewChild.Show();
        }

        private void SkinTypeMenuItemOnClick(object sender, EventArgs e)
        {
            SkinTypeProxy skinTypeProxy = new SkinTypeProxy();
            var strategy = new SkinTypesCatalogStrategy(skinTypeProxy);
            CatalogView catalogViewChild = new CatalogView(strategy);
            catalogViewChild.MdiParent = this;
            catalogViewChild.Text = "Типы шкур";
            catalogViewChild.Show();
        }

        private void SchemesMenuItemOnClick(object sender, EventArgs e)
        {
            SchemeProxy schemeProxy = new SchemeProxy();
            var strategy = new SchemesCatalogStrategy(schemeProxy);
            CatalogView catalogViewChild = new CatalogView(strategy);
            catalogViewChild.MdiParent = this;
            catalogViewChild.Text = "Схемы сортировки";
            catalogViewChild.Show();
        }

        private void ConfigurationsMenuItemOnClick(object sender, EventArgs e)
        {
            ConfigurationProxy configurationProxy = new ConfigurationProxy();
            var strategy = new ConfigurationsCatalogStrategy(configurationProxy);
            CatalogView catalogViewChild = new CatalogView(strategy);
            catalogViewChild.MdiParent = this;
            catalogViewChild.Text = "Конфигурации";
            catalogViewChild.Show();
        }
    }
}
