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
    public partial class MenuAdd : Form
    {
        public MenuAdd()
        {
            InitializeComponent();
        }

        private void MenuAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMenuName.Text))
            {
                MessageBox.Show("lütfen bir Menu ismi giriniz.");
                return;
            }
            else if (nudMenuPrice.Value == 0)
            {
                MessageBox.Show("lütfen menü için bir Fiyat giriniz.");
                return;
            }
            else
            {
                Menu Menu = new Menu();
                Menu.Name = txtMenuName.Text;
                Menu.Price = (int)nudMenuPrice.Value;                
                MainMenu.Menuler.Add(Menu);

                Helper.Helper.Sifirlama(this.Controls);
            }

        }
       
    }
}
