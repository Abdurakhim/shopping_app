﻿using Shopping_app.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_app.Data.Interfaces
{
   public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
