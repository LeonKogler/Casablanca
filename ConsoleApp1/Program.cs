// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1;



public static class Sort
{
    private static void Main(string[] args)
    {
    }
    public static int[] Mergesort(int[] input)
    {
        decimal a = 0;
        if (input.Length <= 1)
        {
            return input;
        }
    
        int lenght = input.Length;
        int[] l = Mergesort(input.Take(lenght / 2).ToArray());
        int[] r = Mergesort(input.Skip(lenght / 2).ToArray());

        int il = 0;
        int ir = 0;
        int lLenght = l.Length;
        int rLenght = r.Length;
        int[] merged = new int[input.Length];
        
        for (int i = 0; i < lenght; i++)
        {
            if (il >= lLenght)
            {
                merged[i] = r[ir];
                ir++;
                continue;
            }
            if (ir >= rLenght)
            {
                merged[i] = l[il];
                il++;
                continue;
            }
        
            if (l[il] < r[ir])
            {
                merged[i] = l[il];
                il++;
            }
            else
            {
                merged[i] = r[ir];
                ir++;
            }
        }
        return merged;
    }
}