using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOnWF
{
    partial class Backend
    {
        string _numstr; // Вводимое число
        Numbers _numbers; // Список чисел (хранит числа)
        Operations _operations; // Список операций (хранит операции)

        internal Backend()
        {
            _numbers = new Numbers();
            _operations = new Operations();

            _numstr = "0";
        } 
        internal string GetNumstr
        {
            get
            {
                return _numstr;
            }
        }



        internal string Equal()
        {
            if (_operations.Count == 0) // Если не введено ни одной операции.
            {
                if(_numstr.Length != 0 & _numstr != "-") // Если есть введенное число
                {
                    EnterNumberInNumbersClass(); // Вводится вводимое число в пример
                    string example = OutputExample() + " = "; // Это пример
                    Calculations();
                    return example;
                }
                else
                {
                    return "";
                }
            }
            else // Есть пример
            {
                if (_numstr == "" || _numstr == "-") // Если нет вводимого числа (числа == операции)
                {
                    _operations.RemoveLastOperation(); 
                    string example = OutputExample() + " = "; // Это пример
                    Calculations();
                    return example;
                }
                else // (числа != операции (>) )
                {
                    EnterNumberInNumbersClass(); // Вводится вводимое число в пример
                    string example = OutputExample() + " = "; // Это пример
                    Calculations();
                    return example;
                }
            }
        } //! Когда нажимаешь равно. Вычисление ответа!

        internal void WriteComma()
        {
            if (_numstr == "" || _numstr == "-" || _numstr == "∞" || _numstr == "-∞" || _numstr == "не число") 
            {

            }
            else
            {
                try
                {
                    foreach (char s in _numstr)
                        if (s == ',') throw new Exception("Запятая уже есть...");
                    _numstr += ",";
                }
                catch (Exception mistake)
                {
                    Console.WriteLine(mistake.Message);
                }
            }
        } //! Когда нажимают на запятую. Занесение запятой в число

        internal void WritingNumber(int number)
        {
            if (_numstr == "∞" || _numstr == "-∞" || _numstr == "не число") // Если число = ∞ | -∞ или "не число", то ничего не выведится
            {

            }
            else if (number == 0) // Если заносится 0 
                WriteZeroInNumber();
            else // Если заносится любая другая цифра
            {
                if (_numstr == null | _numstr == "0") // Она занесется, если вводимое число пустое или Она занесется, если число = 0 (Она замит 0)
                {
                    _numstr = number.ToString();
                }
                else
                {
                    _numstr += $"{number}";
                }
            }
        } //! Когда нажимают цифры
        internal void Enter(char operation)
        {
            if (_numstr == "" || _numstr == "-") // Если нет вводимого числа, то заменя предыдущей операции (вводимое число заносится когда выбираешь базовую операцию)
            {
                if (_numstr == "-")
                    _numstr = "";

                if (_operations.Count == 0) { }
                else if (_operations.Count == _numbers.Count) // Замена последней операции
                {
                    _operations.ReplaceLastOperation(operation);
                }
            }
            else
            {
                EnterNumberInNumbersClass();
                EnterOperationInOperationsClass(operation);
            }
        } //! Когда нажимаешь на одну из базовых операций (+-*/). Ввод числа и операции 

        internal void Erase()
        {
            if(_numstr == "не число")
            {
                _numstr = "";
            }
            else if (_numstr.Length == 0) // В случае, если вводимого числа нет. Стирать сам пример
            {
                EraseExample();
            }
            else // стирает число
            {
                _numstr = _numstr.Remove(_numstr.Length - 1, 1);
            }
        } //! Когда нажимают кнопку Стереть

        internal void Clear()
        {
            _numbers = new Numbers();
            _operations = new Operations();

            _numstr = "0";
        } //! Когда нажимают кнопку C (Стереть)
        internal void ClearNumber()
        {
            if (_numstr.Length != 0) // Если вводимое число есть, то стереть его
            {
                _numstr = "";
            }
            else // Если вводимого числа нет, то стереть пример
            {
                Clear();
            }
        } //! Когда нажимают кнопку CE (Стереть)

        internal void ChangeSignOfNumber()
        {
            if (_numstr == "") { }
            else
            {
                if (_numstr[_numstr.Length - 1] != ',') // Если в вводимом числе последний не ","
                {
                    double number = double.Parse(_numstr);
                    number = number - number * 2;
                    _numstr = $"{number}";
                }
                else // Если в вводимом числе последний - ","
                {
                    double number = double.Parse(_numstr);
                    number = number - number * 2;
                    _numstr = _numstr = $"{number},";
                }
            }
        } //! Когда нажимают кнопку "+/-" (смена знака числа)
        internal void OnePrecentFromNumber()
        {
            if (_numstr == "") { }
            else
            {
                if (_numstr[_numstr.Length - 1] != ',') // Если в вводимом числе последний не ","
                {
                    double number = double.Parse(_numstr);
                    _numstr = $"{(number / 100)}";
                }
                else // Если в вводимом числе последний - ","
                {
                    double number = double.Parse(_numstr);
                    _numstr = _numstr = $"{(number / 100)},";
                }
            }
        } //! Когда нажимают кнопку "%" (один процент от числа)
        internal void OneDivideByNumber()
        {
            if (_numstr.Length != 0) // Если вводимого числа нет, то ничего не будет
            {
                _numstr = (1 / double.Parse(_numstr)).ToString();
            }
        } //! Когда нажимают кнопку "1/x"
        internal void RaiseNumber()
        {
            if (_numstr.Length != 0)
            {
                _numstr = (Math.Pow(double.Parse(_numstr), 2)).ToString();
            }
        } //! Когда нажимают кнопку "x^2"
        internal void RadicalNumber()
        {
            if (_numstr.Length != 0)
            {
                _numstr = (Math.Sqrt(double.Parse(_numstr))).ToString();
            }
        } //! Когда нажимают кнопку "x^0.5"



        internal string OutputExample()
        {
            if (_operations.Count == _numbers.Count) // Если колличество операций = колличеству чисел
            {
                string example = "";
                for (int k = 0; k < _operations.Count; k++)
                {
                    if (_numbers[k] >= 0) // Если число больше нуля, то вывести без скобок
                    {
                        example += $"{_numbers[k].ToString()} {_operations[k].ToString()} ";
                    }
                    else
                    {
                        example += $"({_numbers[k].ToString()}) {_operations[k].ToString()} ";
                    }
                }
                return example;
            }
            else // Если колличество операций != колличеству чисел
            {
                string example = "";
                for (int k = 0; k < _operations.Count; k++)
                {
                    if (_numbers[k] >= 0) // Если число больше нуля, то вывести без скобок
                    {
                        example += $"{_numbers[k].ToString()} {_operations[k].ToString()} ";
                    }
                    else
                    {
                        example += $"({_numbers[k].ToString()}) {_operations[k].ToString()} ";
                    }
                }
                if (_numbers[_numbers.Count - 1] >= 0) // Если последнее число больше нуля, то вывести без скобок
                {
                    example += _numbers[_numbers.Count - 1];
                }
                else
                {
                    example += $"({_numbers[_numbers.Count - 1]})";
                }
                return example;
            }
        } // Вывод примера на форму
    }
    partial class Backend
    {
        internal void WriteZeroInNumber()
        {
            if (_numstr.Length == 1 & _numstr == "0") // Ноль не занесется, если вводимое число = 0 (т е чисто '0' без ',')
            {

            }
            else
            {
                _numstr += "0";
            }
        } // Занесение Нуля в вводимое число
        internal void EraseExample()
        {
            if (_numbers.Count == _operations.Count) // Если в примере последнее это операция. Стираоет последнюю операцию.
            {
                _operations.RemoveLastOperation();
                _numstr = _numbers.RemoveLastNumber();
            }
        } // Стирает пример (Когда стирать уже нечего (т.е. когда вводимого числа нет))

        internal void EnterOperationInOperationsClass(char operation)
        {
            _operations.WriteOperation(operation);
        } // Занесение операции в список операций
        internal void EnterNumberInNumbersClass()
        {
            _numbers.WriteNumber(double.Parse(_numstr));
            _numstr = "";
        } // Занесения числа в список чисел

        internal void Calculations() // Вычисление ответа
        {
            //  Приоритеты операций: 
            //  1.  '*', '/' (слева направо)
            //  2.  '+', '-' (слева направо)

            for (int k = 0; k < _operations.Count;)
            {
                if (_operations[k] == '×')
                {
                    double? number = _numbers[k] * _numbers[k + 1];

                    _operations.RemoveItem(k);
                    _numbers.RemoveItem(k + 1);

                    _numbers[k] = number;
                }
                else if (_operations[k] == '÷')
                {
                    double? number = _numbers[k] / _numbers[k + 1];

                    _operations.RemoveItem(k);
                    _numbers.RemoveItem(k + 1);

                    _numbers[k] = number;
                }
                else k++;
            } // 1-й этап. Поиск умножений и делений
            for (int k = 0; k < _operations.Count;)
            {
                if (_operations[k] == '+')
                {
                    double? number = _numbers[k] + _numbers[k + 1];

                    _operations.RemoveItem(k);
                    _numbers.RemoveItem(k + 1);

                    _numbers[k] = number;
                }
                else if (_operations[k] == '-')
                {
                    double? number = _numbers[k] - _numbers[k + 1];

                    _operations.RemoveItem(k);
                    _numbers.RemoveItem(k + 1);

                    _numbers[k] = number;
                }
                else k++;
            } // 2-й этап. Поиск сложений и вычитаний

            _numstr = _numbers[0].ToString();
            _numbers.RemoveItem(0);
        }
    }
}
