public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Create an array of doubles with the given length
        double[] result = new double[length];

        // Step 2: Use a loop to fill each index with the correct multiple of 'number'
        // The first element should be 1 * number, then 2 * number, etc., up to length
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1); // index 0 → number * 1, index 1 → number * 2, etc.
        }

        // Step 3: Return the filled array
        return result;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Understand that rotating right by 'amount' means
        // the last 'amount' elements move to the front.

        // Step 2: Use GetRange to get the last 'amount' elements
        List<int> tail = data.GetRange(data.Count - amount, amount);

        // Step 3: Use GetRange to get the remaining elements from the front
        List<int> head = data.GetRange(0, data.Count - amount);

        // Step 4: Clear the original list
        data.Clear();

        // Step 5: Add the tail first (rotated to front), then the head
        data.AddRange(tail);
        data.AddRange(head);

        // Step 6: Done! The data list has been modified
        //  in place



    }

}
