namespace ArrayMethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static Methods of Array Class:
            // Exists: condz vera almeno per un elemento
            // TrueForAll: condz vera per tutti gli elementi
            // Find: trova il primo elemento per cui è vera la condz
            // FinadAll:  to get a new array with all the elements that meet the given condition
            // IndexOf: o check whether the array contains a given element or not

            int[] numbers = [9, -11, -6, -12, 0];
            bool anyPositive = Array.Exists(numbers, e => e > 0);
            bool noZeros = Array.TrueForAll(numbers, e => e != 0);
            int firstNegative = Array.Find(numbers, e => e < 0);
            int[] negatives = Array.FindAll(numbers, e => e < 0);
            int index = Array.IndexOf(numbers, -12);

            // ForEach: to perform some operations for all the elements in the array.
            Array.ForEach(numbers,
                e => Console.WriteLine(Math.Abs(e)));

            // Reverse: to reverse the order of the elements, either for the whole array or only within some range
            // Sort:  to sort the whole array
            // Fill: to fill the array with the same value 
            // Clear: to fill the  array with the default value of the integer type
            Array.Reverse(numbers, 0, 3);
            Array.Sort(numbers);
            Array.Fill(numbers,3,1,3);
            Array.Clear(numbers);
            // Copy: copies a range of elements from the source array to the destination array
            int[] subarray = new int[3];
            Array.Copy(numbers, 0, subarray, 0, 3);
        }
    }
}
