class Program{
    static void GenerateArray1D(out Array arr, int len, int lb){
        arr = Array.CreateInstance(typeof(int), new int[1]{len}, new int[1]{lb});
        Random r = new Random();
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            arr.SetValue(r.Next(1, 99), i);
    }
    static void PrintArray1D(Array arr){
        foreach(int v in arr)
            System.Console.Write(v + " ");
        System.Console.WriteLine();
    }
    static int SumArray1D(Array arr){
        int sum = 0;
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            sum += (int)arr.GetValue(i);
        /*foreach(int v in arr)
            sum += v;*/
        return sum;
    }
    static void Main(string[] args){
        Console.Clear();
        
        Array arr;
        GenerateArray1D(out arr, 5, 1);
        PrintArray1D(arr);
        System.Console.WriteLine("Tong Array: {0}", SumArray1D(arr));

        /*Array arr = Array.CreateInstance(typeof(int), new int[1]{5}, new int[1]{1});
        System.Console.WriteLine("Chi so duoi {0}", arr.GetLowerBound(0));
        System.Console.WriteLine("Chi so tren {0}", arr.GetUpperBound(0));
        System.Console.WriteLine("Length {0}", arr.GetLength(0));
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            System.Console.WriteLine("arr[{0}]={1}", i, arr.GetValue(i));
        
        for(int i=arr.GetLowerBound(0); i<arr.GetLowerBound(0)+arr.GetLength(0); i++)
            System.Console.WriteLine("arr[{0}]={1}", i, arr.GetValue(i));*/
        Console.ReadLine();
    }
}