using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.CoreBusiness.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string NamaProduk { get; set; }
        public double Harga { get; set; }
        public string LinkImage { get; set; }
  
    }
}
