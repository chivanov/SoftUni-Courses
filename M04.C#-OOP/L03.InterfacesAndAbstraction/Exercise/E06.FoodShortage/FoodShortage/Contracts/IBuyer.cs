﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage.Contracts
{
    public interface IBuyer
    {
        string Name { get; }
        int Food { get;}  
        void BuyFood();
    }
}
