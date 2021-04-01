using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator
    {
        private char LastOperation = ' ';
        private double PreviousNumber = 0;
        private List<char> ValidOperations = new List<char> {'+','-','*','/','=','%'};

        public void reset ()
        {
            LastOperation = ' ';
            PreviousNumber = 0;
        }

        public double calculate (double number, char type)
        {
            
            double CurrentNumber = number;

            if (type == '%')
            {
                CurrentNumber = (PreviousNumber * number) / 100;
            }
            switch (LastOperation)
            {
                case '+':
                    CurrentNumber = PreviousNumber + number;
                    PreviousNumber = CurrentNumber;
                    break;
                case '-':
                    CurrentNumber = PreviousNumber - number;
                    PreviousNumber = CurrentNumber;
                    break;
                case '*':
                    CurrentNumber = PreviousNumber * number;
                    PreviousNumber = CurrentNumber;
                    break;
                case '/':
                    CurrentNumber = PreviousNumber / number;
                    PreviousNumber = CurrentNumber;
                    break;
            }
            LastOperation = type;
            PreviousNumber = number;

            return CurrentNumber;
        }
    }
}
