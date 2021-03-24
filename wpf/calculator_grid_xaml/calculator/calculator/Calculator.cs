using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator
    {
        private char CurrentOperation = ' ';
        private double PreviousNumber = 0;
        private List<char> ValidOperations = new List<char> { '+','-','*','/','=' };

        public double calculate (double number, char type)
        {
            double CurrentNumber = number;

            if (CurrentOperation != ' ')
            {
                switch (CurrentOperation)
                {
                    case '+':
                        CurrentNumber = PreviousNumber + number;
                        break;
                    case '-':
                        CurrentNumber = PreviousNumber - number;
                        break;
                    case '*':
                        CurrentNumber = PreviousNumber * number;
                        break;
                    case '/':
                        CurrentNumber = PreviousNumber / number;
                        break;
                    
                }
            }
            if (ValidOperations.Contains(type))
            {
                CurrentOperation = type;
                PreviousNumber = CurrentNumber;
            }
            return CurrentNumber;
        }
    }
}
