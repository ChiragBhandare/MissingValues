using System;
 
class missval {
    
    static int getMissingNo(int[] a, int n)
    {
        int total = (n + 1) * (n + 2) / 2;
 
        for (int i = 0; i < n; i++)
            total -= a[i];
 
        return total;
    }
 
    
    public static void Main()
    {
        string val;
        int n;
          val = Console.ReadLine();

      
        n = Convert.ToInt32(val);
        int[] a = new int[n]; 
    int i;  
      
    Console.Write("Input  elements in the array :\n");  
    for(i=0; i<n; i++)  
    {  
	    Console.Write("element - {0} : ",i+1);
	    a[i] = Convert.ToInt32(Console.ReadLine());  		
    }  
        int miss = getMissingNo(a, n);
        Console.Write(miss);
    }
}