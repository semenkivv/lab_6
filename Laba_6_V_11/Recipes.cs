using System;


namespace Laba_6_V_11
{
    public class Recipes
    {
        private Recipe[] _recipes;
        /// <summary>
        /// если параметром приходит ноль инициализируем с нулевой длиной массив 
        /// </summary>
        /// <param name="recipes">елементы вставляемые в массив</param>
        public Recipes(params Recipe[] recipes)
        {
            if (recipes is not null)
            {
                _recipes = recipes;
            }
            else
            {
                _recipes = new Recipe[0];
            }
        }
        /// <summary>
        /// добавление елемента в конец массива
        /// </summary>
        /// <param name="recipe">обьект для добавления в массив</param>
        public void Add(Recipe recipe)
        {
            Array.Resize(ref _recipes, _recipes.Length + 1);
            _recipes[_recipes.Length - 1] = recipe;
        }
        /// <summary>
        /// удаления елемента массива по индексу, вернет ArgumentOutOfRangeException, если некоректный индекс
        /// </summary>
        /// <param name="indexRemove">индекс удаляемого обьекта</param>
        public void RemoveByIndex(int indexRemove)
        {
            if (indexRemove >= 0 && indexRemove < _recipes.Length)
            {
                Recipe[] newRecipes = new Recipe[_recipes.Length - 1];
                for (int i = 0, j = 0; i < _recipes.Length; i++)
                {
                    if (i != indexRemove)
                    {
                        newRecipes[j] = _recipes[i];
                        j++;
                    }
                }
                _recipes = newRecipes;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }
        /// <summary>
        /// обновление елемента по индексу , вернет ArgumentOutOfRangeException, если некоректный индекс
        /// </summary>
        /// <param name="updateElement"> новый елемент</param>
        /// <param name="indexUpdate">индекс куда обновляемого елемента</param>
        public void UpdateByIndex(Recipe updateElement, int indexUpdate)
        {
            if (indexUpdate >= 0 && indexUpdate < _recipes.Length)
            {
                _recipes[indexUpdate] = updateElement;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public override string ToString()
        {
            String result = "";
            foreach (Recipe recipe in _recipes)
            {
                result += recipe + "\n";
            }
            return result;
        }
    }
}
