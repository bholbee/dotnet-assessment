namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
        static void find_idx(int[] arr, int n)
        {
     
        // List to store the indices
        List<int> answer = new List<int>();
     
        // Initialise sum with 0
        int sum = 0;
     
        // Starting from the last element
        for (int i = n - 1; i >= 0; i--)
        {
     
            // If sum till now is equal to
            // the current element
            if (sum == arr[i])
            {
                answer.Add(i);
            }
     
            // Add current element to the sum
            sum += arr[i];
        }
     
        if (answer.Count == 0)
        {
            Console.WriteLine("-1");
            return;
        }
     
        for (int i = answer.Count - 1; i >= 0; i--)
            Console.Write(answer[i] + " ");
        }
      public int Find(int[] numbers)
        {
            int[] arr = { 36, 2, 17, 6, 6, 5 };
            int n = arr.Length;
     
            find_idx(arr, n);
            return n;
        }
    }
}
