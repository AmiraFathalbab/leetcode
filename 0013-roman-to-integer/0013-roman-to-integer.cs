public class Solution {
    public int RomanToInt(string s) {
        int res= 0;
        //string[] r=["I","V","X","L","C","D","M"];
        for(int i=0;i<s.Length;i++)
        {
            if(string.Equals(s[i], 'I'))
            {
                if(i!=s.Length-1&&string.Equals(s[i+1], 'V'))
                {   
                    res+=4;
                    i+=1;
                }
                else if(i!=s.Length-1&&string.Equals(s[i+1], 'X'))
                {   
                    res+=9;
                    i+=1;
                }
                else
                    res+=1;
                
            }
            
            
            else if(string.Equals(s[i], 'V'))
            {
                res+=5;
            }

            
            else if(string.Equals(s[i], 'X'))
            {
                if(i!=s.Length-1&&string.Equals(s[i+1], 'L'))
                {
                    res+=40;
                    i+=1;
                }
                else if(i!=s.Length-1&&string.Equals(s[i+1], 'C'))
                {
                    res+=90;
                    i+=1;
                }
                else
                    res+=10;
            }
            
            else if(string.Equals(s[i], 'L'))
            {
                res+=50;
            }
            
           else if(string.Equals(s[i], 'C'))
            {
                if(i!=s.Length-1&&string.Equals(s[i+1], 'D'))
                {
                    res+=400;
                    i+=1;
                }
                else if(i!=s.Length-1&&string.Equals(s[i+1], 'M'))
                {
                    res+=900;
                    i+=1;
                }
                else
                    res+=100;
                
            }
            
            else if(s[i]== 'D')
            {
                res+=500;
            }
            else if(s[i]== 'M')
            {
                res+=1000;
            }

            
Console.WriteLine(i);
        }
        
        return res;
    }
}