using System.Collections.Generic;

namespace UserInterface.Extensions
{
    public static class IEnumerableExtension
    {
        public static double Prod(this IEnumerable<double> arr)
        {
            double result = 1;
            foreach (double n in arr)
                result *= n;
            return result;
        }
    }
}
