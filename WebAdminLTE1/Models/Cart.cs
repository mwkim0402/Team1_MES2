using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication0106.Models
{
    public class Cart
    {

        public class CartLine
        {
            public Product product { get; set; }
            public int Qty { get; set; }
        }

        private List<CartLine> lines = new List<CartLine>();

        public void AddItem(Product product, int qty)
        {
            //신규로 추가되는 제품인지, 기존에 추가되어 있는 제품인지.

            CartLine line = Lines.Where(p => p.product.ProductID == product.ProductID).FirstOrDefault();

            if (line == null)
            {
                lines.Add(new CartLine
                {
                    product = product,
                    Qty = qty
                });

            }
            else
            {
                line.Qty += qty;
            }
        }

        public void RemoveItem(Product product)
        {
            lines.RemoveAll(i => i.product.ProductID == product.ProductID);
        }

        public List<CartLine> Lines
        {
            get { return lines; }
        }

        public decimal ComputeTotalValue()
        {
            return lines.Sum(i => i.product.Price * i.Qty);
        }
        public void Clear()
        {
            lines.Clear();
        }
    }

 
}