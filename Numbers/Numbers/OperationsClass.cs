namespace Opeartions
{
    static class OperationsClass
    {
        /// <summary>
        /// Function that returns the sum of 3 numbers
        /// </summary>
        public static double Sum(double a, double b, double c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Function that returns the Product of 3 numbers
        /// </summary>
        public static double Product(double a, double b, double c)
        {
            return a * b * c;
        }

        /// <summary>
        /// Function that returns the sum of 3 numbers
        /// </summary>
        public static double Average(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
        /// <summary>
        /// Compares the 3 numbers that are given, and modifies...
        /// ...the greatest and smallest variables to contain a correct answer
        /// </summary>
        public static void Compare(double a, double b, double c, ref double greatest, ref double smallest)
        {
            if (a != b)                             
            {
                if (a > b)
                {
                    if (c > a)
                    {
                        greatest = c;
                        smallest = b;
                    }
                    else
                    {
                        greatest = a;
                        if (b > c)
                        {
                            smallest = c;
                        }
                        else
                        {
                            smallest = b;
                        }
                    }
                }
                else
                {
                    if (c > b)
                    {
                        greatest = c;
                        smallest = a;
                    }
                    else
                    {
                        greatest = b;
                        if (a > c)
                        {
                            smallest = c;
                        }
                        else
                        {
                            smallest = a;
                        }
                    }
                }
            }
            else if (c > a)
            {
                greatest = c;
                smallest = a;
            }
            else
            {
                greatest = a;
                smallest = c;
            }
        }
    }
}