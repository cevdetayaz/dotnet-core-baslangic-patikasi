﻿// See https://aka.ms/new-console-template for more information


// Diziler
string[] renkler = new string[5];

string[] hayvanlar = {"kedi", "köpek", "kuş","maymun"};

int[] dizi;

dizi = new int[5];

// Dizilere Değer atama ve Erişim

renkler[0] = "mavi";
Console.WriteLine(hayvanlar[0]);
dizi[3] = 10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);

// Döngülerle Dizi
// Klavyeden girilen n tane sayının ortalamasını alan program

Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ", i+1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (var sayi in sayiDizisi)
    toplam += sayi;

Console.WriteLine("Ortalama : "+ toplam/diziUzunlugu);
