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
using KRSServerApplication.Models;

namespace KRSClientApplication.Views
{
    public partial class SortingSchemeAdding : Form
    {
        private HttpClient httpClient = new HttpClient();
        private ResponseReader responseReader = new ResponseReader();
        public SortingSchemeAdding()
        {
            InitializeComponent();
            httpClient.BaseAddress = new Uri("http://localhost:9000");
        }

        private void SortingSchemeAddingClosing(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }

        private void SortingSchemeAddingOnLoad(object sender, EventArgs e)
        {
            var skinTypeResponse = httpClient.GetAsync("/api/skintypes/get").GetAwaiter().GetResult();
            var skinTypes = responseReader.ReadArrayAsync<SkinType>(skinTypeResponse).GetAwaiter().GetResult();
            BindingSource skinTypesBindingSource = new BindingSource();
            skinTypesBindingSource.DataSource = skinTypes;
            SkinTypeCheckList.DataSource = skinTypesBindingSource;
            SkinTypeCheckList.DisplayMember = "TypeSkinLabel";
            SkinTypeCheckList.ValueMember = "IdTypeSkin";
        }
    }
}
