using System;

namespace SimpleCalc
{
    public class SimpleCalc
    {
        public decimal add(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber + rightNumber;
        }
        public decimal sub(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber - rightNumber;
        }
        public decimal multi(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber * rightNumber;
        }
        public decimal divide(decimal leftNumber, decimal rightNumber)
        {
            return leftNumber / rightNumber;
        }
        public string OperatorSwitch(decimal leftNumber, decimal rightNumber, string operation)
        {
            decimal result = 0;
            bool errorState = false;
            switch (operation)
            {
                case "+":
                    result = leftNumber + rightNumber;
                    break;
                case "-":
                    result = leftNumber - rightNumber;
                    break;
                case "*":
                    result = leftNumber * rightNumber;
                    break;
                case "/":
                    result = rightNumber != 0 ? leftNumber / rightNumber : 0;
                    errorState = rightNumber != 0 ? false : true;
                    break;
                default:
                    errorState = true;
                    break;
            }

            string resultStr = "";
            resultStr += result;
            if (errorState)
            {
                resultStr = "error!. divided by zero";
            }
            return resultStr;
        }
    }
}
