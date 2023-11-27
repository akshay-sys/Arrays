class Solution {
    
    public int multiply(int num, int [] list, int size){
        
        int carry=0;
        
        for(int i=0;i<size;i++){
            int product = num*list[i]+carry;
            list[i]=product%10;
            carry=product/10; 
        }
        while (carry != 0) {
            list[size] = carry%10;
            carry = carry/10;
            ++size;
        }
        return size;
    }
    public string solve(int A) {
        
        int[] result=new int[200];
        result[0]=1;
        string res="";
        
        int size=1;
        
        for(int i=A; i>=2;i--){
            size=multiply(i,result,size);
        }
        
        for (int i = size-1; i > -1; --i)
            res += result[i];
        return res;
    }
}
