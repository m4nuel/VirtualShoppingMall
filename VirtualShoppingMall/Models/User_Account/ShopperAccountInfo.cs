using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualShoppingMall.Models.User_Account
{
    public class ShopperAccountInfo
    {
        private String shoppperID;
        private ShoppingCart.ShoppingCart myCart;

        public ShopperAccountInfo(String id)
        {
            this.shoppperID = id;
            this.myCart = new ShoppingCart.ShoppingCart();
        }

        public String ShopperID
        {
            get
            {
                return this.shoppperID;
            }
            set
            {
                this.shoppperID = value;
            }
        }

        public ShoppingCart.ShoppingCart MyCart
        {
            get
            {
                return this.myCart;
            }
        }
    }
}
