using System;


namespace MyCalculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Devide(int dividend, int divisor)
        {
            return dividend / divisor;
        }

        public int Test(int dividend, int divisor)
        {
            var calcuator = new Calculator();

            int result = 0;
            try
            {
                result = calcuator.Devide(dividend, divisor);
            }
            catch (DivideByZeroException)
            {
                result = int.MaxValue;
            }
            catch (Exception )
            {
                result = int.MinValue;
            }
            return result;
        }

    }
}
