﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class MainCourse : Meal, IMainCourse
    {
        public MainCourse(string name, decimal price, int calories, int quantityPerServing,
            int timeToPrepare, bool isVegan, MainCourseType type)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.Type = type;
        }

        public MainCourseType Type { get; private set; }

        public override string ToString()
        {
            var result = base.ToString() + string.Format("\nType: {0}", this.Type);
            if (this.IsVegan)
            {
                result = "[VEGAN] " + result;
            }

            return result;
        }
    }
}
