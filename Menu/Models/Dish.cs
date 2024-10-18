using System.ComponentModel;

namespace Menu.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public double Price { get; set; }
        public string ImageUrl { get; set; }

       

        //connect them to the dishIngredient helper modle
        public List<DishIngredient>? DishIngredients{ get; set;}
    }
}
