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
        // step 1: initialize a new integer array with the specified length
        double[] multiples = new double[length];
        // step 2: loop through the array starting at 0 upto length - 1
        for (int i = 0; i < length; i++)
        //calculate and store each multiple
        {
            multiples[i] = number * (i + 1);
        }
        //step 3: return the populated array
        return multiples; 
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
        // Step 1: Handle edge cases where no rotation is needed
        // cases where if the list is empty, has only 1 element, or amount matches the count, retur immediately
        if (data == null || data.Count <= 1 || amount == data.Count)
        {
            return;
        }

        // step 2: find the exact index where the list splits
        //calculate how many elements from the back need to move to the front
        int splitIndex = data.Count - amount;

        // step 3: separate the list into 2 segments
        //get the elements that will move to the back
        List<int> frontPart = data.GetRange(0,splitIndex);
        //get the elements that will move to the front
        List<int> backPart = data.GetRange(splitIndex, amount); 

        //step 4: recombine the segments to form a new rotated list
        //clear existing list to overwrite them in place
        data.Clear();
        //add the back part first, followed by the front part
        data.AddRange(backPart);
        data.AddRange(frontPart);


    }
}
