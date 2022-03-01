// See https://aka.ms/new-console-template for more information


Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);

int sicaklik = 32;

if(sicaklik <= (int)HavaDurumu.Normal)
    Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
else if (sicaklik >= (int)HavaDurumu.CokSicak)
    Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.Sıcak)
    Console.WriteLine("Hadi dışarıya çıkalım");



enum Gunler
{
    Pazartesi,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma = 23,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soguk = 5,
    Normal = 20,
    Sıcak = 25,
    CokSicak = 30

}
