using System;


namespace Laba_6_V_11
{
    public class DrinkRecipe:Recipe
    {
        private string _seasonForDrink;
        private bool _isAlcoholic;
        private bool _isNeedJuicer;


        public DrinkRecipe(string name, int countCalories, bool isAlcoholic,bool isNeedJuicer, string seasonForDrink="in any season") : base(name, countCalories)
        {
            IsAlcoholic = isAlcoholic;
            IsNeedJuicer = isNeedJuicer;
            SeasonForDrink = seasonForDrink;
        }
        /// <summary>
        /// Свойство для какого сезона напиток , возвращает ArgumentNullException, если пытаемся присвоить пустую строку
        /// </summary>
        private string SeasonForDrink
        {
            get => _seasonForDrink;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _seasonForDrink = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        /// <summary>
        /// Свойство алкогольный ли напиток  
        /// </summary>
        private bool IsAlcoholic
        {
            get => _isAlcoholic;
            set => _isAlcoholic = value;
        }
        /// <summary>
        /// Свойство нужна ли соковыжималка 
        /// </summary>
        private bool IsNeedJuicer
        {
            get => _isNeedJuicer;
            set => _isNeedJuicer = value;
        }
        public override string ToString()
        {
            return base.ToString() + $"DrinkRecipe(season for drink={SeasonForDrink};is need juicer ={IsNeedJuicer}; is alcoholic ={IsAlcoholic})\n";
        }
    }
}
