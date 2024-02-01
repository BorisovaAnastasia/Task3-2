using System;

public sealed class S_Massiv : Massiv
{
   private int[][] j_array;
  
   public override void NewMassiv()
   {
    Console.WriteLine("You are creating a two-dimensional array. Enter the number of lines ");
    int N = int.Parse(Console.ReadLine());
    j_array = new int[N][];
       Random rnd = new Random();
       for (int i = 0; i < N; i++)
       {
           int len = rnd.Next(1, 11);
           j_array[i] = new int[len];
           for (int j = 0; j < len; j++)
           {
               int value = rnd.Next(0, 101);
               j_array[i][j] = value;
           }
       }
   }
  
   public override void ShowMassiv()
   {
       Console.WriteLine(" ");
       for (int i = 0; i<j_array.Length;i++)
       {
           for (int j = 0; j < j_array[i].Length; j++)
           {
               if(j == j_array[i].Length-1)
               {
                   Console.WriteLine(j_array[i][j]);
               }
               else
               {
                   Console.Write(j_array[i][j]);
                   Console.Write(" ");
               }
           }
       }
       Console.WriteLine(" ");
   }
  
   public override void SredznachMassiv()
   {
       int sum = 0;
       for (int i = 0; i<j_array.Length;i++)
       {
           for (int j = 0; j < j_array[i].Length; j++)
           {
               sum += j_array[i][j];
           }
       }
       int SredznAr = sum / j_array.Length;
       Console.WriteLine($"The average value of the array: {SredznAr}");
   }
}

