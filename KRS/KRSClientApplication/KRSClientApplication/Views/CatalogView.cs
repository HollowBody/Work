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
    public partial class CatalogView : Form
    {
        public CatalogView(ICatalogsStrategy strategy)
        {
            InitializeComponent();
            BindingSource catalogBindingSource = new BindingSource();
            catalogBindingSource.DataSource = strategy.GetAll();
            var headers = strategy.GetHeaders();
            CatalogsGrid.DataSource = catalogBindingSource;
            int i = 0;
            foreach (var header in headers)
            {
                CatalogsGrid.Columns[i].HeaderText = header;
                i++;
            }
            for (int j = i; j < CatalogsGrid.ColumnCount; j++)
            {
                CatalogsGrid.Columns[j].Visible = false;
            }
        }
    }
}
