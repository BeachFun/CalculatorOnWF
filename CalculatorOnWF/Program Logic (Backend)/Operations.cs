using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOnWF
{
    public class Operations
    {
        List<char> _operations = new List<char>();
        public int Count
        {
            get
            {
                return _operations.Count;
            }
        }
        public char this[int k]
        {
            get
            {
                return _operations[k];
            }
        }
        public void WriteOperation(char operation)
        {
            _operations.Add(operation);
        }
        public void ShowOperations()
        {
            Console.Write("Текущие операции: \t");
            foreach (char operation in _operations)
                Console.Write($"{operation} ");
            Console.WriteLine();
        }
        public void RemoveLastOperation()
        {
            if (Count > 0)
            {
                _operations.RemoveAt(Count - 1);
            }
        }
        public void RemoveItem(int index)
        {
            if (Count > 0)
            {
                _operations.RemoveAt(index);
            }
        }
        public void ReplaceLastOperation(char operation)
        {
            if (Count > 0)
            {
                _operations.RemoveAt(Count - 1);
                _operations.Add(operation);
            }
        }
    }
}
