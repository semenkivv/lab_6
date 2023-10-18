using System;


namespace Laba_6_V_11
{
    public class DessertRecipe:Recipe
    {
        private readonly int MAX_SWEETNESS_RAITING = 10;

        private int _sweetnessRating;
        private bool _isNeedSpecialEquipment;
        private bool _isHaveFruit;

        public DessertRecipe(string name,int countCalories, int sweetnessRating, bool isNeedSpecialEquipment, bool isHaveFruit) : base(name,countCalories)
        {
            SweetnessRating = sweetnessRating;
            IsNeedSpecialEquipment = isNeedSpecialEquipment;
            IsHaveFruit = isHaveFruit;
        }

        /// <summary>
        ///СВойство рейтинг по сладости , возвращает ArgumentOutOfRangeException, если пытаемся присвоить отрицательное значение или больше максимально допустимого значения(MAX_SWEETNESS_RAITING)
        /// </summary>
        private int SweetnessRating
        {
            get => _sweetnessRating;
            set
            {
                if (value >= 0 && value <= MAX_SWEETNESS_RAITING)
                {
                    _sweetnessRating = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        /// <summary>
        /// Свойство необходимо ли специальное оборудование
        /// </summary>
        private bool IsNeedSpecialEquipment
        {
            get => _isNeedSpecialEquipment;
            set => _isNeedSpecialEquipment = value;
        }
        /// <summary>
        /// Свойство есть ли фрукты в десертном рецепте 
        /// </summary>
        private bool IsHaveFruit
        {
            get => _isHaveFruit;
            set => _isHaveFruit = value;
        }
        public override string ToString()
        {
            return base.ToString() + $"DessertRecipe(sweetnessRating={SweetnessRating}/10;is need special equipment={IsNeedSpecialEquipment};is have fruit ={IsHaveFruit})\n";
        }
    }
}
