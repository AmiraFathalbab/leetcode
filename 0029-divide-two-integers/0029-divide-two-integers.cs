public class Solution {
    public int Divide(int dividend, int divisor) {
        int res=0;
        long dividend1=dividend;
        long divisor1=divisor;
        if(dividend1==-2147483648&&divisor1==-1)
        {return 2147483647;}
        if(divisor1==1)
        {return dividend;}
        if(Math.Abs(dividend1)<Math.Abs(divisor1))
        {return res;}
        if((dividend1<0&&divisor1<0) ||(dividend1>0&&divisor1>0))
        {
            for(int n=100;n>0;n--){
            while(Math.Abs(dividend1)>=n*Math.Abs(divisor1))
            {
                dividend1=Math.Abs(dividend1)-n*Math.Abs(divisor1);
                
                res+=n;
            }
            }
            return res;

        }
        else {//if((dividend<0&&divisor>0) ||(dividend>0&&divisor<0)){
            //try{
            for(int n=100;n>0;n--){
            while(Math.Abs(dividend1)>=n*Math.Abs(divisor1))
            {
                dividend1=Math.Abs(dividend1)-n*Math.Abs(divisor1);
                
                res-=n;
            }
            }
           
            return res;
        }
        // else
        //     return res;

        
        
    }
}