using System;

class Program
{
    static void Main()
    {
        Massiv[] mass = new Massiv[3];
        Massiv o_mas = new O_Massiv();
        Massiv d_mas = new D_Massiv();
        Massiv s_mas = new S_Massiv();
        mass[0] = o_mas;
        mass[1] = d_mas;
        mass[2] = s_mas;
        for (int i = 0; i < 3; i++)
        {
            mass[i].NewMassiv();
            mass[i].ShowMassiv();
            mass[i].SredznachMassiv();
        }
    }
}
