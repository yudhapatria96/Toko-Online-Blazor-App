using eShop.CoreBusiness.Models;
using eShop.UseCase.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eShop.DataStore.HardCoded
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>
            {
                new Product { Id = 495, Brand = "Creatif Dev", NamaProduk = "Baju", Harga = 50000, LinkImage = "https://www.static-src.com/wcsstore/Indraprastha/images/catalog/full//88/MTA-12252408/fortklass_peter_man_baju_kemeja_polos_pria_lengan_panjang_kemeja_formal_pria_full05_cz45x67a.jpg"},
                new Product { Id = 495, Brand = "Creatif Dev", NamaProduk = "Celana", Harga = 50000, LinkImage = "https://www.static-src.com/wcsstore/Indraprastha/images/catalog/full//88/MTA-12252408/fortklass_peter_man_baju_kemeja_polos_pria_lengan_panjang_kemeja_formal_pria_full05_cz45x67a.jpg"},
                new Product { Id = 495, Brand = "Creatif Dev", NamaProduk = "Kemeja", Harga = 50000, LinkImage = "https://www.static-src.com/wcsstore/Indraprastha/images/catalog/full//88/MTA-12252408/fortklass_peter_man_baju_kemeja_polos_pria_lengan_panjang_kemeja_formal_pria_full05_cz45x67a.jpg"},

            };
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts(string filter = null)
        {
            if (string.IsNullOrWhiteSpace(filter)) return products;

            return products.Where(x => x.NamaProduk.ToLower().Contains(filter.ToLower()));
        }
    }
}
