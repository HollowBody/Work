using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRSClientApplication.Views
{
    public partial class PalletView : Form
    {
        private IPalletStrategy _strategy;
        private BindingSource _palletBindingSource;
        private List<string> _headers;

        public PalletView(IPalletStrategy strategy, string status)
        {
            InitializeComponent();
            _strategy = strategy;
            _palletBindingSource = new BindingSource();
            _headers = _strategy.GetHeaders();
            RefreshGrid(status);
        }

        private void SendPalletButtonOnClick(object sender, EventArgs e)
        {
            if (PalletsGrid.CurrentRow != null)
            {
                int ID = Convert.ToInt32(PalletsGrid.CurrentRow.Cells[0].Value);
                DateTime openingTime = Convert.ToDateTime(PalletsGrid.CurrentRow.Cells[1].Value);
                DateTime closingTime = Convert.ToDateTime(PalletsGrid.CurrentRow.Cells[2].Value);
                int currentCount = Convert.ToInt32(PalletsGrid.CurrentRow.Cells[5].Value);
                int typeID = Convert.ToInt32(PalletsGrid.CurrentRow.Cells[6].Value);
                _strategy.ChangeStatusToSend(ID, openingTime, closingTime, currentCount, typeID, "Отправлен");
                RefreshGrid("Закрыт");
            }
        }

        private void ClosePalletButtonOnClick(object sender, EventArgs e)
        {
            if (PalletsGrid.CurrentRow != null)
            {
                int ID = Convert.ToInt32(PalletsGrid.CurrentRow.Cells[0].Value);
                DateTime openingTime = Convert.ToDateTime(PalletsGrid.CurrentRow.Cells[1].Value);
                int currentCount = Convert.ToInt32(PalletsGrid.CurrentRow.Cells[5].Value);
                int typeID = Convert.ToInt32(PalletsGrid.CurrentRow.Cells[6].Value);
                _strategy.ChangeStatusToClose(ID, openingTime, currentCount, typeID, "Закрыт");
                RefreshGrid("Открыт");
            }
        }

        private async Task RefreshGrid(string status)
        {
            PalletsGrid.Rows.Clear();
            PalletsGrid.Refresh();
            _palletBindingSource.DataSource = _strategy.GetWithStatus(status);
            PalletsGrid.DataSource = _palletBindingSource;

            int i = 0;

            foreach (var header in _headers)
            {
                PalletsGrid.Columns[i].HeaderText = header;
                i++;
            }

            for (int j = i; j < PalletsGrid.ColumnCount; j++)
            {
                PalletsGrid.Columns[j].Visible = false;
            }

            if (status == "Открыт")
            {
                ClosePalletButton.Visible = true;
                SendPalletButton.Visible = false;
            }
            else if (status == "Закрыт")
            {
                ClosePalletButton.Visible = false;
                SendPalletButton.Visible = true;
            }
            else
            {
                ClosePalletButton.Visible = false;
                SendPalletButton.Visible = false;
            }
            await Task.Delay(1);
            
        }
    }
}
