// See https://aka.ms/new-console-template for more information
public class Program{
    
    void demoString(string str){
        Console.WriteLine(str);
        Console.WriteLine("Length --> "+str.Length);
        Console.WriteLine(str.IndexOf('S'));    // return index of char
        Console.WriteLine(str.LastIndexOf("S"));
        Console.WriteLine(str.ToLower());   // Conver into lower case
        Console.WriteLine(str.ToUpper());   // Convert into Upper case
        Console.WriteLine(str.StartsWith("Mohd"));
        Console.WriteLine(str.EndsWith("shuaib"));
        Console.WriteLine(str.Contains("Shuaib"));
        Console.WriteLine(str.Equals("Mohd shuaib"));
        Console.WriteLine(str.Equals("mohd shuaib",StringComparison.OrdinalIgnoreCase));

    }
    
    public static void Main(string[] args)  {
        string str = "Mohd Shuaib";
        Program obj = new Program();
        obj.demoString(str);
       
    }
}


 