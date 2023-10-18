using RestaurantApp.Concretes;
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
    public partial class TumSiparisler : Form
    {
        public TumSiparisler()
        {
            InitializeComponent();
        }

        private void TumSiparisler_Load(object sender, EventArgs e)
        {


            foreach (Siparis siparis in MainMenu.Siparisler)
            {
                lstTotalOrders.Items.Add(siparis);
                lblTotalEndorsement.Text = siparis.TotalCiro.ToString();
                lblTotalSoldProductNumber.Text = siparis.TotalNumber.ToString();
                lblExtraProductIncome.Text = siparis.ExtraProductTotal.ToString();
                lblTotalOrderNumber.Text = (lstTotalOrders.TopIndex + 1).ToString();

            }

        }

        private void lstTotalOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
