using System;

public sealed class D_Massiv : Massiv
{
   private int[,] massiv;
  
   public override void NewMassiv()
   {
    Console.WriteLine("You are creating a two-dimensional array. Enter the number of lines ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the number of columns ");
    int K = int.Parse(Console.ReadLine());
       massiv = new int[N, K];
       Random rnd = new Random();
       for (int i=0; i < N; i+=1)
       {
           for (int j = 0; j < K; j++)
           {
               int value = rnd.Next(0, 101);
               massiv[i,j] = value;
           }
       }
   }
  
   public override void SredznachMassiv()
   {
       int sum = 0;
       for (int i = 0; i < massiv.GetLength(0); i++)
       {
           for (int j = 0; j < massiv.GetLength(1); j++)
           {
               sum += massiv[i, j];
           }
       }
       int sredzn = sum / massiv.Length;
       Console.WriteLine($"The average value of the array: {sredzn}");
       Console.WriteLine(" ");
   }
  
   public override void ShowMassiv()
   {
       Console.WriteLine(" ");
       for (int i=0; i < massiv.GetLength(0); i+=1)
       {
           for (int j = 0; j < massiv.GetLength(1); j++)
           {
               if(j == massiv.GetLength(1)-1)
               {
                   Console.WriteLine(massiv[i,j]);
               }
               else
               {
                   Console.Write(massiv[i,j]);
                   Console.Write(" ");
               }
           }
       }
       Console.WriteLine(" ");
   }
}
