﻿using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Business.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);
        Cart GetCartByUserId(string userId);    
        void AddToCart(string userId,int product,int quantity);

        void DeleteFromCart(string userId, int productId);
        void ClearCart(int cartId);
    }
}
