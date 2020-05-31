using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{
    static class Globals
    {
        public static List<recipe> receitas = new List<recipe>();
        public static List<recipe> customs = new List<recipe>();

        public static void InitListaReceitas()
        {
            // List<string> ingredientes = new List<string>();
            //ingredientes.Add("massa");
            // ingredientes.Add("carne");
            //recipe receita = new recipe("Bolonhesa", ingredientes);
            // Globals.receitas.Add(receita);

            List<string> soupLi = new List<string>() { "Water", "Potato", "Salt", "Carrot", "Onion" };
            List<string> pizzaLi = new List<string>() { "Tomato", "Cheese", "Pineapple", "Ham", "Bread" };
            List<string> strawbICLi = new List<string>() {"Condensed Milk", "Water", "Strawberry Jelly" };
            List<string> lemonadeLi = new List<string>() {"Lemon", "Water", "Sugar" };
            List<string> burguerLi = new List<string>() {"Lettuce", "Tomato", "Hamburguer", "Bread", "Egg", "Cheese" };
            

            recipe soup = new recipe("Soup", soupLi, "Soup", "In a large soup pan over medium-high heat add the onion and then stir in the carrots and the potato. Allow to cook a minute or two, and then add the salt and water, adding more water to cover if needed. Simmer until the carrots are tender, 10 - 15 minutes, then puree using a blender or hand blender until the soup is completely silky smooth.") ;
            recipe pizza = new recipe("Pizza", pizzaLi, "Fast-Food", "Preheat oven to 450 degrees F(230 degrees C).Turn dough out onto a lightly floured surface and pat or roll into a round.Transfer crust to a lightly greased pizza pan or baker's peel dusted with cornmeal. Spread with tomato, cheese and pineapple and bake in preheated oven for 15 to 20 minutes, or until golden brown.Let baked pizza cool for 5 minutes before serving.");
            recipe strawbIC = new recipe("Strawberry Ice Dessert", strawbICLi, "Dessert", "Dissolve all the gelatin in the boiling water and mix well until everything dissolves.Add ice water and mix again.Add the condensed milk, beat for about 3 minutes and pour into an ovenproof dish, dish or bowls.Then take it to the freezer for 2 hours or until it is very consistent. Serve immediately.");
            recipe lemonade = new recipe("Lemonade", lemonadeLi, "Drinks", "In a small saucepan, combine sugar and 1 cup water. Bring to boil and stir to dissolve sugar. Allow to cool to room temperature, then cover and refrigerate until chilled. Remove seeds from lemon juice, but leave pulp.In pitcher, stir together chilled syrup, lemon juice and remaining 7 cups water.");
            recipe burguer = new recipe("Burger", burguerLi, "Fast-Food", "Fry the hamburger, and then put it in the bread. Make alternating layers of lettuce, tomato and cheese and finally put fried egg, then cover with another slice of bread. Enjoy.");
            


            Globals.receitas.Add(soup);
            Globals.receitas.Add(pizza);
            Globals.receitas.Add(strawbIC);
            Globals.receitas.Add(lemonade);
            Globals.receitas.Add(burguer);
            

        }
    }
}
