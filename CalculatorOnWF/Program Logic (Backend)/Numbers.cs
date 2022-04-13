using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOnWF
{
    public class Numbers
    {
        List<double?> _numbers = new List<double?>();
        public int Count
        {
            get
            {
                return _numbers.Count;
            }
        }
        public double? this[int k]
        {
            get
            {
                return _numbers[k];
            }
            set
            {
                _numbers[k] = value;
            }
        } // Позволяет вывести число из списка по индексу и изменить по индексу


        /// <summary>
        /// Заносит число в список
        /// </summary>
        /// <param name="number"></param>
        public void WriteNumber(double? number)
        {
            _numbers.Add(number);
        }


        /// <summary>
        /// Выводит список занесенных чисел в консоль
        /// </summary>
        public void ShowNumbers()
        {
            Console.Write("Текущие числа: \t\t");
            foreach (double number in _numbers)
                Console.Write($"{number} ");
            Console.WriteLine();
        }


        /// <summary>
        /// Удаляет последнее число в списке
        /// </summary>
        /// <returns></returns>
        public string RemoveLastNumber()
        {
            if (Count > 0)
            {
                double? number = _numbers[Count - 1];
                _numbers.RemoveAt(Count - 1);
                return $"{number}";
            }
            else { return ""; }
        }


        /// <summary>
        /// Удаляет число по индексу
        /// </summary>
        /// <param name="index"></param>
        public void RemoveItem(int index)
        {
            if (Count > 0)
            {
                _numbers.RemoveAt(index);
            }
        }
    }
}
