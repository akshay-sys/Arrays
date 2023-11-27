class Solution {
    public List<int> spiralOrder(List<List<int>> A) {
        
        List<int> result=new List<int>();
        
        int i=0, k=0, l=0;
        int m=A.Count;
        int n=A[i].Count;
        
        while(k<m && l<n){
            for (i = l; i < n; ++i) {
                result.Add(A[k][i]);
            }
            k++;
 
            for (i = k; i < m; ++i) {
                result.Add(A[i][n - 1]);
            }
            n--;
 
            if (k < m) {
                for (i = n - 1; i >= l; --i) {
                    result.Add(A[m - 1][i]);
                }
                m--;
            }
 
            if (l < n) {
                for (i = m - 1; i >= k; --i) {
                    result.Add(A[i][l]);
                }
                l++;
            }
        }
        
        return result;
        
    }
}
