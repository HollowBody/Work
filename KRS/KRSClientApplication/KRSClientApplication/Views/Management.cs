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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void ManagingClosing(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }

        private void SkinTypeAddingButtonOnClick(object sender, EventArgs e)
        {
            SkinTypeAdding skinTypeAddingForm = new SkinTypeAdding();
            skinTypeAddingForm.Show(this);
        }

        private void SchemeAddingButtonOnClick(object sender, EventArgs e)
        {
            SortingSchemeAdding sortingSchemeAddingForm = new SortingSchemeAdding();
            sortingSchemeAddingForm.Show(this);
        }

        private void BatchBrowsingButtonOnClick(object sender, EventArgs e)
        {
            BatchBrowsing batchBrowsingForm = new BatchBrowsing();
            batchBrowsingForm.Show(this);
        }

        private void PalletManagingButtonOnClick(object sender, EventArgs e)
        {
            PalletManagement palletManagementForm = new PalletManagement();
            palletManagementForm.Show(this);
        }
    }
}
