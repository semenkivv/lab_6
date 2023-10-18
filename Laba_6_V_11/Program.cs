using System;

namespace Laba_6_V_11
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkRecipe drinkRecipe1 = new DrinkRecipe(name: "kvas", countCalories: 10, isAlcoholic: false, isNeedJuicer: true, seasonForDrink: "summer");
            MainDishRecipe mainDishRecipe1 = new MainDishRecipe(name: "olivie", countCalories: 123,nationalDishCountry:"ukraine",isUsingMeat:true);
            DessertRecipe dessertRecipe1 = new DessertRecipe(name: "cake", countCalories: 10,sweetnessRating:10,isNeedSpecialEquipment:true,isHaveFruit:true);

            Recipes recipes = new Recipes(drinkRecipe1, mainDishRecipe1, mainDishRecipe1, dessertRecipe1);
            Console.WriteLine(recipes);
            Console.WriteLine("-------------------------------------------------------------");
            recipes.RemoveByIndex(2);
            Console.WriteLine(recipes);
            Console.WriteLine("-------------------------------------------------------------");
            recipes.Add(mainDishRecipe1);
            Console.WriteLine(recipes);
            Console.WriteLine("-------------------------------------------------------------");
            recipes.UpdateByIndex(dessertRecipe1, 3);
            Console.WriteLine(recipes);
            Console.WriteLine("-------------------------------------------------------------");
            dessertRecipe1.PrepareIngredients();
            dessertRecipe1.Cook();
            Console.WriteLine(recipes);

        }
    }
}
