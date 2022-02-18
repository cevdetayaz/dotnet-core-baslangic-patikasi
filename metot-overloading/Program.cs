// See https://aka.ms/new-console-template for more information


// out parametreler
string sayi = "999";


bool sonuc = int.TryParse(sayi, out int outSayi);

if(sonuc)
{
    Console.WriteLine("Başarılı!");
    Console.WriteLine(outSayi);
}
else {
    Console.Write("Başarısız");
}

Metotlar instance = new Metotlar();
instance.Topla(4,5, out int toplalmSonucu);
Console.WriteLine(toplalmSonucu);


// Metot Aşırı Yükleme - Overloading

int ifade = 999;
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir(ifade);
instance.EkranaYazdir("Zikriye","Ürkmez");
instance.EkranaYazdir(5);
instance.EkranaYazdir(6,8);


// Metot imzası
// MetotAdo + parametre sayısı + parametre

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a+b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri, int veri2)
    {
        Console.WriteLine(veri+veri2);
    }
    public void EkranaYazdir(string veri, string veri2)
    {
        Console.WriteLine(veri+veri2);
    }
}


