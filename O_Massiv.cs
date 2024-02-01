using System;

public sealed class O_Massiv : Massiv
{
   private int[] massiv;

   public override void NewMassiv()
   {
    Console.WriteLine("You are creating a one-dimensional array. Enter the number of items ");
    int N = int.Parse(Console.ReadLine());
       massiv = new int[N];
       Random rnd = new Random();
        for (int i = 0; i < N; i++)
        {
            int value = rnd.Next(101);
            int x = value;
            massiv[i] = x;
        }
   }
  
   public override void ShowMassiv()
   {
       Console.WriteLine(" ");
       for (int i = 0; i < massiv.Length; i++)
       {
           Console.WriteLine(massiv[i]);
       }
       Console.WriteLine(" ");
   }

   public override void SredznachMassiv()
   {
       int sum = 0;
       for (int i = 0; i < massiv.Length; i++)
       {
           sum += massiv[i];
       }
       int sredzn = sum / massiv.Length;
       Console.WriteLine($"The average value of the array: {sredzn}");
       Console.WriteLine(" ");
   }
}