// See https://aka.ms/new-console-template for more information
public class Program{
    
    // Time Complexity --> O(N2)
    void findDuplicate(int[] arr){
        for(int i = 0;i<arr.Length;i++){
            for(int j = i+1;j<arr.Length;j++){
                if(arr[j] == arr[i])
                    Console.WriteLine(arr[i]);
            }
        }
    }

    // Time Complexity --> O(NLogN)
    void findDuplicate2(int[] arr){
        Array.Sort(arr);
        for(int i = 0;i<arr.Length-1;i++){
            if(arr[i] == arr[i+1]){
                Console.WriteLine(arr[i]);
            }
        }
    }
    public static void Main(string[] args)  {
        int[] arr = {11, 22,11,4,55,6,4}   ; 
        Program obj = new Program();
        obj.findDuplicate(arr);
        obj.findDuplicate2(arr);
       
       
    }
}