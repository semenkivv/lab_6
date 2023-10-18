using System;


namespace Laba_6_V_11
{
    public class MainDishRecipe:Recipe
    {
        private bool _isUsingMeat;
        private string _nationalDishCountry;
        private string _secretIngridient;

        public MainDishRecipe(string name, int countCalories ,string nationalDishCountry, bool isUsingMeat, string secretIngridient="unknown") : base(name, countCalories)
        {
            NationalDishCountry = nationalDishCountry;
            IsUsingMeat = isUsingMeat;
            SecretIngridient = secretIngridient;

        }
        /// <summary>
        /// Свойство присутствует ли мясо в врецепте 
        /// </summary>
        private bool IsUsingMeat
        {
            get => _isUsingMeat;
            set => _isUsingMeat = value;
        }
        /// <summary>
        /// Свойство национальное блюдо какой страны  , возвращает ArgumentNullException, если пытаемся присвоить пустую строку
        /// </summary>
        private string NationalDishCountry
        {
            get => _nationalDishCountry;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nationalDishCountry = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        /// Свойство секретный ингридиент , возвращает ArgumentNullException, если пытаемся присвоить пустую строку
        /// </summary>
        private string SecretIngridient
        {
            get => _secretIngridient;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _secretIngridient = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"MainDishRecipe(national dish country={NationalDishCountry}; is using meat={IsUsingMeat};secret ingridient ={SecretIngridient})\n";
        }
    }
}
