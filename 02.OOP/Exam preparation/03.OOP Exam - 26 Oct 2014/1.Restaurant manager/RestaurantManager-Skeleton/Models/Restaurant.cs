using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Restaurant : IRestaurant
    {
        private string name;
        private string location;
        IList<IRecipe> recipes = new List<IRecipe>();

        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }
                this.name = value;
            }
        }

        public string Location
        {
            get { return this.location; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Location cannot be null or empty!");
                }
                this.location = value;
            }
        }

        public IList<IRecipe> Recipes
        {
            get { return this.recipes; }
        }

        public void AddRecipe(IRecipe recipe)
        {
            this.recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("***** {0} - {1} *****", this.Name, this.Location);
            
            if (this.Recipes.Count == 0)
            {
                result.AppendLine();    
                result.Append("No recipes... yet");
                return result.ToString();
            }

            if (this.ContainsRecipeType("Drink"))
            {
                result.AppendLine();
                result.Append("~~~~~ DRINKS ~~~~~");
                result.Append(this.ReturnRecipesMenu("Drink"));
            }
            if (this.ContainsRecipeType("Salad"))
            {
                result.AppendLine();
                result.Append("~~~~~ SALADS ~~~~~");
                result.Append(this.ReturnRecipesMenu("Salad"));
            }
            if (this.ContainsRecipeType("MainCourse"))
            {
                result.AppendLine();
                result.Append("~~~~~ MAIN COURSES ~~~~~");
                result.Append(this.ReturnRecipesMenu("MainCourse"));
            }
            if (this.ContainsRecipeType("Dessert"))
            {
                result.AppendLine();
                result.Append("~~~~~ DESSERTS ~~~~~");
                result.Append(this.ReturnRecipesMenu("Dessert"));
            }
            

            return result.ToString();
        }

        private bool ContainsRecipeType(string recipeType)
        {
            if (this.Recipes.FirstOrDefault(r => r.GetType().Name == recipeType) != null)
            {
                return true;
            }
            return false;
        }

        private string ReturnRecipesMenu(string recipeType)
        {
            var recipes = this.Recipes.Where(r => r.GetType().Name == recipeType).OrderBy(r => r.Name);

            StringBuilder result = new StringBuilder();
            foreach (var recipe in recipes)
            {
                result.AppendLine();
                result.Append(recipe.ToString());
            }

            return result.ToString();
        }
    }
}
