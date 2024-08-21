// See https://aka.ms/new-console-template for more information
public class Program{
    void print(int[] arr){
        for(int i=0;i<arr.Length;i++){
            Console.WriteLine(arr[i]);
        }  
    }

    int getMax(int[] arr){
        int maxVal = int.MinValue;
        for(int i = 0;i<arr.Length;i++){
            if(arr[i] > maxVal)
                maxVal = arr[i];
        }
        return maxVal;
    }
    int getMin(int[] arr){
        int minValue = int.MaxValue;
        for(int i = 0;i<arr.Length;i++){
            if(arr[i] < minValue){
                minValue = arr[i];
            }
        }
        return minValue;
    }
    int getMaxUsingSort(int[] arr){
        Array.Sort(arr);
        return arr[arr.Length-1];
    }
    int getMinUsingSort(int[] arr){
        Array.Sort(arr);
        return arr[0];
    }
    public static void Main(string[] args)  {
        Console.WriteLine("Hello");
        int[] arr = {11, 22,333,4,55,}   ; 
        Program obj = new Program();
        obj.print(arr);
        Console.WriteLine("Max value is "+obj.getMax(arr));
        Console.WriteLine("Min value is "+obj.getMin(arr));
        Console.WriteLine("Max  value using sort function "+obj.getMaxUsingSort(arr));
        Console.WriteLine("Min  value using sort function "+obj.getMinUsingSort(arr));
       
    }
}