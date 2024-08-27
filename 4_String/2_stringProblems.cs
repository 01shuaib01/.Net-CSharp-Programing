// See https://aka.ms/new-console-template for more information
public class Program{

    bool checkPalindromeString(string str){
        int start = 0;
        int end = str.Length-1;

        while(start < end){
            if(str[start]!=str[end])
                return false;
            start++;
            end--;
        }
        return true;
    }

    string reverseString(string str){
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        str = new string(arr);
        return str;
    }

    string reverseString2(string str){
        // without using predefined function
        int start = 0;
        int end = str.Length-1;
        char[] arr = str.ToCharArray();
        while (start < end){
            char temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
        }
        str = new string(arr);
        Console.WriteLine((str));
        return str;
    }

    int sumOfNumber(string str){
        int sum = 0;
        char[] arr = str.ToCharArray();
        for(int i = 0; i < arr.Length;i++){
            char ch = arr[i];
            if(Char.IsDigit(ch)){
                int temp = (int)Char.GetNumericValue(ch);
                sum+=temp;
            }
        }
        return sum;
    }
    
    bool anagram(string str1, string str2){
        char[] arr1 = str1.ToCharArray();
        char[] arr2 = str2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        str1 = new string(arr1);
        str2 = new string(arr2);

        if(str1.Equals(str2)){
            return true;
        }
        return false;
    }
    public static void Main(string[] args)  {
        //string str = "shuaib";
        string myName = "abc123xyz45mno67";
        Program obj = new Program();

        // if(obj.checkPalindromeString(str))
        //     Console.WriteLine("String is palindrome");
        // else    
        //     Console.WriteLine("String is not a palindrome");
        
        // Console.WriteLine(obj.reverseString(str));
        //Console.WriteLine(obj.reverseString2(str));
        Console.WriteLine(obj.sumOfNumber(myName));
        string str1 = "listen"; 
        string str2 = "silent";
        Console.WriteLine(obj.anagram(str1, str2));
       
    }
}


 