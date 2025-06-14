namespace cube4d6
{
    class Starting4D6Roll
    {
        public static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.Minimum = ReadInt(calculator.Minimum, "Minimum");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }

        /// <summary>
        /// Выводит сообщение и читает значение int с консоли
        /// </summary>
        /// <param name="lastUserValue">Значение по умолчанию</param>
        /// <param name="prompt">Сообщение, выводимое на консоль</param>
        /// <returns>Прочитанное значение int или значение по умолчанию, если преобразование
        /// невозможно.</returns>
        public static int ReadInt(int lastUserValue, string prompt)
        {
            Console.Write(prompt + "[" + lastUserValue + "]");

            if (int.TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("     using value " + result);
                return result;
                
            }
            return lastUserValue;
        }
        /// <summary>
        /// Выводит сообщение и читает значение int с консоли
        /// </summary>
        /// <param name="lastUserValue">Значение по умолчанию</param>
        /// <param name="prompt">Сообщение, выводимое на консоль</param>
        /// <returns>Прочитанное значение int или значение по умолчанию, если преобразование
        /// невозможно</returns>
        public static double ReadDouble(double lastUserValue, string prompt)
        {
            Console.Write(prompt + "[" + lastUserValue + "]");
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                Console.WriteLine("     using value " + result);
                return result;
            }
            return lastUserValue;
        }
    }
}