public class Solution {
    public int RomanToInt(string s) {
        int res= 0;
        //string[] r=["I","V","X","L","C","D","M"];
        for(int i=0;i<s.Length;i++)
        {
            switch(s[i])
            {
            case 'I':
            {
                if(i!=s.Length-1&&s[i+1]== 'V')
                {   
                    res+=4;
                    i+=1;
                }
                else if(i!=s.Length-1&&s[i+1]== 'X')
                {   
                    res+=9;
                    i+=1;
                }
                else
                    res+=1;
                break;
                
            }
            
            
            case 'V':
            {
                res+=5;
                break;
            }

            
            case 'X':
            {
                if(i!=s.Length-1&&s[i+1]== 'L')
                {
                    res+=40;
                    i+=1;
                }
                else if(i!=s.Length-1&&s[i+1]== 'C')
                {
                    res+=90;
                    i+=1;
                }
                else
                    res+=10;
                break;
            }
            
            case 'L':
            {
                res+=50;
                break;
            }
            
           case  'C':
            {
                if(i!=s.Length-1&&s[i+1]== 'D')
                {
                    res+=400;
                    i+=1;
                }
                else if(i!=s.Length-1&&s[i+1]== 'M')
                {
                    res+=900;
                    i+=1;
                }
                else
                    res+=100;
                break;
                
            }
            
            case 'D':
            {
                res+=500;
                break;
            }
            case 'M':
            {
                res+=1000;
                break;
            }
        }
            

        }
        
        return res;
    }
}