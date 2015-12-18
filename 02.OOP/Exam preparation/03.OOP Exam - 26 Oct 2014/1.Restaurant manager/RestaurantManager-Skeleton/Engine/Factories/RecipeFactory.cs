using RestaurantManager.Models;

namespace RestaurantManager.Engine.Factories
{
    using System;
    using RestaurantManager.Interfaces;
    using RestaurantManager.Interfaces.Engine;

    public class RecipeFactory : IRecipeFactory
    {
        public IDrink CreateDrink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
        {
            var drink = new Drink(name, price, calories, quantityPerServing, timeToPrepare, isCarbonated);
            return drink;
        }

        public ISalad CreateSalad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
        {
            var salad = new Salad(name, price, calories, quantityPerServing, timeToPrepare, containsPasta);
            return salad;
        }
        
        public IMainCourse CreateMainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
        {
            var mainCourse = new MainCourse(name, price, calories, quantityPerServing, timeToPrepare, isVegan,
                GetMainCourseType(type));
            return mainCourse;
        }

        public IDessert CreateDessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
        {
            var dessert = new Dessert(name, price, calories, quantityPerServing, timeToPrepare, isVegan, true);
            return dessert;
        }
        
        private MainCourseType GetMainCourseType(string type)
        {
            switch (type)
            {
                case "":
                    return MainCourseType.Other;
                case "Meat":
                    return MainCourseType.Meat;
                case "Entree":
                    return MainCourseType.Entree;
                case "Pasta":
                    return MainCourseType.Pasta;
                case "Side":
                    return MainCourseType.Side;
                case "Soup":
                    return MainCourseType.Soup;
                default:
                    throw new ArgumentException("There is no such type of main course!");
            }
        }
    }
}
