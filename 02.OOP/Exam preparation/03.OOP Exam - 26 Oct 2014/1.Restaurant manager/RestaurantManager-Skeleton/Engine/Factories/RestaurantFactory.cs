using RestaurantManager.Models;

namespace RestaurantManager.Engine.Factories
{
    using System;
    using RestaurantManager.Interfaces.Engine;

    public class RestaurantFactory : IRestaurantFactory
    {
        public Interfaces.IRestaurant CreateRestaurant(string name, string location)
        {
            var restaurant = new Restaurant(name, location);
            return restaurant;
        }
    }
}
