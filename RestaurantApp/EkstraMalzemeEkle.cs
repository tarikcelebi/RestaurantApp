using RestaurantApp.Concretes;
using RestaurantApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class EkstraMalzemeEkle : Form
    {
        public EkstraMalzemeEkle()
        {
            InitializeComponent();
        }

        private void btnExtraProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExtraProductName.Text))
            {
                MessageBox.Show("lütfen bir Menu ismi giriniz.");
                return;
            }
            else if (nudExtraProductPrice.Value == 0)
            {
                MessageBox.Show("lütfen menü için bir Fiyat giriniz.");
                return;
            }
            else
            {
                ExtraProducts extraProduct = new ExtraProducts();
                extraProduct.Name = txtExtraProductName.Text;
                extraProduct.Price = (int)nudExtraProductPrice.Value;

                MainMenu.ExtraProducts.Add(extraProduct);
                Helper.Helper.Sifirlama(this.Controls);
            }

        }



       

    }
}
