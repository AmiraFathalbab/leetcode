public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        //int index;
        string res=string.Empty;
        if(strs.Length==1)
            return strs[0];    
        for(int l=0;l<strs.Length;l++)
        {
            if(strs[l]=="")
                return "";
        }    
        int k=0;
        int i=0;
        //for(int i=0;i<strs.Length;i++){
            
            for(int j=0;j<strs[i].Length;j++){
                for(int s=1;s<strs.Length;s++){
                    if(k<strs[s].Length){
                        if(strs[i][j]==strs[s][k]){                      
                            
                            if(s==strs.Length-1){ 
                                k+=1;                              
                                res+=(strs[i][j]);}   
                                                     
                        }
                        else{
                            //s--;
                            //k++; 
                            return res;                          
                        }
                    }
                    else
                        return res;
                }
            }
        
        return res;
    }
}