﻿// See https://aka.ms/new-console-template for more information


// Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.

Console.Write("Lütfen bir sayı giriniz: ");

int sayac = int.Parse(Console.ReadLine());

for (int i = 1; i <= sayac; i++)
{
    // komutlar
    if(i%2==1)
    {
        Console.WriteLine(i);
    }
}

// 1 ile 1000 arasındaki tek ve çift sayıların toplammlarını ekrana yazdır.
int tekToplam = 0;
int ciftToplam = 0;
for (int i = 0; i <= 1000; i++)
{
    if(i%2 == 1)
         tekToplam += i;

    else
        ciftToplam += i; 
}

Console.WriteLine(tekToplam);
Console.WriteLine(ciftToplam);

// break, continue 

for (int i = 0; i < 10; i++)
{
    if(i==4)
        break;
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++)
{
    if(i==4)
        continue;
    Console.WriteLine(i);
}



