﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Interfaces
{
    public interface IView
    {
        object Model { get; }
        string Display();
    }
}
