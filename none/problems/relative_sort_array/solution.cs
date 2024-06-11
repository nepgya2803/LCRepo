public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        int max = arr1.Max(); 
        int[] countArr = new int[max + 1]; 

        // Count the array 1
        for (int i = 0; i < arr1.Length; i++)
        {
            countArr[arr1[i]]++;
        }

        List<int> result = new List<int>();
        for (int i = 0; i < arr2.Length; i++)
        {
            for (int ind = 0; ind < countArr[arr2[i]]; ind++)
            {
                result.Add(arr2[i]);
            }

            countArr[arr2[i]] = 0;
        }


        for (int ind = 0; ind < countArr.Length; ind++)
        {
            for (int i = 0; i < countArr[ind]; i++)
            {
                result.Add(ind);
            }

        }

        return [.. result];
    }
}