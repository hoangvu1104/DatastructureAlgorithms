namespace DatastructureAlgorithms
{
    public class BinarySearch
    {
        public static int MyBinarySearch(int[] arr, int item)
        {
            int low = 0;
            int high = arr.Length - 1;
            while(low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == item) return mid;               
                else if (arr[mid] < item) low = mid + 1;
                else high = mid - 1;                
            }
            return -1;
        }
    }
}
