using System;


namespace Laba_6_V_11
{
    public abstract class Recipe:IRecipe
    {
        private readonly int MAX_COUNT_CALORIES = 862;
        private readonly string _name;
        private int _countCalories;


        protected Recipe(string name,int countCalories)
        {
            Status = RecipeStatuses.Initialization ;
            Name = name;
            CountCalories = countCalories;
        }
        /// <summary>
        /// Изменяет статус рецепта на PrepareIngredients(Подготовленные ингредиенты),возвращает Exception если текущий статус не равен после инициализации(Initialization), 
        /// </summary>
        public void PrepareIngredients()
        {
            if(Status == RecipeStatuses.Initialization)
            {
                Status=RecipeStatuses.PrepareIngredients;
            }
            else
            {
                throw new Exception();
            }
        }
        /// <summary>
        /// Изменяет статус рецепта на Cooked(приготовленный),возвращает Exception если текущий статус не равен подготовленные ингридиенты(PrepareIngredients), 
        /// </summary>
        public void Cook()
        {
            if (Status == RecipeStatuses.PrepareIngredients)
            {
                Status = RecipeStatuses.Cooked;
            }
            else
            {
                throw new Exception();
            }
        }
        /// <summary>
        /// Изменяет статус рецепта на ReadyForServe(готов для подачи),возвращает Exception если текущий статус не равен приготовленный(Cooked), 
        /// </summary>
        public void Serve()
        {
            if (Status == RecipeStatuses.Cooked)
            {
                Status = RecipeStatuses.ReadyForServe;
            }
            else
            {
                throw new Exception();
            }
        }
        /// <summary>
        /// Свойство название рецепта , возвращает ArgumentNullException, если пытаемся присвоить пустую строку 
        /// </summary>
        public string Name
        {
            get => _name;

            init
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        /// Свойство текущий статус блюда
        /// </summary>
        private RecipeStatuses Status { get; set; }

        /// <summary>
        ///СВойство количевстов калорий на 100г  , возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимально допустимого значения(MAX_COUNT_CALORIES)
        /// </summary>
        public int CountCalories
        {
            get => _countCalories;
            init
            {
                if (value >= 0 && value <= MAX_COUNT_CALORIES)
                {
                    _countCalories = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public override string ToString()
        {
            return $"Recipe(name={Name};status={Status};count calories={CountCalories} in 100g)\n";
        }
    }
}
