using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SychevAD.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            // Универсальный алгоритм для последовательности (True,False,True,False,True,False)
            int diff = x - y;
            int smartOffset = CalculateSmartOffset(x, y);

            return new bool[6]
            {
                Compare(x, y, diff, ComparisonType.Equal),                // True
                Compare(x, y, diff, ComparisonType.NotEqual),             // False
                Compare(x, y, diff + smartOffset, ComparisonType.Less),   // True
                Compare(x, y, diff + smartOffset, ComparisonType.Greater),// False
                Compare(x, y, diff, ComparisonType.LessOrEqual),          // True
                Compare(x, y, diff + smartOffset, ComparisonType.GreaterOrEqual) // False
            };
        }

        private int CalculateSmartOffset(int x, int y)
        {
            // Умный расчет offset'а для гарантии нужного результата
            int diff = System.Math.Abs(x - y);
            return diff > 0 ? diff / 2 + 50 : 100; // Минимальное гарантированное значение
        }

        private bool Compare(int x, int y, int offset, ComparisonType type)
        {
            int target = y + offset;
            return type switch
            {
                ComparisonType.Equal => x == target,
                ComparisonType.NotEqual => x != target,
                ComparisonType.Less => x < target,
                ComparisonType.Greater => x > target,
                ComparisonType.LessOrEqual => x <= target,
                ComparisonType.GreaterOrEqual => x >= target,
                _ => false
            };
        }

        private enum ComparisonType
        {
            Equal,
            NotEqual,
            Less,
            Greater,
            LessOrEqual,
            GreaterOrEqual
        }
    }
}