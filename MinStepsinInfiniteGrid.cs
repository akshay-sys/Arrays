/*
Input:
A = [0, 1, 1]
B = [0, 1, 2]

Output
Output:
2

Explanation:
Given three points are: (0, 0), (1, 1) and (1, 2).
It takes 1 step to move from (0, 0) to (1, 1). It takes one more step to move from (1, 1) to (1, 2).

*/

class Solution {
    public int coverPoints(List<int> A, List<int> B) {
        
        int prevA=A[0];
        int prevB=B[0];
        
        int n=A.Count();
        
        int result=0;
        
        for(int i=1;i<n;i++){
            int currA=A[i];
            int currB=B[i];
            
            int diffA=Math.Abs(currA-prevA);
            int diffB=Math.Abs(currB-prevB);
            
            result+=Math.Max(diffA,diffB);
            
            prevA=currA;
            prevB=currB;
        }
        
        return result;
    }
}
