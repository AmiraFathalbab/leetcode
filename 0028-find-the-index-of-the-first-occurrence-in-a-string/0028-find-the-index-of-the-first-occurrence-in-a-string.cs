public class Solution {
    public int StrStr(string haystack, string needle) {  
        bool check=haystack.Contains(needle);
        if(check)
        {
            return haystack.IndexOf(needle);
        }
        else
            return -1;
        // int i=0;     
        // int count=0;
        // int n=0;                      
        // for(int j=0;j<haystack.Length;j++)
        // {

            // if(count==1)
            // {
            //     n++;               
            //     if(n>needle.Length-1)
            //     {
            //         i=0;
            //         j=j-(needle.Length-1);
            //         count=0;
            //     }
            // }
            // if(needle[i]==haystack[j])
            // {
            //     count=1;
            //     if(i==needle.Length-1)
            //         return j-(needle.Length-1);
                
            //     i++;               
            // }
        // }          
        // return -1;
            
        
        
    }
}