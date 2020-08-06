namespace ProductSum
{
    public class ProdSum
    {
        /// <summary>
        /// Get the product sum of the given array:
        /// [5,2,[7,-1],3,[6,[-13,8],4]]
        /// The subarray will be multiplied by the depth
        /// Result should be 12
        /// </summary>
        /// <param name="array"></param>
        /// <param name="multiplier"></param>
        /// <returns></returns>

        public int ProductSum(object[] array, int multiplier = 1)
        {
            int sum = 0;
            foreach (object element in array)
            {
                if (element.GetType().IsArray)
                {
                    sum += ProductSum(element as object[], multiplier + 1);
                }
                else
                {
                    sum += (int)element;
                }
            }
            return sum * multiplier;

        }
    }
}
