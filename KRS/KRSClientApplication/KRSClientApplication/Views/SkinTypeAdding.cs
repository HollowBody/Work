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
using KRSServerApplication.Models;

namespace KRSClientApplication.Views
{
    public partial class SkinTypeAdding : Form
    {
        private SkinTypeProxy _skinTypeProxy;


        public SkinTypeAdding()
        {
            InitializeComponent();
            _skinTypeProxy = new SkinTypeProxy();

        }

        private void SkinTypeAddingClosing(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
            Owner.Refresh();
        }

        private async void SkinTypeAddButtonOnClick(object sender, EventArgs e)
        {
            await AddSkinType();
        }

        async Task AddSkinType()
        {
            var format = new System.Globalization.NumberFormatInfo();
            format.NumberDecimalSeparator = ".";

            var skinTypes = await _skinTypeProxy.GetSkinTypes();

            decimal MinWeight = Convert.ToDecimal(MinWeightField.Text);
            decimal MaxWeight = Convert.ToDecimal(MaxWeightField.Text);
            string SkinTypeName = SkinTypeField.Text + "( " + MinWeight.ToString(format) + " - " + MaxWeight.ToString(format) + " кг)";
            int MaxCount = Convert.ToInt32(MaxCountSkinsField.Text);

            SkinType newSkinType = new SkinType { TypeSkinLabel = SkinTypeName, MinimumWeight = MinWeight, MaximumWeight = MaxWeight, MaximumCountSkin = MaxCount };

            if (skinTypes.Any(sT => sT.TypeSkinLabel == newSkinType.TypeSkinLabel))
            {
                MessageBox.Show("Тип шкуры: " + SkinTypeName + " уже существует. Введите другие параметры.", "Добавление не возможно!",
                    MessageBoxButtons.OK);
            }
            else
            {
                //Спросить уверены ли вы? и попросить ввести пароль от учетки админа
                _skinTypeProxy.AddSkinType(newSkinType);
            }
        }
    }
}
