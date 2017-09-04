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
    public partial class PalletManagement : Form
    {
        private PalletProxy _palletProxy = new PalletProxy();
        public PalletManagement()
        {
            InitializeComponent();
        }

        private void OpenedMenuButtonOnClick(object sender, EventArgs e)
        {
            var strategy = new PalletsStrategy(_palletProxy);
            PalletView palletViewChild = new PalletView(strategy, "Открыт");
            palletViewChild.MdiParent = this;
            palletViewChild.Text = "Открытые";
            palletViewChild.Show();
        }

        private void ClosedMenuButtonOnClick(object sender, EventArgs e)
        {
            var strategy = new PalletsStrategy(_palletProxy);
            PalletView palletViewChild = new PalletView(strategy, "Закрыт");
            palletViewChild.MdiParent = this;
            palletViewChild.Text = "Закрытые";
            palletViewChild.Show();
        }

        private void SendMenuButtonOnClick(object sender, EventArgs e)
        {
            var strategy = new PalletsStrategy(_palletProxy);
            PalletView palletViewChild = new PalletView(strategy, "Отправлен");
            palletViewChild.MdiParent = this;
            palletViewChild.Text = "Отправленные";
            palletViewChild.Show();
        }
    }
}
