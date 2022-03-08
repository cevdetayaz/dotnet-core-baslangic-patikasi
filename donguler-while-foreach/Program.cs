// See https://aka.ms/new-console-template for more information


// while 
// 1'den başlayarak konsoldan girilen sayıya kadar (sayı dahil) ortalam hesaplayıp konsola yazdıran program.

Console.Write("Bir sayı giriniz: ");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi)
{
    toplam += sayac;
    sayac++;

    
}
Console.WriteLine(toplam/sayi);


// 'a' dan 'z' ye kadar tüm harfleri yazdır.

char character = 'a';

while (character < 'z')
{
    Console.Write(character);
    character++;
}

Console.WriteLine("****  Foreach  ****");

string[] arabalar = {"BMW", "FORD", "TOYOTA", "NISSAN"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}