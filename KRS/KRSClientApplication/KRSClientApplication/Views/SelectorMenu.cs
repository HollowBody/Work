using System.Windows.Forms;

namespace KRSClientApplication.Views
{
    public partial class SelectorMenu : Form
    {
        public SelectorMenu()
        {
            InitializeComponent();
        }
        private void SortingButtonOnClick(object sender, System.EventArgs e)
        {
            Sorting sortingForm = new Sorting();
            sortingForm.Show(this);
        }

        private void CostingButtonOnClick(object sender, System.EventArgs e)
        {
            Costing costingForm = new Costing();
            costingForm.Show(this);
        }

        private void ManagingButtonOnClick(object sender, System.EventArgs e)
        {
            Management managementForm = new Management();
            managementForm.Show(this);
        }


        private void CatalogsButtonOnClick(object sender, System.EventArgs e)
        {
            CatalogsMDI catalogsForm = new CatalogsMDI();
            catalogsForm.Show(this);
        }

        private void AboutButtonOnClick(object sender, System.EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show(this);
        }
    }
}
