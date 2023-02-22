using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vellsPos.Entities.Masters
{
    internal class Product_Discountscs
    {
        private Int32 id;
        private Product product;
        private Discount discount;

        public Product_Discountscs(int id, Product product, Discount discount)
        {
            this.Id = id;
            this.Product = product;
            this.Discount = discount;
        }

        public int Id { get => id; set => id = value; }
        internal Product Product { get => product; set => product = value; }
        internal Discount Discount { get => discount; set => discount = value; }
    }
}
