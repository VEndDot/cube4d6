using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube4d6
{
    class AbilityScoreCalculator
    {
        public int RollResult = 14; // результат броска
        public double DivideBy = 1.75; // разделить на
        public int AddAmount = 2; // добавить сумму
        public int Minimum = 3;
        public int Score; // счет

        /// <summary>
        /// Расчистывает сумму счета результата броска кубика
        /// </summary>
        public void CalculateAbilityScore()
        {
            // Результат броска делится на значение поля "разделить на"
            double divide = RollResult / DivideBy;
            // AddAmount прибавляется к результату деления
            int added = AddAmount + (int)divide;

            // Если результат слишком мал, используем минимальное значение
            if (added < Minimum)
            {
                Score = Minimum;
            }
            else
            {
                Score = added;
            }
        }

    }
}
