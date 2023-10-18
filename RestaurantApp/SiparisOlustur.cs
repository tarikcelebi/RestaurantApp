using RestaurantApp.Concretes;
using RestaurantApp.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp
{
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }

        int Menufiyat = 0;

        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            Menu Menu1 = new Menu();
            Menu1.Name = "Whopper";
            Menu1.Price = 180;
            MainMenu.Menuler.Add(Menu1);

            ExtraProducts extraProduct1 = new ExtraProducts();
            extraProduct1.Name = "Ketçap";
            extraProduct1.Price = 3;
            MainMenu.ExtraProducts.Add(extraProduct1);
            ExtraProducts extraProduct2 = new ExtraProducts();
            extraProduct2.Name = "Mayonez";
            extraProduct2.Price = 3;
            MainMenu.ExtraProducts.Add(extraProduct2);

            foreach (Menu menu in MainMenu.Menuler)
            {
                cmbMenuSelect.Items.Add(menu);
            }

            flowlpCreateOrder.FlowDirection = FlowDirection.TopDown;

            foreach (ExtraProducts extraProducts in MainMenu.ExtraProducts)
            {
                CheckBox cb = new CheckBox();
                cb.Text = string.Empty;
                cb.Text = extraProducts.Name;
                cb.Tag = extraProducts;
                flowlpCreateOrder.Controls.Add(cb);
            }


        }


        private void btnAddLstCreateOrder_Click(object sender, EventArgs e)
        {

            İsNullOrEmpty();

            Siparis siparis = new Siparis();

            siparis.MenuName = (Menu)cmbMenuSelect.SelectedItem;
            foreach (Menu menu in MainMenu.Menuler)
            {
                if (cmbMenuSelect.SelectedItem == menu)
                {
                    siparis.Price = menu.Price;
                    break;
                }
            }
            bool atLeastOneCheckBoxChecked = false;

            foreach (CheckBox cbox in flowlpCreateOrder.Controls)
            {
                if (cbox.Checked)
                {
                    atLeastOneCheckBoxChecked = true;
                    siparis.ExtraProducts.Add((ExtraProducts)cbox.Tag);
                }
            }

            if (!atLeastOneCheckBoxChecked)
            {
                MessageBox.Show("Lütfen en az bir ekstra ürün seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Eğer hiçbir CheckBox seçilmemişse işlemi durdur
            }
            siparis.ExtraProductTotal = 0;
            siparis.Number = (int)nudNumberOfMenu.Value;

            foreach (ExtraProducts extraProducts in siparis.ExtraProducts)
            {
                siparis.ExtraProductTotal += extraProducts.Price;
            }

            siparis.Total = (siparis.Number * siparis.Price) + (siparis.ExtraProductTotal * siparis.Number);

            if (rbSmall.Checked)
            {
                siparis.Total = 1 * ((siparis.Number * siparis.Price) + (siparis.ExtraProductTotal * siparis.Number));
            }
            if (rbMedium.Checked)
            {
                siparis.Total = 1.5 * ((siparis.Number * siparis.Price) + (siparis.ExtraProductTotal * siparis.Number));
            }
            else
            { siparis.Total = 1.75 * ((siparis.Number * siparis.Price) + (siparis.ExtraProductTotal * siparis.Number)); }


            MainMenu.Siparisler.Add(siparis);

            lstCreateOrder.Items.Add(siparis);

            siparis.TotalCiro = 0;
            siparis.TotalNumber = 0;

            foreach (Siparis siparis1 in MainMenu.Siparisler)
            {
                siparis.TotalCiro += siparis1.Total;
                siparis.TotalNumber += siparis1.Number;
            }




            MainMenu.Siparisler.Add(siparis);


            lblTotalPriceCreateOrder.Text = siparis.TotalCiro.ToString();
            Helper.Helper.Sifirlama(this.Controls);
        }

        private void btnOrderConfirm_Click(object sender, EventArgs e)
        {
            TumSiparisler tsf = new TumSiparisler();
            tsf.MdiParent = this.MdiParent; // Ana formun MdiParent'ını kullanarak ayarlayın
            tsf.Dock = DockStyle.Fill;
            tsf.Height = this.MdiParent.ClientRectangle.Height;
            tsf.Width = this.MdiParent.ClientRectangle.Width;
            tsf.Show();

        }



        private void İsNullOrEmpty()
        {

            bool isRadioButtonSelected = false;

            if (rbSmall.Checked || rbMedium.Checked || rbLarge.Checked)
            {
                isRadioButtonSelected = true;
            }

            if (!isRadioButtonSelected)
            {
                MessageBox.Show("Lütfen bir boyut seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Eğer hiçbir RadioButton seçilmemişse işlemi durdur
            }

            if (cmbMenuSelect.SelectedIndex == -1 || cmbMenuSelect.SelectedItem == null)
            {
                MessageBox.Show("lütfen bir menü seçiniz");


            }
            else if (nudNumberOfMenu.Value == 0)
            {
                MessageBox.Show("lütfen kaç adet menü eklemek istediğinizi belirtiniz.");
            }
        }


    }
}
