﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models.ViewModels
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();
        public virtual void AddItem(Product product, int quantity)
        {
            //check product already in cart
            CartLine item = lineCollection
                .Where(p => p.Product.ProductID == product.ProductID)
                .FirstOrDefault();

            //add or update
            if (item==null)
            {
                lineCollection.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                item.Quantity += quantity;
            }
        }
        public virtual void RemoveItem(Product product) => lineCollection.RemoveAll(i => i.Product.ProductID == product.ProductID);
        public decimal TotalPrice() => lineCollection.Sum(e => e.Product.Price * e.Quantity);
        public virtual void Clear() => lineCollection.Clear();
        public List<CartLine> Lines => lineCollection;
    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
