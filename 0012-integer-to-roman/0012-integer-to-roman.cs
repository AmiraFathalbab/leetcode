public class Solution {
    public string IntToRoman(int num) {
        string s= num.ToString();
        
        double count=s.Length;
        string res="";
        Dictionary<int, char> roman = new Dictionary<int, char>();
        roman.Add(1,'I');
        roman.Add(5,'V');
        roman.Add(10,'X');
        roman.Add(50,'L');
        roman.Add(100,'C');
        roman.Add(500,'D');
        roman.Add(1000,'M');
 

        for(int i=0;i<s.Length;i++)
        {
            
            
            if(s[i]<'4')
            {
                
                for(int j=0;j<s[i]- '0';j++)
                    res+=(roman[(int)Math.Pow(10,count-1)]);
                    
            }
            else if(s[i]=='4')
            {
                
                res+=(roman[(int)Math.Pow(10,count-1)]);
                res+=(roman[(int)(5*Math.Pow(10,count-1))]);
            }
            else if(s[i]=='5')
            {
                
                res+=(roman[(int)(5*Math.Pow(10,count-1))]);
            }
            else if(s[i]=='6')
            {
                
                res+=(roman[(int)(5*Math.Pow(10,count-1))]);
                res+=(roman[(int)Math.Pow(10,count-1)]);
            }
            else if(s[i]=='7')
            {
                
                res+=(roman[(int)(5*Math.Pow(10,count-1))]);
                res+=(roman[(int)Math.Pow(10,count-1)]);
                res+=(roman[(int)Math.Pow(10,count-1)]);
            }
            else if(s[i]=='8')
            {
                
                res+=(roman[(int)(5*Math.Pow(10,count-1))]);
                res+=(roman[(int)Math.Pow(10,count-1)]);
                res+=(roman[(int)Math.Pow(10,count-1)]);
                res+=(roman[(int)Math.Pow(10,count-1)]);
            }
            else if(s[i]=='9')
            {               
                res+=(roman[(int)Math.Pow(10,count-1)]);
                res+=(roman[(int)(10*Math.Pow(10,count-1))]);
                
            }

            count--;

        }
        return res;


    }
}