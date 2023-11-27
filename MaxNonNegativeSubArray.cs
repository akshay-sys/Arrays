/*
Input 1:
A = [1, 2, 5, -7, 2, 3]

Input 2:
A = [10, -1, 2, 3, -4, 100]

Example Output
Output 1:
[1, 2, 5]

Output 2:
[100]

Example Explanation
Explanation 1:
The two sub-arrays are [1, 2, 5] [2, 3].
The answer is [1, 2, 5] as its sum is larger than [2, 3].

Explanation 2:
The three sub-arrays are [10], [2, 3], [100].
The answer is [100] as its sum is larger than the other two.
*/


class Solution {
    public List<int> maxset(List<int> A) {
        
        int n=A.Count;
        int i=0,maxm=0,count=0,start=0,end=-1;
        int fstart=-1,fend=-1;
        long sum=0,maxsum=0;
        
        List<int> res=new List<int>();
        
        while(i<n){
            if(A[i]>=0){
                sum+=A[i];
                count++;
                end++;
            }
            if(sum>maxsum){
                maxsum=sum;
                fstart=start;
                fend=end;
            }
            else if(sum==maxsum && count>maxm){
                maxm=count;
                fstart=start;
                fend=end;
            }
            if(A[i]<0){
                count=0;
                start=i+1;end=i;
                sum=0;
            }
            i++;
        }
        
        if(fstart!=-1&&fend!=-1){
            for(i=fstart;i<=fend;i++)
                res.Add(A[i]);
        }
        return res;
        
    }
}
