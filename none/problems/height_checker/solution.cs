public class Solution {
    public int HeightChecker(int[] heights) {
        int count = 0;
        int[] sortedArr = new int[heights.Length];
        heights.CopyTo(sortedArr, 0);
        heapSort(ref sortedArr);
        for(int i = 0; i < heights.Length; i++)
        {
            if(heights[i] != sortedArr[i])
                count++;
        }
       
        return count;
    }

    public void heapify(ref int[] arr, int n, int i) {
        // Initialize largest as root 'i'.
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        // If the left child is larger than the root.
        if (left < n && arr[left] > arr[largest]) {
            largest = left;
        }

        // If the right child is larger than the largest so far.
        if (right < n && arr[right] > arr[largest]) {
            largest = right;
        }

        // If largest is not root swap root with the largest element
        // Recursively heapify the affected sub-tree (i.e. move down).
        if (largest != i) {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            heapify(ref arr, n, largest);
        }
    }

    public void heapSort(ref int[] arr) {
        int n = arr.Length;
        // Build heap; heapify all elements except leaf nodes, in bottom-up
        // order.
        for (int i = n / 2 - 1; i >= 0; i--) {
            heapify(ref arr, n, i);
        }

        // Traverse elements one by one, to move the current root to the end,
        // and
        for (int i = n - 1; i >= 0; i--) {
            (arr[0], arr[i]) = (arr[i], arr[0]);
            // call max heapify on the reduced array.
            heapify(ref arr, i, 0);
        }
    }
}