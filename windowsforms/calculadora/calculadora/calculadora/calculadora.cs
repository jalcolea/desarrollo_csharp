using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace calculadora
{
    class calculadora
    {
        private List<string> cut(string input)
        {
            input = input.Replace(" ", "");
            //List<string> result = new List<string>(input.Split(' '));
            List<string> result = new List<string>();
            int lastpos = -1;
            for (int cont=0;cont < input.Length;cont++)
            {
                if (input[cont] == '+' || input[cont] == '-' || input[cont] == '*' || input[cont] == '/')
                {
                    result.Add(input.Substring((lastpos+1), cont - (lastpos+1)));
                    result.Add(input[cont].ToString());
                    lastpos = cont;
                }
                else if ((cont == (input.Length-1)) && (lastpos< input.Length))
                {
                    result.Add(input.Substring(lastpos+1, cont - lastpos));
                }
            }
            return result;
        }

        private double calc (List <string> input)
        {
            double result = 0;
            string operat = "";
            double currentvalue = 0;
            foreach (string item in input)
            {
                if (item == "+" || item == "-" || item == "*" || item == "/")
                {
                    if (result == 0) result = currentvalue;
                    operat = item;
                }
                else
                {
                    currentvalue = Convert.ToDouble(item);
                    switch (operat)
                    {
                        case "+":
                            result = result + currentvalue;
                            operat = "";
                            break;
                        case "-":
                            result = result - currentvalue;
                            operat = "";
                            break;
                        case "*":
                            result = result * currentvalue;
                            operat = "";
                            break;
                        case "/":
                            result = result / currentvalue;
                            operat = "";
                            break;
                        default:
                            break;
                    }

                }
            }
            return result;
        }
        private void log(List<string> input)
        {
            foreach(string item in input)
            {
                Debug.WriteLine(item);
            }
                   
        }
    public string calculate (string input)
        {
            List<String> elements;

            elements = cut(input);
            log(elements);
            return calc(elements).ToString();
        }
    }
}

