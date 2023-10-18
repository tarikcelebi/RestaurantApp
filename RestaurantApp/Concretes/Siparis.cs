using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Concretes
{
    public class Siparis : Product
    {
        public Siparis()
        {
            ExtraProducts = new List<ExtraProducts>();
        }
        public Menu MenuName { get; set; }  

        public List<ExtraProducts> ExtraProducts { get; set; }

        public string Size { get; set; }

        public double Total { get; set; }
        public double TotalCiro { get; set; }
        public int TotalNumber { get; set; }
        public int ExtraProductTotal { get; set; }

        public override string ToString()
        {
            string extraProductNames = string.Join(", ", ExtraProducts.Select(ep => ep.Name));

            string Infos = $" Menü : {this.MenuName.Name} Malzeme : {extraProductNames} toplam : {this.Total} ";
            return Infos;
        }

    }
}
