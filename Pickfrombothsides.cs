/*
Given an integer array A of size N.

You have to pick exactly B elements from either left or right end of the array A to get the maximum sum.

Find and return this maximum possible sum.

NOTE: Suppose B = 4 and array A contains 10 elements then

You can pick the first four elements or can pick the last four elements or can pick 1 from the front and 3 from the back etc. you need to return the maximum possible sum of elements you can pick.

*/

class Solution {
    public int solve(List<int> A, int B) {
        
        int curr_points = 0; 
        int max_points = 0; 
        
        for(int i = 0; i < B; i++) 
            curr_points += A[i]; 
  
        max_points = curr_points; 
  
        int j = A.Count-1; 
  
        for(int i = B - 1; i >= 0; i--){ 
            curr_points = curr_points + A[j] - A[i]; 
            max_points = Math.Max(curr_points, max_points); 
            j--; 
        } 
        return max_points;
    }
}
