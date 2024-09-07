public class Solution {
    public bool IsPalindrome(int x) {
        int nombreinverse=0;
        bool answer;
        int temp=x;
    while(x>0)
    {
        int reste=x%10;
        nombreinverse=nombreinverse*10+reste;
        x/=10;
    }
    if(temp==nombreinverse)
    {
        answer=true;
    }
    else
        answer=false;
    return answer;    
    }
}